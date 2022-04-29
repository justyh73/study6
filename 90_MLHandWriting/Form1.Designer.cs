
namespace _90_MLHandWriting
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
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.lb_no = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pb_small = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_small)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_img
            // 
            this.pb_img.Location = new System.Drawing.Point(12, 12);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(200, 200);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            this.pb_img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_img_MouseDown);
            this.pb_img.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_img_MouseMove);
            this.pb_img.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_img_MouseUp);
            // 
            // lb_no
            // 
            this.lb_no.Location = new System.Drawing.Point(362, 259);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(50, 24);
            this.lb_no.TabIndex = 1;
            this.lb_no.Text = "X";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(362, 286);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "인식";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pb_small
            // 
            this.pb_small.Location = new System.Drawing.Point(237, 12);
            this.pb_small.Name = "pb_small";
            this.pb_small.Size = new System.Drawing.Size(200, 200);
            this.pb_small.TabIndex = 3;
            this.pb_small.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 321);
            this.Controls.Add(this.pb_small);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lb_no);
            this.Controls.Add(this.pb_img);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_small)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Label lb_no;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox pb_small;
    }
}

