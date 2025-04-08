namespace Assembly_emulator
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // OutputRTB
            // 
            this.OutputRTB.Location = new System.Drawing.Point(453, 31);
            this.OutputRTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputRTB.Name = "OutputRTB";
            this.OutputRTB.Size = new System.Drawing.Size(160, 160);
            this.OutputRTB.TabIndex = 0;
            this.OutputRTB.Text = "";
            // 
            // CommandInRTB
            // 
            this.CommandInRTB.Location = new System.Drawing.Point(11, 35);
            this.CommandInRTB.Margin = new System.Windows.Forms.Padding(2);
            this.CommandInRTB.Name = "CommandInRTB";
            this.CommandInRTB.Size = new System.Drawing.Size(160, 160);
            this.CommandInRTB.TabIndex = 1;
            this.CommandInRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // RunCode
            // 
            this.RunCode.Font = new System.Drawing.Font("Cascadia Mono", 11.25F);
            this.RunCode.Location = new System.Drawing.Point(11, 200);
            this.RunCode.Name = "RunCode";
            this.RunCode.Size = new System.Drawing.Size(75, 25);
            this.RunCode.TabIndex = 4;
            this.RunCode.Text = "Run Code";
            this.RunCode.UseVisualStyleBackColor = true;
            this.RunCode.Click += new System.EventHandler(this.RunCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.RunCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandInRTB);
            this.Controls.Add(this.OutputRTB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
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
    }
}

