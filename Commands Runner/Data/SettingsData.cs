using Commands_Runner.Extensions;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Dapper;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.EntityFramework.Extensions;

namespace Commands_Runner.Data
{
    public static class SettingsData
    {
        private static string[] columns = new[]
        {
            "Id" ,
            "SQLUsername" ,
            "SQLPassword" ,
            "SQLAddress" ,
            "SQLDatabase" ,
            "CMDPath" ,
            "CMDArgs" ,
            "CMDFileExt",
            "PS1Path",
            "PS1Args",
            "PS1FileExt",
            "PYPath",
            "PYArgs",
            "PYFileExt",
            "HTMIMGPath",
            "HTMIMGArgs",
            "HTMIMGFileExt",
            "FormWidth",
            "FormHeight",
            "FormState",
            "StatePasswords",
            "StateNotes",
            "StatePriExtensions",
            "StateCommands",
            "StartUpPage",
        };

        public static void CheckTable()
        {
            string query = @"
               CREATE TABLE IF NOT EXISTS Settings (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT
                );
            ";

            AppHelper.DATA.ExecuteScalarOpen(query);

            string[] requiredColumns = new[]
            {
                "SQLUsername TEXT",
                "SQLPassword TEXT",
                "SQLAddress TEXT",
                "SQLDatabase TEXT",
                "CMDPath TEXT",
                "CMDArgs TEXT",
                "CMDFileExt TEXT",
                "PS1Path TEXT",
                "PS1Args TEXT",
                "PS1FileExt TEXT",
                "PYPath TEXT",
                "PYArgs TEXT",
                "PYFileExt TEXT",
                "HTMIMGPath TEXT",
                "HTMIMGArgs TEXT",
                "HTMIMGFileExt TEXT",
                "FormWidth INTEGER NOT NULL",
                "FormHeight INTEGER NOT NULL",
                "FormState INTEGER NOT NULL",
                "StateCommands INTEGER DEFAULT 1",
                "StatePasswords INTEGER DEFAULT 1",
                "StateNotes INTEGER DEFAULT 1",
                "StatePriExtensions INTEGER DEFAULT 1",
                "StartUpPage TEXT"
            };

            List<string> existingColumns = AppHelper.DATA.LoadDataListOpen<string>("SELECT name FROM pragma_table_info('Settings');");
            foreach (var columnDefinition in requiredColumns)
            {
                string columnName = columnDefinition.Split(' ')[0];
                if (!existingColumns.Contains(columnName))
                {
                    string alterTableQuery = $"ALTER TABLE Settings ADD COLUMN {columnDefinition};";
                    AppHelper.DATA.ExecuteScalarOpen(alterTableQuery);
                }
            }

        }

        public static int NextId()
        {
            string query = @"SELECT max(Id) as ID FROM Settings";
            int result = AppHelper.DATA.GetValueOpen<int?>(query) ?? 0;
            return result + 1;
        }

        public static void Save(SettingModel model)
        {
            model.Id = model.Id == 0 ? NextId() : model.Id;

            string columnsList = string.Join(", ", columns);
            string valuesPlaceholders = string.Join(", ", columns.Select(c => $"@{c}"));
            string updateSet = string.Join(", ", columns.Select(c => $"{c} = excluded.{c}"));
            string query = $@"
                INSERT INTO Settings ({columnsList})
                VALUES ({valuesPlaceholders})
                ON CONFLICT(Id)                                                           
                DO UPDATE SET                                                           
                    {updateSet};
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", model.Id);

            parameters.Add("@SQLUsername", model.SQLUsername.Encrypt());
            parameters.Add("@SQLPassword", model.SQLPassword.Encrypt());
            parameters.Add("@SQLAddress", model.SQLAddress.Encrypt());
            parameters.Add("@SQLDatabase", model.SQLDatabase.Encrypt());

            parameters.Add("@CMDPath", model.CMDPath);
            parameters.Add("@CMDArgs", model.CMDArgs);
            parameters.Add("@CMDFileExt", model.CMDFileExt);

            parameters.Add("@PS1Path", model.PS1Path);
            parameters.Add("@PS1Args", model.PS1Args);
            parameters.Add("@PS1FileExt", model.PS1FileExt);

            parameters.Add("@PYPath", model.PYPath);
            parameters.Add("@PYArgs", model.PYArgs);
            parameters.Add("@PYFileExt", model.PYFileExt);

            parameters.Add("@HTMIMGPath", model.HTMIMGPath);
            parameters.Add("@HTMIMGArgs", model.HTMIMGArgs);
            parameters.Add("@HTMIMGFileExt", model.HTMIMGFileExt);

            parameters.Add("@FormWidth", model.FormWidth);
            parameters.Add("@FormHeight", model.FormHeight);
            parameters.Add("@FormState", model.FormState);

            parameters.Add("@StatePasswords", model.StatePasswords);
            parameters.Add("@StateNotes", model.StateNotes);
            parameters.Add("@StatePriExtensions", model.StatePriExtensions);
            parameters.Add("@StateCommands", model.StateCommands);

            parameters.Add("@StartUpPage", model.StartUpPage);

            if (AppHelper.DATA.IsInTransaction())
                AppHelper.DATA.SaveDataInTransaction(query, ref parameters);
            else
                AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static SettingModel GetByID(int id, out bool ok)
        {
            string query = @"
                SELECT 
                    Id, 
                    SQLUsername, 
                    SQLPassword, 
                    SQLAddress, 
                    SQLDatabase, 
                    CMDPath, 
                    CMDArgs, 
                    CMDFileExt,
                    PS1Path,
                    PS1Args,
                    PS1FileExt,
                    PYPath,
                    PYArgs,
                    PYFileExt,
                    HTMIMGPath,
                    HTMIMGArgs,
                    HTMIMGFileExt,
                    FormWidth,
                    FormHeight,
                    FormState,
                    StatePasswords,
                    StateNotes,
                    StatePriExtensions,
                    StateCommands,
                    StartUpPage
                FROM Settings";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            SettingModel results = AppHelper.DATA.GetValueOpen<SettingModel, DynamicParameters>(query, parameters) ?? new SettingModel();

            results.SQLUsername = results.SQLUsername.Decrypt();
            results.SQLAddress = results.SQLAddress.Decrypt();
            results.SQLDatabase = results.SQLDatabase.Decrypt();
            results.SQLPassword = results.SQLPassword.Decrypt();

            ok = results.SQLUsername != null && results.SQLPassword != null &&
                 results.SQLAddress != null && results.SQLDatabase != null;

            return results;
        }

        public static void ImportToId(SettingModel model, int id)
        {
            model.Id = id;

            model.SQLUsername = model.SQLUsername.Decrypt();
            model.SQLAddress = model.SQLAddress.Decrypt();
            model.SQLDatabase = model.SQLDatabase.Decrypt();
            model.SQLPassword = model.SQLPassword.Decrypt();

            Save(model);
        }

        public static void UpdateGeneralSettings(int id, int height, int width, FormWindowState windowState)
        {
            string query = @"
                UPDATE Settings
                SET FormWidth = @FormWidth,
                    FormHeight = @FormHeight,
                    FormState = @FormState                
                WHERE Id = @Id;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            parameters.Add("@FormWidth", width);
            parameters.Add("@FormHeight", height);
            parameters.Add("@FormState", windowState);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }
    }
}
