using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.BPe;

namespace NSSuiteClientCSharp.src.Layout.BPe
{
    class LayoutBPe
    {
        public static string gerarLayoutBPeXML()
        {
            TBPe BPe = new TBPe
            {
                infBPe = new TBPeInfBPe
                {
                    ide = new TBPeInfBPeIde
                    {

                    }
                }
            };

            string BPeXML = bpeToXML(BPe);
            return BPeXML;
        }

        private static string bpeToXML(TBPe BPe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(BPe.GetType());
                serializer.Serialize(stringwriter, BPe);
                return stringwriter.ToString();
            }
        }
    }
}
