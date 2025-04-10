using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembly_emulator
{
    public class ExecuteCommand
    {
        public Registers registers { get; private set; }

        public ExecuteCommand(RichTextBox outputRTB)
        {
            registers = new Registers(outputRTB);
        }

        public void CommandExecute(string command, int var1, int var2, int var3)
        {
            if (command == "LD")
            {
                registers.ExecuteLD(var1, var2);
            }
            else if (command == "ADD")
            {
                registers.ExecuteADD(var1, var2, var3);
            }
            else if (command == "SUB")
            {
                registers.ExecuteSUB(var1, var2, var3);
            }
            else if (command == "MUL")
            {
                registers.ExecuteMUL(var1, var2, var3);
            }
            else if (command == "DIV")
            {
                registers.ExecuteDIV(var1, var2, var3);
            }
            else if (command == "TRP")
            {
                registers.ExecuteTRP(var1);
            }
        }
    }
}
