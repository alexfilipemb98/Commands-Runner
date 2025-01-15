using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Commands_Runner.Models
{
    [XmlRoot("Notes")]
    public class RootNotesModel
    {
        [XmlElement("Note")]
        public List<NoteModel> NoteList { get; set; }
    }

    public class NoteModel
    {
        [Key]
        [Required]
        [XmlElement("Id")]
        public int Id { get; set; }

        [Required]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("Text")]
        public string Text { get; set; }
    }
}
