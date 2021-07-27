using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.NF3e;

namespace NSSuiteClientCSharp.src.Layout.NF3e
{
    class LayoutNF3e
    {
        public static string gerarLayoutNF3eXML()
        {
            TNF3e NF3e = new TNF3e
            {
                infNF3e = new TNF3eInfNF3e
                {
                    ide = new TNF3eInfNF3eIde
                    {

                    }
                }
            };

            string NF3eXML = nf3eToXML(NF3e);
            return NF3eXML;
        }

        private static string nf3eToXML(TNF3e NF3e)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(NF3e.GetType());
                serializer.Serialize(stringwriter, NF3e);
                return stringwriter.ToString();
            }
        }
    }
}
