﻿using Commands_Runner.Models;
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
            if (Instance == null)
                return;

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
    }
}
