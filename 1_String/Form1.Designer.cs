
namespace _1_String
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIn1 = new System.Windows.Forms.Label();
            this.lblIn2 = new System.Windows.Forms.Label();
            this.lblIn3 = new System.Windows.Forms.Label();
            this.lblIn4 = new System.Windows.Forms.Label();
            this.lblIn5 = new System.Windows.Forms.Label();
            this.lblIn6 = new System.Windows.Forms.Label();
            this.lblIn7 = new System.Windows.Forms.Label();
            this.lblIn8 = new System.Windows.Forms.Label();
            this.lblIn9 = new System.Windows.Forms.Label();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lblOut3 = new System.Windows.Forms.Label();
            this.lblOut4 = new System.Windows.Forms.Label();
            this.lblOut5 = new System.Windows.Forms.Label();
            this.lblOut6 = new System.Windows.Forms.Label();
            this.lblOut7 = new System.Windows.Forms.Label();
            this.lblOut8 = new System.Windows.Forms.Label();
            this.lblOut9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(28, 10);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(106, 12);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Sample,Test,Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIn1
            // 
            this.lblIn1.AutoSize = true;
            this.lblIn1.Location = new System.Drawing.Point(28, 38);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(52, 12);
            this.lblIn1.TabIndex = 0;
            this.lblIn1.Text = "Contain:";
            // 
            // lblIn2
            // 
            this.lblIn2.AutoSize = true;
            this.lblIn2.Location = new System.Drawing.Point(28, 61);
            this.lblIn2.Name = "lblIn2";
            this.lblIn2.Size = new System.Drawing.Size(48, 12);
            this.lblIn2.TabIndex = 0;
            this.lblIn2.Text = "Equals:";
            // 
            // lblIn3
            // 
            this.lblIn3.AutoSize = true;
            this.lblIn3.Location = new System.Drawing.Point(28, 84);
            this.lblIn3.Name = "lblIn3";
            this.lblIn3.Size = new System.Drawing.Size(47, 12);
            this.lblIn3.TabIndex = 0;
            this.lblIn3.Text = "Length:";
            // 
            // lblIn4
            // 
            this.lblIn4.AutoSize = true;
            this.lblIn4.Location = new System.Drawing.Point(28, 108);
            this.lblIn4.Name = "lblIn4";
            this.lblIn4.Size = new System.Drawing.Size(55, 12);
            this.lblIn4.TabIndex = 0;
            this.lblIn4.Text = "Replace:";
            // 
            // lblIn5
            // 
            this.lblIn5.AutoSize = true;
            this.lblIn5.Location = new System.Drawing.Point(28, 131);
            this.lblIn5.Name = "lblIn5";
            this.lblIn5.Size = new System.Drawing.Size(33, 12);
            this.lblIn5.TabIndex = 0;
            this.lblIn5.Text = "Split:";
            // 
            // lblIn6
            // 
            this.lblIn6.AutoSize = true;
            this.lblIn6.Location = new System.Drawing.Point(28, 161);
            this.lblIn6.Name = "lblIn6";
            this.lblIn6.Size = new System.Drawing.Size(62, 12);
            this.lblIn6.TabIndex = 0;
            this.lblIn6.Text = "Substring:";
            // 
            // lblIn7
            // 
            this.lblIn7.AutoSize = true;
            this.lblIn7.Location = new System.Drawing.Point(28, 193);
            this.lblIn7.Name = "lblIn7";
            this.lblIn7.Size = new System.Drawing.Size(59, 12);
            this.lblIn7.TabIndex = 0;
            this.lblIn7.Text = "ToLower:";
            // 
            // lblIn8
            // 
            this.lblIn8.AutoSize = true;
            this.lblIn8.Location = new System.Drawing.Point(28, 221);
            this.lblIn8.Name = "lblIn8";
            this.lblIn8.Size = new System.Drawing.Size(53, 12);
            this.lblIn8.TabIndex = 0;
            this.lblIn8.Text = "ToUpper";
            // 
            // lblIn9
            // 
            this.lblIn9.AutoSize = true;
            this.lblIn9.Location = new System.Drawing.Point(28, 246);
            this.lblIn9.Name = "lblIn9";
            this.lblIn9.Size = new System.Drawing.Size(31, 12);
            this.lblIn9.TabIndex = 0;
            this.lblIn9.Text = "Trim";
            // 
            // lblOut1
            // 
            this.lblOut1.AutoSize = true;
            this.lblOut1.Location = new System.Drawing.Point(94, 38);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(11, 12);
            this.lblOut1.TabIndex = 0;
            this.lblOut1.Text = "-";
            // 
            // lblOut2
            // 
            this.lblOut2.AutoSize = true;
            this.lblOut2.Location = new System.Drawing.Point(94, 61);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(11, 12);
            this.lblOut2.TabIndex = 0;
            this.lblOut2.Text = "-";
            // 
            // lblOut3
            // 
            this.lblOut3.AutoSize = true;
            this.lblOut3.Location = new System.Drawing.Point(94, 84);
            this.lblOut3.Name = "lblOut3";
            this.lblOut3.Size = new System.Drawing.Size(11, 12);
            this.lblOut3.TabIndex = 0;
            this.lblOut3.Text = "-";
            // 
            // lblOut4
            // 
            this.lblOut4.AutoSize = true;
            this.lblOut4.Location = new System.Drawing.Point(94, 108);
            this.lblOut4.Name = "lblOut4";
            this.lblOut4.Size = new System.Drawing.Size(11, 12);
            this.lblOut4.TabIndex = 0;
            this.lblOut4.Text = "-";
            // 
            // lblOut5
            // 
            this.lblOut5.AutoSize = true;
            this.lblOut5.Location = new System.Drawing.Point(94, 131);
            this.lblOut5.Name = "lblOut5";
            this.lblOut5.Size = new System.Drawing.Size(11, 12);
            this.lblOut5.TabIndex = 0;
            this.lblOut5.Text = "-";
            // 
            // lblOut6
            // 
            this.lblOut6.AutoSize = true;
            this.lblOut6.Location = new System.Drawing.Point(94, 161);
            this.lblOut6.Name = "lblOut6";
            this.lblOut6.Size = new System.Drawing.Size(11, 12);
            this.lblOut6.TabIndex = 0;
            this.lblOut6.Text = "-";
            // 
            // lblOut7
            // 
            this.lblOut7.AutoSize = true;
            this.lblOut7.Location = new System.Drawing.Point(94, 193);
            this.lblOut7.Name = "lblOut7";
            this.lblOut7.Size = new System.Drawing.Size(11, 12);
            this.lblOut7.TabIndex = 0;
            this.lblOut7.Text = "-";
            // 
            // lblOut8
            // 
            this.lblOut8.AutoSize = true;
            this.lblOut8.Location = new System.Drawing.Point(94, 221);
            this.lblOut8.Name = "lblOut8";
            this.lblOut8.Size = new System.Drawing.Size(11, 12);
            this.lblOut8.TabIndex = 0;
            this.lblOut8.Text = "-";
            // 
            // lblOut9
            // 
            this.lblOut9.AutoSize = true;
            this.lblOut9.Location = new System.Drawing.Point(94, 246);
            this.lblOut9.Name = "lblOut9";
            this.lblOut9.Size = new System.Drawing.Size(11, 12);
            this.lblOut9.TabIndex = 0;
            this.lblOut9.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOut9);
            this.Controls.Add(this.lblIn9);
            this.Controls.Add(this.lblOut8);
            this.Controls.Add(this.lblIn8);
            this.Controls.Add(this.lblOut7);
            this.Controls.Add(this.lblIn7);
            this.Controls.Add(this.lblOut6);
            this.Controls.Add(this.lblIn6);
            this.Controls.Add(this.lblOut5);
            this.Controls.Add(this.lblOut4);
            this.Controls.Add(this.lblIn5);
            this.Controls.Add(this.lblOut3);
            this.Controls.Add(this.lblIn4);
            this.Controls.Add(this.lblOut2);
            this.Controls.Add(this.lblIn3);
            this.Controls.Add(this.lblOut1);
            this.Controls.Add(this.lblIn2);
            this.Controls.Add(this.lblIn1);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIn1;
        private System.Windows.Forms.Label lblIn2;
        private System.Windows.Forms.Label lblIn3;
        private System.Windows.Forms.Label lblIn4;
        private System.Windows.Forms.Label lblIn5;
        private System.Windows.Forms.Label lblIn6;
        private System.Windows.Forms.Label lblIn7;
        private System.Windows.Forms.Label lblIn8;
        private System.Windows.Forms.Label lblIn9;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lblOut3;
        private System.Windows.Forms.Label lblOut4;
        private System.Windows.Forms.Label lblOut5;
        private System.Windows.Forms.Label lblOut6;
        private System.Windows.Forms.Label lblOut7;
        private System.Windows.Forms.Label lblOut8;
        private System.Windows.Forms.Label lblOut9;
    }
}

