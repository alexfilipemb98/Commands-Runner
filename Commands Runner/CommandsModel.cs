using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public static void SaveToXml(CommandsModel cmd)
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            // Load existing commands from the XML
            XElement root = xmlDoc.Element("Commands");
            if (root == null)
            {
                root = new XElement("Commands");
                xmlDoc.Add(root);
            }

            // Create a dictionary of existing commands by Id for quick lookup
            var existingCommands = root.Elements("Command")
                .ToDictionary(e => (int)e.Element("Id"), e => e);


            XElement commandElement;
            if (cmd.Id == 0 || !existingCommands.TryGetValue(cmd.Id, out commandElement))
            {
                // Create a new command element
                commandElement = new XElement("Command",
                    new XElement("Id", GetMaxId() + 1),
                    new XElement("Name", cmd.Name),
                    new XElement("Description", cmd.Description),
                    new XElement("Type", cmd.Type),
                    new XElement("Command", cmd.Command)
                );
                root.Add(commandElement);
            }
            else
            {
                // Update existing command element
                commandElement.SetElementValue("Name", cmd.Name);
                commandElement.SetElementValue("Description", cmd.Description);
                commandElement.SetElementValue("Type", cmd.Type);
                commandElement.SetElementValue("Command", cmd.Command);
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

        public static List<CommandsModel> Get()
        {
            XDocument xmlDoc = XDocument.Load(FilePath);

            List<CommandsModel> commands = xmlDoc.Descendants("Command")
                .Select(cmd => new CommandsModel
                {
                    // Use null-conditional operators and safe casting to handle missing elements
                    Id = (int?)cmd.Element("Id") ?? 0,  // Default to 0 if null
                    Name = (string)cmd.Element("Name") ?? string.Empty,  // Default to empty string if null
                    Description = (string)cmd.Element("Description") ?? string.Empty,
                    Type = (string)cmd.Element("Type") ?? string.Empty,
                    Command = (string)cmd.Element("Command") ?? string.Empty
                })
                .Where(w => w.Id > 0)
                .ToList();

            return commands;
        }

    }
}