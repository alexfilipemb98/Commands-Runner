using Commands_Runner.Extensions;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Commands_Runner.Models
{
    [XmlRoot("Settings")]
    public class SettingModel
    {
        [Key]
        [Required]
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("SQLUsername")]
        public string SQLUsername { get; set; }

        [XmlElement("SQLPassword")]
        public string SQLPassword { get; set; }

        [XmlElement("SQLAddress")]
        public string SQLAddress { get; set; }

        [XmlElement("SQLDatabase")]
        public string SQLDatabase { get; set; }


        [XmlElement("CMDPath")]
        public string CMDPath { get; set; }

        [XmlElement("CMDArgs")]
        public string CMDArgs { get; set; }

        [XmlElement("CMDFileExt")]
        public string CMDFileExt { get; set; }


        [XmlElement("PS1Path")]
        public string PS1Path { get; set; }

        [XmlElement("PS1Args")]
        public string PS1Args { get; set; }

        [XmlElement("PS1FileExt")]
        public string PS1FileExt { get; set; }


        [XmlElement("PYPath")]
        public string PYPath { get; set; }

        [XmlElement("PYArgs")]
        public string PYArgs { get; set; }

        [XmlElement("PYFileExt")]
        public string PYFileExt { get; set; }


        [XmlElement("HTMIMGPath")]
        public string HTMIMGPath { get; set; }

        [XmlElement("HTMIMGArgs")]
        public string HTMIMGArgs { get; set; }

        [XmlElement("HTMIMGFileExt")]
        public string HTMIMGFileExt { get; set; }


        [XmlElement("FormWidth")]
        public int FormWidth { get; set; }

        [XmlElement("FormHeight")]
        public int FormHeight { get; set; }

        [XmlElement("FormState")]
        public FormWindowState FormState { get; set; }

        [XmlElement("StartUpPage")]
        public string StartUpPage { get; set; }

        [XmlElement("StateCommands")]
        public bool StateCommands { get; set; }
        
        [XmlElement("StatePasswords")]
        public bool StatePasswords { get; set; }
        
        [XmlElement("StateNotes")]
        public bool StateNotes { get; set; }

        [XmlElement("StatePriExtensions")]
        public bool StatePriExtensions { get; set; }
    }
}
