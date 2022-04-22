
namespace _03_Method
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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxInput1 = new System.Windows.Forms.TextBox();
            this.tboxInput2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnShiftL = new System.Windows.Forms.Button();
            this.btnShiftR = new System.Windows.Forms.Button();
            this.btnAmp = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.tboxReusltBit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(26, 11);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(283, 21);
            this.tboxResult.TabIndex = 0;
            // 
            // tboxInput1
            // 
            this.tboxInput1.Location = new System.Drawing.Point(26, 65);
            this.tboxInput1.Name = "tboxInput1";
            this.tboxInput1.Size = new System.Drawing.Size(132, 21);
            this.tboxInput1.TabIndex = 0;
            // 
            // tboxInput2
            // 
            this.tboxInput2.Location = new System.Drawing.Point(177, 65);
            this.tboxInput2.Name = "tboxInput2";
            this.tboxInput2.Size = new System.Drawing.Size(132, 21);
            this.tboxInput2.TabIndex = 0;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(44, 111);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 22);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(106, 111);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(56, 22);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(168, 111);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(56, 22);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(230, 111);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(56, 22);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnShiftL
            // 
            this.btnShiftL.Location = new System.Drawing.Point(44, 139);
            this.btnShiftL.Name = "btnShiftL";
            this.btnShiftL.Size = new System.Drawing.Size(56, 22);
            this.btnShiftL.TabIndex = 1;
            this.btnShiftL.Text = "<<";
            this.btnShiftL.UseVisualStyleBackColor = true;
            this.btnShiftL.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnShiftR
            // 
            this.btnShiftR.Location = new System.Drawing.Point(106, 139);
            this.btnShiftR.Name = "btnShiftR";
            this.btnShiftR.Size = new System.Drawing.Size(56, 22);
            this.btnShiftR.TabIndex = 1;
            this.btnShiftR.Text = ">>";
            this.btnShiftR.UseVisualStyleBackColor = true;
            this.btnShiftR.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAmp
            // 
            this.btnAmp.Location = new System.Drawing.Point(168, 139);
            this.btnAmp.Name = "btnAmp";
            this.btnAmp.Size = new System.Drawing.Size(56, 22);
            this.btnAmp.TabIndex = 1;
            this.btnAmp.Text = "&&";
            this.btnAmp.UseVisualStyleBackColor = true;
            this.btnAmp.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(230, 139);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(56, 22);
            this.Equals.TabIndex = 1;
            this.Equals.Text = "||";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // tboxReusltBit
            // 
            this.tboxReusltBit.Location = new System.Drawing.Point(26, 38);
            this.tboxReusltBit.Name = "tboxReusltBit";
            this.tboxReusltBit.Size = new System.Drawing.Size(283, 21);
            this.tboxReusltBit.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 192);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.btnAmp);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnShiftR);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnShiftL);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tboxInput2);
            this.Controls.Add(this.tboxInput1);
            this.Controls.Add(this.tboxReusltBit);
            this.Controls.Add(this.tboxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxInput1;
        private System.Windows.Forms.TextBox tboxInput2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnShiftL;
        private System.Windows.Forms.Button btnShiftR;
        private System.Windows.Forms.Button btnAmp;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.TextBox tboxReusltBit;
    }
}

