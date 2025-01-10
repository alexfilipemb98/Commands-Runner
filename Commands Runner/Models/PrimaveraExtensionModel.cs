using Commands_Runner.Helpers;
using Dapper;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Models
{
    public class PrimaveraExtensionModel
    {
        public string ID { get; set; }
        public string FileName { get; set; }
        public string FileVersion { get; set; }
        public int ExecutionQueue { get; set; }
        public string HashCode { get; set; }
        public string Company { get; set; }
        public bool CommonExtension { get; set; }
        public bool IsActive { get; set; }
        public string AssemblyName { get; set; }
        public bool IsSystem { get; set; }

        public static List<PrimaveraExtensionModel> GetAll()
        {
            string query = @"
                SELECT ID,
                       FileName,
                       FileVersion,
                       ExecutionQueue,
                       HashCode,
                       Company,
                       CommonExtension,
                       IsActive,
                       AssemblyName,
                       IsSystem
                FROM PRIEMPRE.dbo.ExtensibilityConfiguration;
            ";

            return AppHelper.SQL.LoadDataListOpen<PrimaveraExtensionModel>(query);
        }

        public static bool Save(PrimaveraExtensionModel model)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM PRIEMPRE.dbo.ExtensibilityConfiguration WHERE ID = @ID)
                BEGIN
                    UPDATE PRIEMPRE.dbo.ExtensibilityConfiguration
                    SET FileName = @FileName,
                        FileVersion = @FileVersion,
                        ExecutionQueue = @ExecutionQueue,
                        HashCode = @HashCode,
                        Company = @Company,
                        CommonExtension = @CommonExtension,
                        IsActive = @IsActive,
                        AssemblyName = @AssemblyName,
                        IsSystem = @IsSystem
                    WHERE ID = @ID;
                END;
                ELSE
                BEGIN
                    INSERT INTO PRIEMPRE.dbo.ExtensibilityConfiguration
                    (
                        ID,
                        FileName,
                        FileVersion,
                        ExecutionQueue,
                        HashCode,
                        Company,
                        CommonExtension,
                        IsActive,
                        AssemblyName,
                        IsSystem
                    )
                    VALUES
                    (@ID, @FileName, @FileVersion, @ExecutionQueue, @HashCode, @Company, @CommonExtension, @IsActive, @AssemblyName,
                     @IsSystem);
                END;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", model.ID);
            parameters.Add("@FileName", model.FileName);
            parameters.Add("@FileVersion", model.FileVersion);
            parameters.Add("@ExecutionQueue", model.ExecutionQueue);
            parameters.Add("@HashCode", model.HashCode);
            parameters.Add("@Company", model.Company);
            parameters.Add("@CommonExtension", model.CommonExtension);
            parameters.Add("@IsActive", model.IsActive);
            parameters.Add("@AssemblyName", model.AssemblyName);
            parameters.Add("@IsSystem", model.IsSystem);

            return AppHelper.SQL.SaveDataOpen(query, ref parameters) > 0;
        }

        public static bool Delete(string id)
        {
            string query = @"
                DELETE FROM PRIEMPRE.dbo.ExtensibilityConfiguration
                WHERE ID = @ID;
            ";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", id);

            return AppHelper.SQL.SaveDataOpen(query, ref parameters) > 0;
        }
    }
}
