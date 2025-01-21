using Commands_Runner.Models;
using Commands_Runner.Properties;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cmp;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Commands_Runner.Helpers
{
    public static class AppHelper
    {
        public static CommandFilterModel CommandsFilters { get; set; }
        public static SqlDataAccess SQL { get; set; }
        public static SqlDataAccess DATA { get; set; }
        public static SettingModel Configs { get; set; }

        /// <summary>
        /// MainInstance of main form
        /// </summary>
        public static MainForm MainInstance { get; set; }

        /// <summary>
        /// Set status to main form
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void SetStatus(string text, Color color)
        {
            if (MainInstance == null)
                return;

            MainInstance.bsiStatus.ItemAppearance.Normal.ForeColor = color;
            MainInstance.bsiStatus.Caption = $"{DateTime.Now:HH:mm} - {text}";
        }

        public static string RemoveAllWhitespace(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        }

        public static bool SqlStart(string address = null, string username = null, string password = null)
        {
            try
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder
                {
                    UserID = username ?? Configs.SQLUsername,
                    Password = password ?? Configs.SQLPassword,
                    InitialCatalog = Configs.SQLDatabase,
                    DataSource = address ?? Configs.SQLAddress,
                    ConnectTimeout = 1,
                    PersistSecurityInfo = true,
                    IntegratedSecurity = false,
                    MultipleActiveResultSets = true,
                    AsynchronousProcessing = true
                };

                SQL = new SqlDataAccess(scsb.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SqlStausLabel()
        {
            bool ok = SQL != null && SQL.IsOpen();
            MainInstance.npPrimaveraExtensions.PageEnabled = ok;
            MainInstance.bsiSQLState.ImageOptions.SvgImage = ok ? Resources.actions_checkcircled : Resources.actions_deletecircled;
            return ok;
        }

        public static string SerializeToXml<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public static T DeserializeFromXml<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static void ErrorHandler(Exception ex)
        {
            XtraMessageBox.Show(ex.ToString(), ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UpdateView()
        {
            MainInstance.npPrimaveraExtensions.PageVisible = AppHelper.Configs.StatePriExtensions;
            MainInstance.npCommandsListView.PageVisible = AppHelper.Configs.StateCommands;
            MainInstance.npNoteView.PageVisible = AppHelper.Configs.StateNotes;
            MainInstance.npPasswordsListView.PageVisible = AppHelper.Configs.StatePasswords;
        }
    }
}
