using DevExpress.Utils.Svg;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Commands_Runner
{

    public class CommandsModel
    {
        public static string FilePath = "commands.xml";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Command { get; set; }
        public bool Enabled { get; set; }
        public SvgImage Icon { get; set; }

        public static int GetMaxId()
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            CommandsModel commands = xmlDoc.Descendants("Command")
             .Select(cmd => new CommandsModel
             {
                 Id = (int?)cmd.Element("Id") ?? 0
             })
             .OrderByDescending(cmd => cmd.Id)
             .FirstOrDefault();

            return commands.Id;
        }

        public static List<CommandsModel> Get()
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            List<CommandsModel> commands = xmlDoc.Descendants("Command")
                .Select(cmd => new CommandsModel
                {
                    Id = (int?)cmd.Element("Id") ?? 0, // Default to 0 if null
                    Name = (string)cmd.Element("Name") ?? string.Empty, // Default to empty string if null
                    Description = (string)cmd.Element("Description") ?? string.Empty,
                    Type = (string)cmd.Element("Type") ?? string.Empty,
                    Command = ((string)cmd.Element("Command") ?? string.Empty).Replace("&#xD;", "\r").Replace("&#xA;", "\n"),
                    Enabled = (bool?)cmd.Element("Enabled") ?? false
                })
                .Where(w => w.Id > 0)
                .ToList();

            return commands;
        }

        public static void SaveToXml(CommandsModel cmd)
        {
            XDocument xmlDoc = File.Exists(FilePath)
                ? XDocument.Load(FilePath)
                : new XDocument(new XElement("Commands"));

            XElement root = xmlDoc.Element("Commands");

            Dictionary<int, XElement> existingCommands = root.Elements("Command")
                .ToDictionary(e => (int)e.Element("Id"), e => e);

            XElement commandElement;
            if (cmd.Id == 0 || !existingCommands.TryGetValue(cmd.Id, out commandElement))
            {
                // Assign a new ID if creating a new command
                int newId = GetMaxId() + 1;
                commandElement = new XElement("Command",
                    new XElement("Id", newId),
                    new XElement("Name", cmd.Name),
                    new XElement("Description", cmd.Description),
                    new XElement("Type", cmd.Type),
                    new XElement("Enabled", cmd.Enabled),
                    new XElement("Command",cmd.Command.Replace("\r", "&#xD;").Replace("\n", "&#xA;")) 
                );
                root.Add(commandElement);
            }
            else
            {
                // Update existing command
                commandElement.SetElementValue("Name", cmd.Name);
                commandElement.SetElementValue("Description", cmd.Description);
                commandElement.SetElementValue("Type", cmd.Type);
                commandElement.SetElementValue("Enabled", cmd.Enabled);
                commandElement.SetElementValue("Command",cmd.Command.Replace("\r", "&#xD;").Replace("\n", "&#xA;"));
            }

            // Save changes back to the XML file
            xmlDoc.Save(FilePath);
        }

        public static void DeleteFromXml(int idToDelete)
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            XElement root = xmlDoc.Element("Commands");
            if (root == null)
                return;

            XElement commandElement = root.Elements("Command")
                .FirstOrDefault(e => (int)e.Element("Id") == idToDelete);

            if (commandElement != null)
            {
                commandElement.Remove();
                xmlDoc.Save(FilePath);
            }
        }

        public static void UpdateEnabledPropertyInXml(CommandsModel cmd)
        {
            XDocument xmlDoc = XDocument.Load(FilePath);
            XElement root = xmlDoc.Element("Commands");

            if (root == null)
                return;

            XElement commandElement = root.Elements("Command")
                .FirstOrDefault(e => (int?)e.Element("Id") == cmd.Id);

            if (commandElement != null)
            {
                XElement enabledElement = commandElement.Element("Enabled");
                if (enabledElement == null)
                {
                    enabledElement = new XElement("Enabled", cmd.Enabled);
                    commandElement.Add(enabledElement);
                }
                else
                    enabledElement.Value = cmd.Enabled.ToString();

                xmlDoc.Save(FilePath);
            }
        }
    }
}