using Commands_Runner.Extensions;
using Commands_Runner.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commands_Runner.Models
{
    public class PasswordsModel
    {
        public static string FilePath = "passwords.xml";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static int GetMaxId()
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            PasswordsModel passwords = xmlDoc.Descendants("Password")
             .Select(s => new PasswordsModel
             {
                 Id = (int?)s.Element("Id") ?? 0
             })
             .OrderByDescending(w => w.Id)
             .FirstOrDefault() ?? new PasswordsModel { Id = 1 };

            return passwords.Id;
        }

        public static List<PasswordsModel> Get()
        {
            FileUtil.ValidarXML(FilePath, "Passwords");

            XDocument xmlDoc = XDocument.Load(FilePath);

            List<PasswordsModel> passwords = xmlDoc.Descendants("Password")
                .Select(s => new PasswordsModel
                {
                    Id = (int?)s.Element("Id") ?? 0,
                    Name = (string)s.Element("Name") ?? string.Empty,
                    Username = ((string)s.Element("Username") ?? string.Empty)?.Decrypt(),
                    Password = ((string)s.Element("Password") ?? string.Empty)?.Decrypt()
                })
                .Where(w => w.Id > 0)
                .ToList();

            return passwords ?? new List<PasswordsModel>();
        }

        public static void SaveToXml(PasswordsModel password)
        {
            XDocument xmlDoc = File.Exists(FilePath)
                ? XDocument.Load(FilePath)
                : new XDocument(new XElement("Passwords"));

            XElement root = xmlDoc.Element("Passwords");

            Dictionary<int, XElement> existingPasswords = root.Elements("Password")
                .ToDictionary(e => (int)e.Element("Id"), e => e);

            XElement passwordElement;
            if (password.Id == 0 || !existingPasswords.TryGetValue(password.Id, out passwordElement))
            {
                int newId = GetMaxId() + 1;
                passwordElement = new XElement("Password",
                    new XElement("Id", newId),
                    new XElement("Name", password.Name),
                    new XElement("Username", password.Username?.Encrypt()),
                    new XElement("Password", password.Password?.Encrypt())
                );
                root.Add(passwordElement);
                password.Id = newId;
            }
            else
            {
                passwordElement.SetElementValue("Name", password.Name);
                passwordElement.SetElementValue("Username", password.Username?.Encrypt());
                passwordElement.SetElementValue("Password", password.Password?.Encrypt());
            }

            xmlDoc.Save(FilePath);
        }

        public static void DeleteFromXml(int idToDelete)
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            XElement root = xmlDoc.Element("Passwords");
            if (root == null)
                return;

            XElement commandElement = root.Elements("Password")
                .FirstOrDefault(e => (int)e.Element("Id") == idToDelete);

            if (commandElement != null)
            {
                commandElement.Remove();
                xmlDoc.Save(FilePath);
            }
        }

    }
}
