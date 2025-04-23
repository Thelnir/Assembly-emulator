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
        public void ExecuteADD(int var1, int var2, int var3)
        {
            if (var1 == 1)
                reg3 = reg1 + reg2;
            else if (var1 == 2)
                reg3 = reg2 + reg1;
            else
                reg3 = var1 + var2;
            outputRTB.AppendText($"ADD {var1} {var2} R3:{reg3}\n");
        }

        public void ExecuteSUB(int var1, int var2, int var3)
        {
            if (var1 == 1)
                this.reg3 = this.reg1 - var2;
            else if (var1 == 2)
                this.reg3 = this.reg2 - var2;
            else
                this.reg3 = var1 - var2;
            outputRTB.AppendText($"SUB {var1} {var2} R{reg3}\n");
        }

        public void ExecuteMUL(int var1, int var2, int var3)
        {
            if (var1 == 1)
                this.reg3 = this.reg1 * var2;
            else if (var1 == 2)
                this.reg3 = this.reg2 * var2;
            else
                this.reg3 = var1 * var2;
            outputRTB.AppendText($"MUL {var1} {var2} R{reg3}\n");
        }

        public void ExecuteDIV(int var1, int var2, int var3)
        {
            if (var1 == 1)
            {
                if (var2 != 0)
                    this.reg3 = this.reg1 / var2;
                else
                    throw new DivideByZeroException("Cannot divide by zero.");
            }
            else if (var1 == 2)
            {
                if (var2 != 0)
                    this.reg3 = this.reg2 / var2;
                else
                    throw new DivideByZeroException("Cannot divide by zero.");
            }
            else
            {
                if (var2 != 0)
                    this.reg3 = var1 / var2;
                else
                    throw new DivideByZeroException("Cannot divide by zero.");
            }
            outputRTB.AppendText($"DIV {var1} {var2} R{reg3}\n");
        }
        public void ExecuteMOV(int reg1, int reg2)
        {
            reg2 = reg1;
        }
        public void ExecuteTRP(int code)
        {
            switch (code)
            {

                case 1:
                    outputRTB.AppendText("End of program\n");
                    break;
                case 2:
                    outputRTB.AppendText("Input from user placed into R3\n");
                    break;
                case 3:
                    outputRTB.AppendText($"Output from R3: {reg3}\n");
                    break;
                default:
                    outputRTB.AppendText("Invalid TRP code\n");
                    break;
            }
        }
    }
}
