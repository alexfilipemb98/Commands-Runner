using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Commands_Runner.Models
{
    public class ConnectionSQLModel
    {
        public static string FilePath = "connection.xml";

        public string UserID { get; set; }
        public string Password { get; set; }
        public string InitialCatalog { get; set; }
        public string DataSource { get; set; }

        public static ConnectionSQLModel ReadFile(out bool ok)
        {
            if (!File.Exists(FilePath))
                CreateFile();

            XmlDocument doc = new XmlDocument();
            doc.Load(FilePath);

            XmlNode rootNode = doc.SelectSingleNode("/ConnectionDetails");
            ConnectionSQLModel model = null;
            
            if (rootNode != null)
            {
                model = new ConnectionSQLModel();
                model.UserID = rootNode["UserID"]?.InnerText;
                model.Password = rootNode["Password"]?.InnerText ;
                model.InitialCatalog = rootNode["InitialCatalog"]?.InnerText;
                model.DataSource = rootNode["DataSource"]?.InnerText;
            }

            ok = model != null 
                && !string.IsNullOrWhiteSpace(model.UserID)
                && !string.IsNullOrWhiteSpace(model.Password)
                && !string.IsNullOrWhiteSpace(model.InitialCatalog)
                && !string.IsNullOrWhiteSpace(model.DataSource);

            return model;
        }

        public static void CreateFile()
        {
            using (XmlWriter writer = XmlWriter.Create(FilePath, new XmlWriterSettings { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ConnectionDetails");

                writer.WriteElementString("UserID", "");
                writer.WriteElementString("Password", "");
                writer.WriteElementString("InitialCatalog", "");
                writer.WriteElementString("DataSource", "");

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
