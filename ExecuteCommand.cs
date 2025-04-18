using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembly_emulator
{
    public class ExecuteCommand //test
    {
        public Registers registers { get; private set; }

        public ExecuteCommand(RichTextBox outputRTB)
        {
            registers = new Registers(outputRTB);
        }

        public void CommandExecute(string command, int var1, int var2, int var3)
        {
            switch (command) //Josh: Touched up code using a switch/case instead of if/else if/else
            {
                case "LD":
                    registers.ExecuteLD(var1, var2);
                    break;

                case "ADD":
                    registers.ExecuteADD(var1, var2, var3);
                    break;

                case "SUB":
                    registers.ExecuteSUB(var1, var2, var3);
                    break;

                case "MUL":
                    registers.ExecuteMUL(var1, var2, var3);
                    break;

                case "DIV":
                    registers.ExecuteDIV(var1, var2, var3);
                    break;

                case "MOV":
                    registers.ExecuteMOV(var1, var2);
                    break;

                case "TRP":
                    registers.ExecuteTRP(var1);
                    break;

                default:
                        MessageBox.Show("Invalid command");
                        break; 

            }
            /*
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
            /**/
        }
    }
}
