using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _72_ExamXML
{
    public partial class Form1 : Form
    {

        XmlDocument xml = null;
        public Form1()
        {
            InitializeComponent();

            xml = new XmlDocument();
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
			XmlNode root = xml.CreateElement("미네르바");
			XmlNode company = xml.CreateElement("회사");
			company.InnerText = "Minerva";
			root.AppendChild(company);

			XmlNode user = xml.CreateElement("사용자정보");
			XmlAttribute name = xml.CreateAttribute("이름");
			name.Value = "스티브";
			XmlAttribute id = xml.CreateAttribute("아이디");
			id.Value = "kmc7468";

			user.Attributes.Append(name);
			user.Attributes.Append(id);

			XmlNode s = xml.CreateElement("특징");
			s.InnerText = "default";
			user.AppendChild(s);

			XmlAttribute attribut = xml.CreateAttribute("Attribut");
			attribut.Value = "b1";
			s.Attributes.Append(attribut);


			xml.AppendChild(root);
			root.AppendChild(user);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\minerva.xml";
			xml.Save(path);

		}

		private void btnReadXml_Click(object sender, EventArgs e)
        {
			string strMessage = string.Empty;
			string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\minerva.xml";

			xml.Load(path);

			XmlNode root = xml.SelectNodes("미네르바")[0];

			strMessage = $"회사 : {root.SelectNodes("회사")[0].InnerText}";
			lboxXml.Items.Add(strMessage);

			foreach (XmlNode it in root.SelectNodes("사용자정보"))
			{
				string name = it.Attributes["이름"].Value;
				string id = it.Attributes["아이디"].Value;
				string s = it.SelectNodes("특징")[0].InnerText;

				strMessage = $"< 블로거 정보 > 이름 : {name} 아이디 : {id} 특징 : {s}";

				lboxXml.Items.Add(strMessage);
			}
		}
    }
}
