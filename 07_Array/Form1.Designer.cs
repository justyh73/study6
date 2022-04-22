
namespace _07_Array
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.btnOneWeek = new System.Windows.Forms.Button();
            this.btnTwoWeek = new System.Windows.Forms.Button();
            this.lblArracyCount = new System.Windows.Forms.Label();
            this.colDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "방문자 수";
            // 
            // dgvDay
            // 
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7});
            this.dgvDay.Location = new System.Drawing.Point(9, 23);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.RowTemplate.Height = 23;
            this.dgvDay.Size = new System.Drawing.Size(681, 193);
            this.dgvDay.TabIndex = 1;
            // 
            // btnOneWeek
            // 
            this.btnOneWeek.Location = new System.Drawing.Point(12, 222);
            this.btnOneWeek.Name = "btnOneWeek";
            this.btnOneWeek.Size = new System.Drawing.Size(97, 37);
            this.btnOneWeek.TabIndex = 2;
            this.btnOneWeek.Text = "1주일";
            this.btnOneWeek.UseVisualStyleBackColor = true;
            this.btnOneWeek.Click += new System.EventHandler(this.btnOneWeek_Click);
            // 
            // btnTwoWeek
            // 
            this.btnTwoWeek.Location = new System.Drawing.Point(115, 222);
            this.btnTwoWeek.Name = "btnTwoWeek";
            this.btnTwoWeek.Size = new System.Drawing.Size(97, 37);
            this.btnTwoWeek.TabIndex = 2;
            this.btnTwoWeek.Text = "2주일";
            this.btnTwoWeek.UseVisualStyleBackColor = true;
            this.btnTwoWeek.Click += new System.EventHandler(this.btnTwoWeek_Click);
            // 
            // lblArracyCount
            // 
            this.lblArracyCount.AutoSize = true;
            this.lblArracyCount.Location = new System.Drawing.Point(253, 231);
            this.lblArracyCount.Name = "lblArracyCount";
            this.lblArracyCount.Size = new System.Drawing.Size(91, 12);
            this.lblArracyCount.TabIndex = 3;
            this.lblArracyCount.Text = "전체 자료 수 : 0";
            // 
            // colDay1
            // 
            this.colDay1.HeaderText = "월";
            this.colDay1.Name = "colDay1";
            // 
            // colDay2
            // 
            this.colDay2.HeaderText = "화";
            this.colDay2.Name = "colDay2";
            // 
            // colDay3
            // 
            this.colDay3.HeaderText = "수";
            this.colDay3.Name = "colDay3";
            // 
            // colDay4
            // 
            this.colDay4.HeaderText = "목";
            this.colDay4.Name = "colDay4";
            // 
            // colDay5
            // 
            this.colDay5.HeaderText = "금";
            this.colDay5.Name = "colDay5";
            // 
            // colDay6
            // 
            this.colDay6.HeaderText = "토";
            this.colDay6.Name = "colDay6";
            // 
            // colDay7
            // 
            this.colDay7.HeaderText = "일";
            this.colDay7.Name = "colDay7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 285);
            this.Controls.Add(this.lblArracyCount);
            this.Controls.Add(this.btnTwoWeek);
            this.Controls.Add(this.btnOneWeek);
            this.Controls.Add(this.dgvDay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.Button btnOneWeek;
        private System.Windows.Forms.Button btnTwoWeek;
        private System.Windows.Forms.Label lblArracyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay7;
    }
}

