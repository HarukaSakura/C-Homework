using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Builder
{
    public class XMLUtil
    {
        public static Object getBean()
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                
                xml.Load("config.xml");
                XmlNode root = xml.SelectSingleNode("/config");
                string cName = root.Attributes["className"].Value;
                Object obj = c.newInstance();
                return obj;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
