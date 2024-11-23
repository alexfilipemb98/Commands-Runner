using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Commands_Runner.Utils
{
	public static class FileUtil
	{
		public static void ValidarXML(string filePath, string element)
		{
			if (!File.Exists(filePath))
			{
				using (XmlWriter writer = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = true }))
				{
					writer.WriteStartDocument();
					writer.WriteStartElement(element);
					writer.WriteEndElement();
					writer.WriteEndDocument();
				}
			}
		}
	}
}
