using Commands_Runner.Enums;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Commands_Runner.Data
{
    public static class CommandsData
    {
        public static void CheckTable()
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Commands (
                    Id INTEGER PRIMARY KEY NOT NULL,
                    Position INTEGER NOT NULL,
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Type INTEGER NOT NULL,
                    Command TEXT NOT NULL,
                    Enabled BOOLEAN NOT NULL
                );
            ";

            AppHelper.DATA.ExecuteScalarOpen(query);
        }

        public static int NextId()
        {
            string query = @"SELECT max(Id) as ID FROM Commands";
            int result = AppHelper.DATA.GetValueOpen<int?>(query) ?? 0;
            return result + 1;
        }

        public static void Save(CommandModel model)
        {
            model.Id = model.Id == 0 ? NextId() : model.Id;

            string query = @"
                INSERT INTO Commands (Id, Position, Name, Description, Type, Command, Enabled)
                VALUES (@Id, @Position, @Name, @Description, @Type, @Command, @Enabled)
                ON CONFLICT(Id)
                DO UPDATE SET
                    Position = excluded.Position,
                    Name = excluded.Name,
                    Description = excluded.Description,
                    Type = excluded.Type,
                    Command = excluded.Command,
                    Enabled = excluded.Enabled;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", model.Id);
            parameters.Add("@Name", model.Name);
            parameters.Add("@Description", model.Description);
            parameters.Add("@Type", model.Type);
            parameters.Add("@Command", model.Command.Replace("\r", "&#xD;").Replace("\n", "&#xA;"));
            parameters.Add("@Enabled", model.Enabled);
            parameters.Add("@Position", model.Position);

            if (AppHelper.DATA.IsInTransaction())
                AppHelper.DATA.SaveDataInTransaction(query, ref parameters);
            else
                AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static void SavePosition(CommandModel model)
        {
            string query = @"
                UPDATE Commands
                SET Position = @Position
                WHERE Id = @Id;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", model.Id);
            parameters.Add("@Position", model.Position);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static void SaveEnabled(CommandModel model)
        {
            string query = @"
                UPDATE Commands
                SET Enabled = @Enabled
                WHERE Id = @Id;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", model.Id);
            parameters.Add("@Enabled", model.Enabled);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static List<CommandModel> GetAll()
        {
            string query = @"SELECT Id, Position, Name, Description, Type, Command, Enabled FROM Commands";
            List<CommandModel> results = AppHelper.DATA.LoadDataListOpen<CommandModel>(query);

            foreach (CommandModel command in results)
            {
                command.Command = (command.Command ?? string.Empty).Replace("&#xD;", "\r").Replace("&#xA;", "\n");
            }

            return results;
        }

        public static List<CommandModel> GetByFilters(CommandFilterModel filters)
        {
            List<int> types = new List<int>();
            if (filters.ShowCMD)
                types.Add((int)CommandTypeEnum.CMD);
            if (filters.ShowPS1)
                types.Add((int)CommandTypeEnum.PS1);
            if (filters.ShowPY)
                types.Add((int)CommandTypeEnum.PY);

            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT Id, Position, Name, Description, Type, Command, Enabled FROM Commands WHERE 1=1");

            if (types.Count > 0)
            {
                string typesCondition = string.Join(",", types);
                query.AppendLine($"AND Type IN ({typesCondition})");
            }

            if (!filters.ShowDisabled)
                query.AppendLine("AND Enabled = 1");

            query.AppendLine("ORDER BY Position");

            List<CommandModel> results = AppHelper.DATA.LoadDataListOpen<CommandModel>(query.ToString()) ?? new List<CommandModel>();

            foreach (CommandModel command in results)
            {
                command.Command = (command.Command ?? string.Empty).Replace("&#xD;", "\r").Replace("&#xA;", "\n");
            }

            return results;
        }


        public static void Delete(int id)
        {
            string query = "DELETE FROM Commands WHERE Id = @Id;";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            AppHelper.DATA.ExecuteScalarOpen(query, ref parameters);
        }

        public static void Import(List<CommandModel> list)
        {
            try
            {
                AppHelper.DATA.StartTransactionOpen();

                string query = "DELETE FROM Commands;";

                AppHelper.DATA.ExecuteScalarOpen(query);

                foreach (CommandModel command in list)
                {
                    Save(command);
                }

                AppHelper.DATA.CommitTransaction();
            }
            finally
            {
                if (AppHelper.DATA.IsInTransaction())
                    AppHelper.DATA.RollbackTransaction();
            }
        }

        public static bool SaveCommandToFile(CommandTypeEnum type, string fileContent, string fileName)
        {
            string typeStr = type.ToString().ToUpper();

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = $"{typeStr} Files (*.{typeStr})|*.{typeStr}",
                DefaultExt = typeStr,
                Title = $"Save {typeStr} File",
                FileName = fileName
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Encoding utf8WithBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
                File.WriteAllText(saveFile.FileName, fileContent, utf8WithBom);
                return true;
            }

            return false;
        }
    }
}
