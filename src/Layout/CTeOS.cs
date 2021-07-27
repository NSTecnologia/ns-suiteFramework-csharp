using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.CTeOS;

namespace NSSuiteClientCSharp.src.Layout.CTeOS
{
    class LayoutCTeOS
    {
        public static string gerarLayoutCTeOSXML()
        {
            TCTeOS CTeOS = new TCTeOS
            {
                infCte = new TCTeOSInfCte
                {
                    ide = new TCTeOSInfCteIde
                    {

                    }
                }
            };

            string CTeOSXML = cteOSToXML(CTeOS);
            return CTeOSXML;
        }

        private static string cteOSToXML(TCTeOS CTeOS)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(CTeOS.GetType());
                serializer.Serialize(stringwriter, CTeOS);
                return stringwriter.ToString();
            }
        }
    }
}
