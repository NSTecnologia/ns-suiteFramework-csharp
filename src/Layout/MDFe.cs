using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.MDFe;

namespace NSSuiteClientCSharp.src.Layout.MDFe
{
    class LayoutMDFe
    {
        public static string gerarLayoutMDFeXML()
        {
            TMDFe MDFe = new TMDFe
            {
                infMDFe = new TMDFeInfMDFe
                {
                    ide = new TMDFeInfMDFeIde
                    {

                    }
                }
            };

            string MDFeXML = mdfeToXML(MDFe);

            return MDFeXML;

        }
        private static string mdfeToXML(TMDFe MDFe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(MDFe.GetType());
                serializer.Serialize(stringwriter, MDFe);
                return stringwriter.ToString();
            }
        }
    }
}
