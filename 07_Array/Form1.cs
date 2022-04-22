using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayTest();
            ArrayClassTest();
        }

        private void ArrayTest()
        {
            int[] iArrayTest1 = { 1, 2, 3, 4, 5 };
            int[] iArrayTest2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] iArrayTest3 = new int[5];
            iArrayTest3[0] = 3;
            iArrayTest3[4] = 3;

            string[] strArrayTest = new string[6];

            int[,] reading = new int[3,6] { { 4, 9, 1, 0, 21, 12 }, { 1, 4, 6, 0, 9, 5 }, { 4, 4, 2, 4, 0, 0 } };
        }

        private void ArrayClassTest()
        {
            int[] iTest = { 10, 5, 30, 4, 15, 30, 18 };
            int i = iTest.Length;

            Array.Clear(iTest, 0, 2);
            Array.Resize(ref iTest, 10);
            int iSearch30 = Array.IndexOf(iTest, 30);
        }


        private void btnOneWeek_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();

            int[] iTest = { 10, 5, 30, 4, 15, 22, 18 };

            lblArracyCount.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            dgvDay["colDay1", 0].Value = iTest[0];
            dgvDay["colDay2", 0].Value = iTest[1];
            dgvDay["colDay3", 0].Value = iTest[2];
            dgvDay["colDay4", 0].Value = iTest[3];
            dgvDay["colDay5", 0].Value = iTest[4];
            dgvDay["colDay6", 0].Value = iTest[5];
            dgvDay["colDay7", 0].Value = iTest[6];
        }

        private void btnTwoWeek_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 20, 14, 15, 23, 17 } };

            lblArracyCount.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            dgvDay.Rows.Add();

            dgvDay["colDay1", 0].Value = iTest[0, 0];
            dgvDay["colDay2", 0].Value = iTest[0, 1];
            dgvDay["colDay3", 0].Value = iTest[0, 2];
            dgvDay["colDay4", 0].Value = iTest[0, 3];
            dgvDay["colDay5", 0].Value = iTest[0, 4];
            dgvDay["colDay6", 0].Value = iTest[0, 5];
            dgvDay["colDay7", 0].Value = iTest[0, 6];


            dgvDay["colDay1", 1].Value = iTest[1, 0];
            dgvDay["colDay2", 1].Value = iTest[1, 1];
            dgvDay["colDay3", 1].Value = iTest[1, 2];
            dgvDay["colDay4", 1].Value = iTest[1, 3];
            dgvDay["colDay5", 1].Value = iTest[1, 4];
            dgvDay["colDay6", 1].Value = iTest[1, 5];
            dgvDay["colDay7", 1].Value = iTest[1, 6];
        
        }
    }
}
