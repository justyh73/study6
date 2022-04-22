using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iInput1, iInput2, iResult;            
            iInput1 = int.Parse(tboxInput1.Text);
            iInput2 = int.Parse(tboxInput2.Text);
            iResult = subPlus(iInput1, iInput2);
            tboxResult.Text = iResult.ToString();
            tboxReusltBit.Text = "0x" + Convert.ToString(int.Parse(tboxResult.Text), 2);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iInput1, iInput2, iResult;
            iInput1 = int.Parse(tboxInput1.Text);
            iInput2 = int.Parse(tboxInput2.Text);
            iResult = subMinus(iInput1, iInput2);
            tboxResult.Text = iResult.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iInput1, iInput2, iResult;
            iInput1 = int.Parse(tboxInput1.Text);
            iInput2 = int.Parse(tboxInput2.Text);
            iResult = subMulti(iInput1, iInput2);
            tboxResult.Text = iResult.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iInput1, iInput2, iResult;
            iInput1 = int.Parse(tboxInput1.Text);
            iInput2 = int.Parse(tboxInput2.Text);
            iResult = subDivision(iInput1, iInput2);
            tboxResult.Text = iResult.ToString();
        }

        public int subPlus(int iInput1, int iInput2)
        {
            int iResult;
            iResult = iInput1 + iInput2;
            return iResult;
        }

        public int subMinus(int iInput1, int iInput2)
        {
            int iResult;
            iResult = iInput1 - iInput2;
            return iResult;
        }

        public int subMulti(int iInput1, int iInput2)
        {
            int iResult;
            iResult = iInput1 * iInput2;
            return iResult;
        }

        public int subDivision(int iInput1, int iInput2)
        {
            int iResult;
            iResult = iInput1 / iInput2;
            return iResult;
        }
    }
}
