
namespace _72_ExamXML
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
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.lboxXml = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(12, 266);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(99, 39);
            this.btnXmlWrite.TabIndex = 0;
            this.btnXmlWrite.Text = "XML 쓰기";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(130, 266);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(104, 39);
            this.btnReadXml.TabIndex = 2;
            this.btnReadXml.Text = "XML 읽기";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // lboxXml
            // 
            this.lboxXml.FormattingEnabled = true;
            this.lboxXml.ItemHeight = 12;
            this.lboxXml.Location = new System.Drawing.Point(17, 21);
            this.lboxXml.Name = "lboxXml";
            this.lboxXml.Size = new System.Drawing.Size(410, 220);
            this.lboxXml.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 335);
            this.Controls.Add(this.lboxXml);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnXmlWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnReadXml;
        private System.Windows.Forms.ListBox lboxXml;
    }
}

