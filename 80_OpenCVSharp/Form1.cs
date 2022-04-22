using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;  // 이렇게 참조를 해주고


namespace _80_OpenCVSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Mat image = Cv2.ImRead(dlg.FileName);
                //OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
                
            }
        }
    }
}
