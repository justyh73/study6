using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tboxNumber.Text);

                lblSort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tboxNumber.Text);

                lblInt.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch(Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNumber = double.Parse(tboxNumber.Text);

                lblDouble.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = 0;
                int iNumber = 0;
                double dNumber = 0;

                lblException.Text = "-";

                if (short.TryParse(tboxNumber.Text, out sNumber))
                {
                    lblSort.Text = sNumber.ToString();
                }
                else if (int.TryParse(tboxNumber.Text, out iNumber))  // 위의 If에서 Int로 변환이 불가능 할경우 이줄에서 Int로 변환 가능 한지 확인 하고 변환 가능 할 경우
                {
                    lblInt.Text = iNumber.ToString();   // Int 형태로 변환 합니다. 
                }
                else if (double.TryParse(tboxNumber.Text, out dNumber))  // 위에서 Short, Int로도 변환이 불가능 할 경우 Double로 변환 가능한지 확인 하고 변환 가능 할 경우
                {
                    lblDouble.Text = dNumber.ToString();  // Double 형태로 변환 합니다.
                }
                else
                {
                    lblException.Text = "변환 할수 없음";  // Short, Int, Double 형태로 변환이 불가능 할 경우 "변환 할수 없음"으로 표시 합니다.
                }

            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }
    }
}
