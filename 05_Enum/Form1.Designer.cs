
namespace _05_Enum
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
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.tbnResult = new System.Windows.Forms.Button();
            this.tbnResultStringFormat = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(15, 20);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(111, 21);
            this.tboxName.TabIndex = 0;
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 12;
            this.lboxDay.Location = new System.Drawing.Point(18, 47);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(180, 220);
            this.lboxDay.TabIndex = 1;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 12;
            this.lboxTime.Location = new System.Drawing.Point(204, 47);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(180, 220);
            this.lboxTime.TabIndex = 1;
            // 
            // tbnResult
            // 
            this.tbnResult.Location = new System.Drawing.Point(24, 289);
            this.tbnResult.Name = "tbnResult";
            this.tbnResult.Size = new System.Drawing.Size(75, 30);
            this.tbnResult.TabIndex = 2;
            this.tbnResult.Text = "결과보기";
            this.tbnResult.UseVisualStyleBackColor = true;
            this.tbnResult.Click += new System.EventHandler(this.tbnResult_Click);
            // 
            // tbnResultStringFormat
            // 
            this.tbnResultStringFormat.Location = new System.Drawing.Point(123, 289);
            this.tbnResultStringFormat.Name = "tbnResultStringFormat";
            this.tbnResultStringFormat.Size = new System.Drawing.Size(165, 30);
            this.tbnResultStringFormat.TabIndex = 2;
            this.tbnResultStringFormat.Text = "String Format Test";
            this.tbnResultStringFormat.UseVisualStyleBackColor = true;
            this.tbnResultStringFormat.Click += new System.EventHandler(this.tbnResultStringFormat_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(26, 335);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(357, 123);
            this.tboxResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 481);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.tbnResultStringFormat);
            this.Controls.Add(this.tbnResult);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Controls.Add(this.tboxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.Button tbnResult;
        private System.Windows.Forms.Button tbnResultStringFormat;
        private System.Windows.Forms.TextBox tboxResult;
    }
}

