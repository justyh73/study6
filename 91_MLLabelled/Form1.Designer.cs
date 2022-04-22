
namespace _91_MLLabelled
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.tboxOutput = new System.Windows.Forms.TextBox();
            this.tboxPredict = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(75, 16);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(339, 23);
            this.tboxInput.TabIndex = 0;
            // 
            // tboxOutput
            // 
            this.tboxOutput.Location = new System.Drawing.Point(75, 55);
            this.tboxOutput.Name = "tboxOutput";
            this.tboxOutput.Size = new System.Drawing.Size(156, 23);
            this.tboxOutput.TabIndex = 0;
            // 
            // tboxPredict
            // 
            this.tboxPredict.Location = new System.Drawing.Point(258, 55);
            this.tboxPredict.Name = "tboxPredict";
            this.tboxPredict.Size = new System.Drawing.Size(256, 23);
            this.tboxPredict.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "입력값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "결과";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(430, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 24);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 107);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPredict);
            this.Controls.Add(this.tboxOutput);
            this.Controls.Add(this.tboxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.TextBox tboxOutput;
        private System.Windows.Forms.TextBox tboxPredict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
    }
}

