using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _17_XmlReader
{
    class CXMLControl
    {
        public static string _TEXT_DATA = "TEXT_DATA";
        public static string _CBOX_DATA = "CBOX_DATA";
        public static string _NUMBER_DATA = "NUMBER_DATA";

        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXMLPath))
            {
                wr.WriteStartDocument();

                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TEXT_DATA, DXMLConfig[_TEXT_DATA]);
                wr.WriteElementString(_CBOX_DATA, DXMLConfig[_CBOX_DATA]);
                wr.WriteElementString(_NUMBER_DATA, DXMLConfig[_NUMBER_DATA]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }

        public Dictionary<string, string> fXML_Reader(string strXMLPath)
        {
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXMLPath))
            {
                while(rd.Read())
                {
                    if(rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read();

                            string strText = rd.ReadElementContentAsString(_TEXT_DATA, "");
                            DXMLConfig.Add(_TEXT_DATA, strText);

                            string strCbox = rd.ReadElementContentAsString(_CBOX_DATA, "");
                            DXMLConfig.Add(_CBOX_DATA, strCbox);

                            string strNumber = rd.ReadElementContentAsString(_NUMBER_DATA, "");
                            DXMLConfig.Add(_NUMBER_DATA, strNumber);
                        }
                    }
                }
            }
            return DXMLConfig;
        }
    }


    
}
