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
            int result = AppHelper.DATA.GetValueOpen<int?>(query) ?? 0;
            return result + 1;
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

            if (AppHelper.DATA.IsInTransaction())
                AppHelper.DATA.SaveDataInTransaction(query, ref parameters);
            else
                AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static List<NoteModel> GetAll()
        {
            string query = @"SELECT Id, Name, Text FROM Notes";
            List<NoteModel> results = AppHelper.DATA.LoadDataListOpen<NoteModel>(query) ?? new List<NoteModel>();
            return results;
        }

        public static void Delete(int id)
        {
            string query = "DELETE FROM Notes WHERE Id = @Id;";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static void Import(List<NoteModel> list)
        {
            try
            {
                AppHelper.DATA.StartTransactionOpen();

                string query = "DELETE FROM Notes;";

                AppHelper.DATA.ExecuteScalarOpen(query);

                foreach (NoteModel note in list)
                {
                    Save(note);
                }

                AppHelper.DATA.CommitTransaction();
            }
            finally
            {
                if (AppHelper.DATA.IsInTransaction())
                    AppHelper.DATA.RollbackTransaction();
            }
        }
    }
}
