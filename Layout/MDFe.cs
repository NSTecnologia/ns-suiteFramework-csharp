using System;
using NSSuiteClientCSharp.src.Classes.MDFe;

namespace NSSuiteClientCSharp.src.Layout.MDFe
{
    class LayoutMDFe
    {
        public static string gerarLayoutMDFeXML()
        {
            string MDFeXML = mdfeToXML(MDFe);
            
            return MDFeXML;

        }
    }
}
