using System.Collections.Generic;
using System.IO;
﻿using System.Windows.Forms;
using System.Xml;

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
        private List<string> UserCommand;//kaleb

        public AssemblyEmulator()
        {
            InitializeComponent();
            executecommand = new ExecuteCommand(OutputRTB);
            Registers registers = new Registers(OutputRTB);
            UserCommand = new List<string>();//kaleb
        }
        Registers registers;


        private void Form1_Load(object sender, System.EventArgs e)
        {
            PrintRegs();//Prints default register values to output, added by Josh
        }

        private void OutputCommandResults(object sender, System.EventArgs e)
        {
            CommandLogRTB2.Text += ("\n" + CommandInRTB.Text);//Josh
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
                    string command = parts[0];
                    string parsedCommand = "";

                    switch (command)
                    {
                        case "LD":
                        case "STR":
                        case "JMP":
                        case "JMPZ":
                        case "JMPN":
                        case "JMPP":
                        case "ADD":
                        case "SUB":
                        case "MUL":
                        case "DIV":
                        case "TRP":
                            parsedCommand = string.Join(" ", parts);
                            break;
                        default:
                            MessageBox.Show("Invalid command.");
                            continue;
                    }
                    UserCommand.Add(parsedCommand);

                    if (parts.Length == 3)
                    {
                        int var1 = parts[1].StartsWith("R") ? int.Parse(parts[1].Substring(1)) : int.Parse(parts[1]);
                        int var2 = parts[2].StartsWith("R") ? int.Parse(parts[2].Substring(1)) : int.Parse(parts[2]);
                        executecommand.CommandExecute(command, var1, var2, 0);
                }
                    else if (parts.Length == 4)
                    {
                        int var1 = parts[1].StartsWith("R") ? int.Parse(parts[1].Substring(1)) : int.Parse(parts[1]);
                        int var2 = parts[2].StartsWith("R") ? int.Parse(parts[2].Substring(1)) : int.Parse(parts[2]);
                        int var3 = parts[3].StartsWith("R") ? int.Parse(parts[3].Substring(1)) : int.Parse(parts[3]);
                        executecommand.CommandExecute(command, var1, var2, var3);
            }
                }
            }
            catch
            {
                MessageBox.Show("Did not work. Please try again.");
            }
        }

        private void OutputRegs(object sender, System.EventArgs e)
        {
            /*OutputRTB.Text = ("Register 1 = " + registers.reg1);
            OutputRTB.Text += ("\nRegister 2 = " + registers.reg2);
            OutputRTB.Text += ("\nRegister 3 = " + registers.reg3);*/

        }


        
        private void ExecuteCommands()
        {
            OutputRTB.Clear();

            foreach (string command in UserCommand)
            {
                var parts = command.Split(' ');
                string cmd = parts[0];
                int var1 = int.Parse(parts[1].Substring(1));
                int var2 = int.Parse(parts[2].Substring(1));
                int var3 = parts.Length > 3 ? int.Parse(parts[3].Substring(1)) : 0;

                executecommand.CommandExecute(cmd, var1, var2, var3);
                OutputRTB.AppendText(command + "\n");
            }
            OutputRTB.AppendText($"R1: {executecommand.registers.reg1}\nR2: {executecommand.registers.reg2}\nR3: {executecommand.registers.reg3}\n");
        }

        private void sAVEToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode CommandsNode = xmlDoc.CreateElement("COMMANDS");

            foreach (var entry in UserCommand)
            {
                XmlNode entryNode = xmlDoc.CreateElement("ENTRY");
                entryNode.InnerText = entry;
                CommandsNode.AppendChild(entryNode);
            }
            xmlDoc.AppendChild(CommandsNode);

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter("COMMANDS.xml");
                xmlDoc.Save(writer);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            this.Close();
        }

        private void oPENToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("COMMANDS.xml");

            XmlNodeList commandNodes = xmlDoc.SelectNodes("/COMMANDS/ENTRY");

            foreach (XmlNode node in commandNodes)
            {
                UserCommand.Add(node.InnerText);
            }


            CommandLogRTB2.Clear();
            foreach (var command in UserCommand)
            {
                CommandLogRTB2.AppendText(command + "\n");
            }

        }
    }
}

