using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace _81_TesseractOCR
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
                pboxImage.Image = new Bitmap(dlg.FileName);
            }
        }
        
        private void btnKor_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pboxImage.Image);
            var ocr = new TesseractEngine("../../tessdata", "kor", EngineMode.Default);
            var texts = ocr.Process(img);
            //MessageBox.Show(texts.GetText());
            lblResult.Text = texts.GetText();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pboxImage.Image);
            var ocr = new TesseractEngine("../../tessdata", "eng", EngineMode.TesseractAndLstm);
            var texts = ocr.Process(img);
            //MessageBox.Show(texts.GetText());
            lblResult.Text = texts.GetText();
        }
    }
}
