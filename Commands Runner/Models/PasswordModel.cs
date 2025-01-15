using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Commands_Runner.Models
{
    [XmlRoot("Passwords")]
    public class RootPasswordsModel
    {
        [XmlElement("Password")]
        public List<PasswordModel> PasswordList { get; set; }
    }

    public class PasswordModel
    {
        [Key]
        [Required]
        [XmlElement("Id")]
        public int Id { get; set; }

        [Required]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("Username")]
        public string Username { get; set; }

        [Required]
        [XmlElement("Password")]
        public string Password { get; set; }
    }
}
