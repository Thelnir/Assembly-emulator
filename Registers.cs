using System;
using System.Windows.Forms;

namespace Assembly_emulator
{
    public class Registers
    {
        public int reg1 = 0;
        public int reg2 = 0;
        public int reg3 = 0;
        private RichTextBox outputRTB;
        public Registers(RichTextBox outputRTB)
        {
            reg1 = 0;
            reg2 = 0;
            reg3 = 0;
            this.outputRTB = outputRTB;
        }
        public void ExecuteLD(int value, int register)
        {
            if (register == 1)
                reg1 = value;
            else if (register == 2)
                reg2 = value;
            else if (register == 3)
                reg3 = value;
            outputRTB.AppendText($"LD {value} R{register}\n");

        }
        public void ExecuteADD(int reg1, int reg2, int reg3)
        {
            this.reg3 = this.reg1 + this.reg2;
        }

        public void ExecuteSUB(int reg1, int reg2, int reg3)
        {
            this.reg3 = this.reg1 - this.reg2;
        }

        public void ExecuteMUL(int reg1, int reg2, int reg3)
        {
            this.reg3 = this.reg1 * this.reg2;
        }

        public void ExecuteDIV(int reg1, int reg2, int reg3)
        {
            if (this.reg2 != 0)
            {
                this.reg3 = this.reg1 / this.reg2;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }
        public void ExecuteMOV(int reg1, int reg2)
        {
            reg2 = reg1;
        }
        public void ExecuteTRP(int code)
        {
            if (code == 3)
            {
                outputRTB.AppendText($"R3: {this.reg3}\n");
            }
        }

    }
}
