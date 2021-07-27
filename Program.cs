using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSSuiteClientCSharp.src.NSSuite;
using NSSuiteClientCSharp;

namespace NSSuiteClientCSharp
{
    class Program
    {
        static string conteudoCTeXML = LayoutCTe.gerarLayoutCTeXML();
        static string conteudoMDFeXML = LayoutMDFe.gerarLayoutMDFeXML();

        string respostaEmissaoCTe = NSSuite.emitirCTeSincrono(conteudoCTeXML, "57", "xml", "07364617000135", "XP", "2", @".\CTe\", true, false);
        string respostaEmissaoMDFe = NSSuite.emitirMDFeSincrono(conteudoMDFeXML, "xml", "07364617000135", "XP", "2", @".\MDFe\", true, false);
    }
}
