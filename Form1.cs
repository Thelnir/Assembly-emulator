using System;
using System.Windows.Forms;

/*
Joshua Whitmore
Getahun Endalamaw
Kaleb Hilla
*/

namespace Assembly_emulator
{
    public partial class AssemblyEmulator : Form
    {
        private ExecuteCommand executecommand;

        public AssemblyEmulator()
        {
            InitializeComponent();
            executecommand = new ExecuteCommand(OutputRTB);
        }
        Registers registers = new Registers();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            PrintRegs();//Prints default register values to output, added by Josh
        }

        private void OutputCommandResults(object sender, System.EventArgs e)
        {
            CommandLogRTB.Text += ("\n" + CommandInRTB.Text);//Josh

            PrintRegs();//Josh
        }

        public void PrintRegs()//Josh
        {
            var userInput = CommandInRTB.Text;
            ParseCommands(userInput);
        }
        private void ParseCommands(string input)
        {
            try
            {
                var lines = input.Split('\n');
                foreach (var line in lines)
                {
                    var parts = line.Split(' ');
                    var command = parts[0];
                    var var1 = int.Parse(parts[1]);
                    var var2 = int.Parse(parts[2].Substring(1));
                    var var3 = parts.Length > 3 ? int.Parse(parts[3].Substring(1)) : 0;

                }
                ExecuteCommands();
            }
            catch
            {
                MessageBox.Show("Did not work. Please try again.");
            }
        }
        
        private void ExecuteCommands()
        {
            // if you are doing the list please replace UserCommand with the list name
            foreach (var command in UserCommand)
            {
                executecommand.CommandExecute(command, var1, var2, var3);
            }
            OutputRTB.AppendText($"R1: {executecommand.Registers.reg1}\nR2: {executecommand.Registers.reg2}\nR3: {executecommand.Registers.reg3}\n");
            //Note: Forms elements DO NOT work outside of the parent forms' classes.
            OutputRTB.Text = ("Register 1 = " + registers.reg1);
            OutputRTB.Text += ("\nRegister 2 = " + registers.reg2);
            OutputRTB.Text += ("\nRegister 3 = " + registers.reg3);

        }

    }
}
