using Commands_Runner.Models;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Helpers
{
    public static class AppHelper
    {
        public static CommandFilterModel CommandsFilters { get; set; }
        public static SqlDataAccess SQL { get; set; }
        
        /// <summary>
        /// Instance of main form
        /// </summary>
        public static MainForm Instance { get; set; }

        /// <summary>
        /// Set status to main form
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void SetStatus(string text, Color color)
        {
            Instance.bsiStatus.ItemAppearance.Normal.Reset();
            Instance.bsiStatus.Caption = text;
        }

        public static string RemoveAllWhitespace(this string input)
		{
			if (string.IsNullOrEmpty(input))
				return input;

			return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
		}
    }
}
