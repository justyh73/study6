
namespace _02_DataType
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
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(13, 10);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(312, 21);
            this.tboxNumber.TabIndex = 0;
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(343, 11);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(78, 19);
            this.btnExe.TabIndex = 1;
            this.btnExe.Text = "알아서 변환";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exception";
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(215, 46);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(75, 24);
            this.btnShort.TabIndex = 3;
            this.btnShort.Text = "Short 변환";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(215, 76);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(75, 21);
            this.btnInt.TabIndex = 3;
            this.btnInt.Text = "Int 변환";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(215, 103);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 24);
            this.btnDouble.TabIndex = 3;
            this.btnDouble.Text = "Double 변환";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(85, 58);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(11, 12);
            this.lblSort.TabIndex = 2;
            this.lblSort.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(85, 85);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(11, 12);
            this.lblInt.TabIndex = 2;
            this.lblInt.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(85, 115);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(11, 12);
            this.lblDouble.TabIndex = 2;
            this.lblDouble.Text = "0";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(85, 149);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(11, 12);
            this.lblException.TabIndex = 2;
            this.lblException.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 217);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.tboxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblException;
    }
}

