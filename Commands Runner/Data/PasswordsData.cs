using Commands_Runner.Extensions;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Data
{
    public static class PasswordsData
    {
        public static void CheckTable()
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Passwords (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL
                );
            ";

            AppHelper.DATA.ExecuteScalarOpen(query);
        }

        public static int NextId()
        {
            string query = @"SELECT max(Id) as ID FROM Passwords";
            int result = AppHelper.DATA.GetValueOpen<int?>(query) ?? 0;
            return result + 1;
        }

        public static void Save(PasswordModel model)
        {
            model.Id = model.Id == 0 ? NextId() : model.Id;

            string query = @"
                INSERT INTO Passwords (Id, Name, Username, Password)
                VALUES (@Id, @Name, @Username, @Password)
                ON CONFLICT(Id)
                DO UPDATE SET Name = excluded.Name, Username = excluded.Username, Password = excluded.Password;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", model.Id);
            parameters.Add("@Name", model.Name);
            parameters.Add("@Username", model.Username.Encrypt());
            parameters.Add("@Password", model.Password.Encrypt());

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static List<PasswordModel> GetAll()
        {
            string query = @"SELECT Id, Name, Username, Password FROM Passwords";
            List<PasswordModel> results = AppHelper.DATA.LoadDataListOpen<PasswordModel>(query);

            foreach (PasswordModel item in results)
            {
                item.Username = item.Username.Decrypt();
                item.Password = item.Password.Decrypt();
            }

            return results;
        }

        public static void Delete(int id)
        {
            string query = "DELETE FROM Passwords WHERE Id = @Id;";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static void Import(List<PasswordModel> notesList)
        {
            string query = "DELETE FROM Passwords;";

            AppHelper.DATA.ExecuteScalarOpen(query);

            foreach (var note in notesList)
            {
                Save(note);
            }
        }
    }
}
