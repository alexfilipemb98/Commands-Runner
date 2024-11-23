using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Models
{
	public class CommandFilterModel
	{
        public bool ShowDisabled { get; set; }
        public bool ShowCMD { get; set; }
        public bool ShowPS1 { get; set; }
        public bool ShowPY { get; set; }
    }
}
