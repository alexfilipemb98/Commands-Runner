using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cmp;
using DevExpress.XtraLayout.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Helpers
{
    public static class AppHelper
    {
        public static CommandFilterModel CommandsFilters { get; set; }
        public static SqlDataAccess SQL { get; set; }
        public static ConfigsModel Configs { get; set; }

        /// <summary>
        /// Instance of main form
        /// </summary>
        public static MainForm Instance { get; set; }

        /// <summary>
        /// Set status to main form
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void SetStatus(string text, Color color)
        {
            Instance.bsiStatus.ItemAppearance.Normal.ForeColor = color;
            Instance.bsiStatus.Caption = $"{DateTime.Now:HH:mm} - {text}";
        }

        public static string RemoveAllWhitespace(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        }

        public static void SqlStart()
        {
            try
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder
                {
                    UserID = Configs.SQLUsername,
                    Password = Configs.SQLPassword,
                    InitialCatalog = Configs.SQLDatabase,
                    DataSource = Configs.SQLAddress,
                    ConnectTimeout = 1,
                    PersistSecurityInfo = true,
                    IntegratedSecurity = false,
                    MultipleActiveResultSets = true,
                    AsynchronousProcessing = true
                };

                SQL = new SqlDataAccess(scsb.ToString());
            }
            catch (Exception)
            {
            }
        }

        public static bool SqlStausLabel()
        {
            bool ok = SQL != null && SQL.IsOpen();
            Instance.npPrimaveraExtensions.PageEnabled = ok;
            Instance.bsiSQLState.ImageOptions.SvgImage = ok ? Resources.actions_checkcircled : Resources.actions_deletecircled;
            return ok;
        }
    }
}
