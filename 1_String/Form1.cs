using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_String
{
    public partial class Form1 : Form
    {
        string strSample;
        public Form1()
        {
            InitializeComponent();

            strSample = "Sample,Test,Text";
            lblText.Text = strSample;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOut1.Text = strSample.Contains("Test").ToString();  //문자열 안에 해당 하는 문자열이 있는지 확인
            lblOut2.Text = strSample.Equals("Test").ToString();    //문자열이 해당 문자열과 동일 한지 확인
            lblOut3.Text = strSample.Length.ToString();            //개체의 문자수를 반환
            lblOut4.Text = strSample.Replace("Test", "I Can");     //지정된 문자열을 다른 문자열로 모두 변환
            string[] strArray = strSample.Split(',');              //문자열에서 조건에 맞는 문자를 기준으로 분할
            lblOut5.Text = strArray[0] + ":" + strArray[1] + ":" + strArray[2];
            lblOut6.Text = strSample.Substring(2, 5);              //문자열내의 조건 위치의 부분 문자열을 검색
            lblOut7.Text = strSample.ToLower();                    //문자열을 소문자로 변환
            lblOut8.Text = strSample.ToUpper();                    //문자열을 대문자로 변환
            lblOut9.Text = strSample.Trim();                       //문자열 전, 후 의 공백을 제거
        }
    }
}
