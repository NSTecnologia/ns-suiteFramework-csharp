using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.NFe;

namespace NSSuiteClientCSharp.src.Layout.NFe
{
    class LayoutNFe
    {
        public static string gerarLayoutNFeXML()
        {
            TNFe NFe = new TNFe
            {
                infNFe = new TNFeInfNFe
                {
                    ide = new TNFeInfNFeIde
                    {

                    }
                }
            };

            string NFeXML = nfeToXML(NFe);
            return NFeXML;
        }

        private static string nfeToXML(TNFe NFe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(NFe.GetType());
                serializer.Serialize(stringwriter, NFe);
                return stringwriter.ToString();
            }
        }
    }
}
