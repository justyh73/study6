
namespace _92_MLSentimental
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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxPercent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(97, 18);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(482, 23);
            this.tboxInput.TabIndex = 0;
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(97, 47);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(161, 23);
            this.tboxResult.TabIndex = 0;
            // 
            // tboxPercent
            // 
            this.tboxPercent.Location = new System.Drawing.Point(264, 47);
            this.tboxPercent.Name = "tboxPercent";
            this.tboxPercent.Size = new System.Drawing.Size(145, 23);
            this.tboxPercent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "입력값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "결과";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "%";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(599, 18);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 111);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPercent);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.tboxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
    }
}

