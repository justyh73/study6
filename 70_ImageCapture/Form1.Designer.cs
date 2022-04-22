
namespace _70_ImageCapture
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
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(106, 443);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(121, 45);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "button1";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "button2";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pBoxImage
            // 
            this.pBoxImage.Location = new System.Drawing.Point(19, 15);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(488, 402);
            this.pBoxImage.TabIndex = 2;
            this.pBoxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 523);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBoxImage;
    }
}

