namespace Assembly_emulator
{
    partial class AssemblyEmulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputRTB = new System.Windows.Forms.RichTextBox();
            this.CommandInRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RunCode = new System.Windows.Forms.Button();
            this.CommandLogRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OutputRTB
            // 
            this.OutputRTB.Location = new System.Drawing.Point(604, 38);
            this.OutputRTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputRTB.Name = "OutputRTB";
            this.OutputRTB.Size = new System.Drawing.Size(212, 196);
            this.OutputRTB.TabIndex = 0;
            this.OutputRTB.Text = "";
            // 
            // CommandInRTB
            // 
            this.CommandInRTB.Location = new System.Drawing.Point(15, 38);
            this.CommandInRTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommandInRTB.Name = "CommandInRTB";
            this.CommandInRTB.Size = new System.Drawing.Size(212, 196);
            this.CommandInRTB.TabIndex = 1;
            this.CommandInRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // RunCode
            // 
            this.RunCode.Font = new System.Drawing.Font("Cascadia Mono", 11.25F);
            this.RunCode.Location = new System.Drawing.Point(15, 241);
            this.RunCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunCode.Name = "RunCode";
            this.RunCode.Size = new System.Drawing.Size(100, 31);
            this.RunCode.TabIndex = 4;
            this.RunCode.Text = "Run Code";
            this.RunCode.UseVisualStyleBackColor = true;
            this.RunCode.Click += new System.EventHandler(this.OutputCommandResults);
            // 
            // CommandLogRTB
            // 
            this.CommandLogRTB.Location = new System.Drawing.Point(604, 238);
            this.CommandLogRTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommandLogRTB.Name = "CommandLogRTB";
            this.CommandLogRTB.Size = new System.Drawing.Size(212, 196);
            this.CommandLogRTB.TabIndex = 5;
            this.CommandLogRTB.Text = "";
            // 
            // AssemblyEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 506);
            this.Controls.Add(this.CommandLogRTB);
            this.Controls.Add(this.RunCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandInRTB);
            this.Controls.Add(this.OutputRTB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AssemblyEmulator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputRTB;
        private System.Windows.Forms.RichTextBox CommandInRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunCode;
        private System.Windows.Forms.RichTextBox CommandLogRTB;
    }
}

