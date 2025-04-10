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
        public AssemblyEmulator()
        {
            InitializeComponent();
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
            //Note: Forms elements DO NOT work outside of the parent forms' classes.
            OutputRTB.Text = ("Register 1 = " + registers.reg1);
            OutputRTB.Text += ("\nRegister 2 = " + registers.reg2);
            OutputRTB.Text += ("\nRegister 3 = " + registers.reg3);

        }

    }
}
