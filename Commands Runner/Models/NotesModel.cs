using Commands_Runner.Enums;
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
    public class NotesModel
    {
        public static string FilePath = "notes.xml";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public static int GetMaxId()
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            NotesModel commands = xmlDoc.Descendants("Note")
             .Select(cmd => new NotesModel
             {
                 Id = (int?)cmd.Element("Id") ?? 0
             })
             .OrderByDescending(cmd => cmd.Id)
             .FirstOrDefault() ?? new NotesModel();

            return commands.Id + 1;
        }

        public static List<NotesModel> Get()
        {
            FileUtil.ValidarXML(FilePath, "Notes");

            XDocument xmlDoc = XDocument.Load(FilePath);

            List<NotesModel> notes = xmlDoc.Descendants("Note")
                .Select(cmd => new NotesModel
                {
                    Id = (int?)cmd.Element(nameof(Id)) ?? 0,
                    Name = (string)cmd.Element(nameof(Name)) ?? string.Empty,
                    Text = ((string)cmd.Element(nameof(Text)) ?? string.Empty).Replace("&#xD;", "\r").Replace("&#xA;", "\n"),
                })
                .Where(w => w.Id > 0)
                .ToList();

            return notes ?? new List<NotesModel>();
        }

        public static void SaveToXml(NotesModel note)
        {
            XDocument xmlDoc = File.Exists(FilePath)
                ? XDocument.Load(FilePath)
                : new XDocument(new XElement("Notes"));

            XElement root = xmlDoc.Element("Notes");

            Dictionary<int, XElement> existingCommands = root.Elements("Note")
                .ToDictionary(e => (int)e.Element("Id"), e => e);

            XElement element;
            if (note.Id == 0 || !existingCommands.TryGetValue(note.Id, out element))
            {
                // Assign a new ID if creating a new command
                int newId = GetMaxId();
                element = new XElement("Note",
                    new XElement(nameof(Id), newId),
                    new XElement(nameof(Text), note.Text.Replace("\r", "&#xD;").Replace("\n", "&#xA;")),
                    new XElement(nameof(Name), note.Name)
                );
                root.Add(element);
            }
            else
            {
                element.SetElementValue(nameof(Name), note.Name);
                element.SetElementValue(nameof(Text), note.Text.Replace("\r", "&#xD;").Replace("\n", "&#xA;"));
            }

            xmlDoc.Save(FilePath);
        }

        public static void DeleteFromXml(int idToDelete)
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            XElement root = xmlDoc.Element("Notes");
            if (root == null)
                return;

            XElement element = root.Elements("Note")
                .FirstOrDefault(e => (int)e.Element("Id") == idToDelete);

            if (element != null)
            {
                element.Remove();
                xmlDoc.Save(FilePath);
            }
        }
    }
}
