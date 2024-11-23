using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Enums
{
    public enum CommandTypeEnum
    {
        [Description("Command Prompt")]
        CMD,
        [Description("PowerShell")]
        PS1,
        [Description("Python")]
        PY
    }
}
