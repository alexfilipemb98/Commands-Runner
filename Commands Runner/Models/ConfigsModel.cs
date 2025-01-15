using Commands_Runner.Extensions;
using Commands_Runner.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

public class ConfigsModel
{
    public static string FilePath = "configs.xml";

    public string SQLUsername { get; set; }
    public string SQLPassword { get; set; }
    public string SQLAddress { get; set; }
    public string SQLDatabase { get; set; }

    public string CMDPath { get; set; }
    public string CMDArgs { get; set; }
    public string CMDFileExt { get; set; }

    public string PS1Path { get; set; }
    public string PS1Args { get; set; }
    public string PS1FileExt { get; set; }

    public string PYPath { get; set; }
    public string PYArgs { get; set; }
    public string PYFileExt { get; set; }

    public string HTMIMGPath { get; set; }
    public string HTMIMGArgs { get; set; }
    public string HTMIMGFileExt { get; set; }

    public int FormWidth { get; set; }
    public int FormHeight { get; set; }
    public FormWindowState FormState { get; set; }
    public string StartUpPage { get; set; }


    public static ConfigsModel ReadFile(out bool ok)
    {
        if (!File.Exists(FilePath))
        {
            SaveToFile(new ConfigsModel());
        }

        var xml = XDocument.Load(FilePath);

        var general = xml.Root?.Element("General");
        var connection = xml.Root?.Element("Connection");
        var programs = xml.Root?.Element("Programs");

        var model = new ConfigsModel
        {
            SQLUsername = connection?.Element(nameof(SQLUsername))?.Value?.Decrypt(),
            SQLPassword = connection?.Element(nameof(SQLPassword))?.Value?.Decrypt(),
            SQLAddress = connection?.Element(nameof(SQLAddress))?.Value?.Decrypt(),
            SQLDatabase = connection?.Element(nameof(SQLDatabase))?.Value?.Decrypt(),

            CMDPath = programs?.Element(nameof(CMDPath))?.Value,
            CMDArgs = programs?.Element(nameof(CMDArgs))?.Value,
            CMDFileExt = programs?.Element(nameof(CMDFileExt))?.Value,

            PS1Path = programs?.Element(nameof(PS1Path))?.Value,
            PS1Args = programs?.Element(nameof(PS1Args))?.Value,
            PS1FileExt = programs?.Element(nameof(PS1FileExt))?.Value,

            PYPath = programs?.Element(nameof(PYPath))?.Value,
            PYArgs = programs?.Element(nameof(PYArgs))?.Value,
            PYFileExt = programs?.Element(nameof(PYFileExt))?.Value,

            HTMIMGPath = programs?.Element(nameof(HTMIMGPath))?.Value,
            HTMIMGArgs = programs?.Element(nameof(HTMIMGArgs))?.Value,
            HTMIMGFileExt = programs?.Element(nameof(HTMIMGFileExt))?.Value,

            FormWidth = int.Parse(general?.Element(nameof(FormWidth))?.Value ?? "1000"),
            FormHeight = int.Parse(general?.Element(nameof(FormHeight))?.Value ?? "530"),
            FormState = (FormWindowState)int.Parse(general?.Element(nameof(FormState))?.Value ?? ((int)FormWindowState.Normal).ToString()),
            StartUpPage = general?.Element(nameof(StartUpPage))?.Value,
        };

        ok = model.SQLUsername != null && model.SQLPassword != null &&
             model.SQLAddress != null && model.SQLDatabase != null;

        return model;
    }

    public static void SaveToFile(ConfigsModel model)
    {
        using (XmlWriter writer = XmlWriter.Create(FilePath, new XmlWriterSettings { Indent = true }))
        {
            writer.WriteStartDocument();

            writer.WriteStartElement("Root");

            writer.WriteStartElement("General");
            writer.WriteElementString(nameof(FormHeight), model.FormHeight.ToString() ?? string.Empty);
            writer.WriteElementString(nameof(FormWidth), model.FormWidth.ToString() ?? string.Empty);
            writer.WriteElementString(nameof(FormState), ((int)model.FormState).ToString() ?? string.Empty);
            writer.WriteElementString(nameof(StartUpPage), model.StartUpPage ?? string.Empty);
            writer.WriteEndElement();

            writer.WriteStartElement("Connection");
            writer.WriteElementString(nameof(SQLUsername), model.SQLUsername.Encrypt() ?? string.Empty);
            writer.WriteElementString(nameof(SQLPassword), model.SQLPassword.Encrypt() ?? string.Empty);
            writer.WriteElementString(nameof(SQLAddress), model.SQLAddress.Encrypt() ?? string.Empty);
            writer.WriteElementString(nameof(SQLDatabase), model.SQLDatabase.Encrypt() ?? string.Empty);
            writer.WriteEndElement();

            writer.WriteStartElement("Programs");
            writer.WriteElementString(nameof(CMDPath), model.CMDPath ?? string.Empty);
            writer.WriteElementString(nameof(CMDArgs), model.CMDArgs ?? string.Empty);
            writer.WriteElementString(nameof(CMDFileExt), model.CMDFileExt ?? string.Empty);

            writer.WriteElementString(nameof(PS1Path), model.PS1Path ?? string.Empty);
            writer.WriteElementString(nameof(PS1Args), model.PS1Args ?? string.Empty);
            writer.WriteElementString(nameof(PS1FileExt), model.PS1FileExt ?? string.Empty);

            writer.WriteElementString(nameof(PYPath), model.PYPath ?? string.Empty);
            writer.WriteElementString(nameof(PYArgs), model.PYArgs ?? string.Empty);
            writer.WriteElementString(nameof(PYFileExt), model.PYFileExt ?? string.Empty);

            writer.WriteElementString(nameof(HTMIMGPath), model.HTMIMGPath ?? string.Empty);
            writer.WriteElementString(nameof(HTMIMGArgs), model.HTMIMGArgs ?? string.Empty);
            writer.WriteElementString(nameof(HTMIMGFileExt), model.HTMIMGFileExt ?? string.Empty);

            writer.WriteEndElement();

            writer.WriteEndElement(); // Fecha o nó raiz
            writer.WriteEndDocument();
        }
    }

    public static void UpdateGeneralSettings(int formHeight, int formWidth, FormWindowState windowState)
    {
        XDocument xmlDoc = File.Exists(FilePath)
            ? XDocument.Load(FilePath)
            : new XDocument(new XElement("Root"));

        XElement root = xmlDoc.Element("Root");
        if (root == null)
            return;

        XElement generalElement = root.Element("General");
        if (generalElement == null)
        {
            generalElement = new XElement("General");
            root.Add(generalElement);
        }

        generalElement.SetElementValue(nameof(FormHeight), formHeight);
        generalElement.SetElementValue(nameof(FormWidth), formWidth);
        generalElement.SetElementValue(nameof(FormState), ((int)windowState).ToString());

        xmlDoc.Save(FilePath);
    }
}
