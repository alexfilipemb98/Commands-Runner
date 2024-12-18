using Commands_Runner.Enums;
using Commands_Runner.Extensions;
using Commands_Runner.Models;
using Commands_Runner.Utils;
using DevExpress.Utils.Svg;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Commands_Runner.Models
{

	public class CommandsModel
	{
		public static string FilePath = "commands.xml";

		public int Id { get; set; }
		public int Position { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public CommandTypeEnum Type { get; set; }
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
			 .FirstOrDefault() ?? new CommandsModel { Id = 1 };

			return commands.Id;
		}

		public static List<CommandsModel> Get(CommandFilterModel filters)
		{
			FileUtil.ValidarXML(FilePath, "Commands");

			XDocument xmlDoc = XDocument.Load(FilePath);

			List<CommandTypeEnum> types = new List<CommandTypeEnum>();

			if (filters.ShowCMD) types.Add(CommandTypeEnum.CMD);
			if (filters.ShowPS1) types.Add(CommandTypeEnum.PS1);
			if (filters.ShowPY) types.Add(CommandTypeEnum.PY);

			List<CommandsModel> commands = xmlDoc.Descendants("Command")
				.Select(cmd => new CommandsModel
				{
					Id = (int?)cmd.Element("Id") ?? 0, // Default to 0 if null
					Position = (int?)cmd.Element("Position") ?? 0,
					Name = (string)cmd.Element("Name") ?? string.Empty, // Default to empty string if null
					Description = (string)cmd.Element("Description") ?? string.Empty,
					Type = EnumExtension.GetEnumByName<CommandTypeEnum>((string)cmd.Element("Type") ?? string.Empty, true),
					Command = ((string)cmd.Element("Command") ?? string.Empty).Replace("&#xD;", "\r").Replace("&#xA;", "\n"),
					Enabled = (bool?)cmd.Element("Enabled") ?? false
				})
				.Where(w => w.Id > 0 && (!filters.ShowDisabled ? w.Enabled : (w.Enabled || !w.Enabled)) && types.Contains(w.Type))
				.OrderBy(o => o.Position)
				.ToList();

			return commands ?? new List<CommandsModel>();
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
					new XElement("Position", cmd.Position),
					new XElement("Name", cmd.Name),
					new XElement("Description", cmd.Description),
					new XElement("Type", cmd.Type),
					new XElement("Enabled", cmd.Enabled),
					new XElement("Command", cmd.Command.Replace("\r", "&#xD;").Replace("\n", "&#xA;"))
				);
				root.Add(commandElement);
			}
			else
			{
				// Update existing command
				commandElement.SetElementValue("Name", cmd.Name);
				commandElement.SetElementValue("Position", cmd.Position);
				commandElement.SetElementValue("Description", cmd.Description);
				commandElement.SetElementValue("Type", cmd.Type.ToString().ToUpper());
				commandElement.SetElementValue("Enabled", cmd.Enabled);
				commandElement.SetElementValue("Command", cmd.Command.Replace("\r", "&#xD;").Replace("\n", "&#xA;"));
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

		public static void UpdatePositionPropertyInXml(CommandsModel cmd)
		{
			XDocument xmlDoc = XDocument.Load(FilePath);
			XElement root = xmlDoc.Element("Commands");

			if (root == null)
				return;

			XElement commandElement = root.Elements("Command")
				.FirstOrDefault(e => (int?)e.Element("Id") == cmd.Id);

			if (commandElement != null)
			{
				XElement enabledElement = commandElement.Element("Position");
				if (enabledElement == null)
				{
					enabledElement = new XElement("Position", cmd.Position);
					commandElement.Add(enabledElement);
				}
				else
					enabledElement.Value = cmd.Position.ToString();

				xmlDoc.Save(FilePath);
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