using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commands_Runner.Data
{
    public static class NotesData
    {
        public static void CheckTable()
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Notes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Text TEXT NOT NULL
                );
            ";

            AppHelper.DATA.ExecuteScalarOpen(query);
        }

        public static int NextId()
        {
            string query = @"SELECT max(Id) as ID FROM Notes";
            return AppHelper.DATA.GetValueOpen<int>(query) + 1;
        }

        public static void Save(NoteModel model)
        {
            model.Id = model.Id == 0 ? NextId() : model.Id;

            string query = @"
                INSERT INTO Notes (Id, Name, Text)
                VALUES (@Id, @Name, @Text)
                ON CONFLICT(Id) 
                DO UPDATE SET Name = excluded.Name, Text = excluded.Text;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", model.Id);
            parameters.Add("@Name", model.Name);
            parameters.Add("@Text", model.Text);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static List<NoteModel> GetAll()
        {
            string query = @"SELECT Id, Name, Text FROM Notes";
            List<NoteModel> results = AppHelper.DATA.LoadDataListOpen<NoteModel>(query);
            return results;
        }

        public static void Delete(int id)
        {
            string query = "DELETE FROM Notes WHERE Id = @Id;";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static void Import(List<NoteModel> notesList)
        {
            string query = "DELETE FROM Notes;";

            AppHelper.DATA.ExecuteScalarOpen(query);

            foreach (var note in notesList)
            {
                Save(note);
            }
        }
    }
}
