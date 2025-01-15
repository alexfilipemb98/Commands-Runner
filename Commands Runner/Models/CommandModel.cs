using Commands_Runner.Enums;
using Commands_Runner.Extensions;
using Commands_Runner.Models;
using Commands_Runner.Utils;
using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Commands_Runner.Models
{
    [XmlRoot("Commands")]
    public class RootCommandsModel
    {
        [XmlElement("Command")]
        public List<CommandModel> CommandList { get; set; }
    }

    public class CommandModel
    {
        [Key]
        [Required]
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("Position")]
        public int Position { get; set; }

        [Required]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("Description")]
        public string Description { get; set; }

        [Required]
        [XmlElement("Type")]
        public CommandTypeEnum Type { get; set; }

        [Required]
        [XmlElement("Command")]
        public string Command { get; set; }

        [XmlElement("Enabled")]
        public bool Enabled { get; set; }

        [XmlIgnore]
        [NotMapped]
        public SvgImage Icon { get; set; }
    }
}