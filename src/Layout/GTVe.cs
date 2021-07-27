using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.GTVe;

namespace NSSuiteClientCSharp.src.Layout.GTVe
{
    class LayoutGTVe
    {
        public static string gerarLayoutGTVeXML()
        {
            TGTVe GTVe = new TGTVe
            {
                infCte = new TGTVeInfCte
                {
                    ide = new TGTVeInfCteIde
                    {

                    }
                }
            };

            string GTVeXML = gtveToXML(GTVe);
            return GTVeXML;
        }

        private static string gtveToXML(TGTVe GTVe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(GTVe.GetType());
                serializer.Serialize(stringwriter, GTVe);
                return stringwriter.ToString();
            }
        }
    }
}
