using System;
using NSSuiteClientCSharp.src.Classes.CTe;

namespace NSSuiteClientCSharp.src.Layout.CTe
{
    class LayoutCTe
    {
        public static string gerarLayoutCTeXML(){

            TCTe CTe = new TCTe {
                infCte = new TCTeInfCte {
                    ide = new TCTeInfCteIde {
                        Item = new TCTeInfCteIdeToma3 {
                            
                        }
                    }
                }
            };

            string cteToXML(TCTe CTe)
            {
                using (var stringwriter = new StringWriter())
                {
                    var serializer = new XmlSerializer(CTe.GetType());
                    serializer.Serialize(stringwriter, CTe);
                    return stringwriter.ToString();
                }
            }

            string CTeXML = cteToXML(CTe);

            return CTeXML;

        }
    }
}
