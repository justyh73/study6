
namespace _81_TesseractOCR
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
            this.btnKorea = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(10, 14);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(445, 260);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImage.TabIndex = 0;
            this.pboxImage.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(107, 391);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 43);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnKorea
            // 
            this.btnKorea.Location = new System.Drawing.Point(217, 391);
            this.btnKorea.Name = "btnKorea";
            this.btnKorea.Size = new System.Drawing.Size(104, 43);
            this.btnKorea.TabIndex = 1;
            this.btnKorea.Text = "한글";
            this.btnKorea.UseVisualStyleBackColor = true;
            this.btnKorea.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(327, 391);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(104, 43);
            this.btnEng.TabIndex = 1;
            this.btnEng.Text = "영어";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(9, 292);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(445, 79);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 446);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnKorea);
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
        private System.Windows.Forms.Button btnKorea;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.Label lblResult;
    }
}

