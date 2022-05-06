using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_XmlReader
{
    public partial class Form1 : Form
    {
        CXMLControl _xml = new CXMLControl();
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();

            _dData.Clear();

            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());


            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString() + strEnter);

            tboxConfigData.Text = sb.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.txt|All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                //StreamWriter swSFDialog = new StreamWriter(strFilePath);
                //swSFDialog.WriteLine(tboxConfigData.Text);
                //swSFDialog.Close();
                //File.WriteAllText(strFilePath, tboxConfigData.Text);

                _xml.fXML_Writer(strFilePath, _dData);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.*";

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;
                sb.Append(File.ReadAllText(strFilePath));

                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _xml.fXML_Reader(strFilePath);
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {

            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
        }

        

    }
}
