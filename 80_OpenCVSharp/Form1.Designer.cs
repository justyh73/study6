
namespace _80_OpenCVSharp
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
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(9, 16);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(485, 383);
            this.pboxImage.TabIndex = 0;
            this.pboxImage.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(518, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(179, 76);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 411);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pboxImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.Button btnLoad;
    }
}

