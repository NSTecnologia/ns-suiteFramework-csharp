using System;
using NSSuiteClientCSharp.src.NSSuite;
using NSSuiteClientCSharp.src.Layout.CTe;
using NSSuiteClientCSharp.src.Layout.MDFe;



namespace NSSuiteClientCSharp
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            string conteudoCTeXML = LayoutCTe.gerarLayoutCTeXML();
            string conteudoMDFeXML = LayoutMDFe.gerarLayoutMDFeXML();

            string respostaEmissaoCTe = NSSuite.emitirCTeSincrono(conteudoCTeXML, "57", "xml", "07364617000135", "XP", "2", @".\CTe\", true, false);
            string respostaEmissaoMDFe = NSSuite.emitirMDFeSincrono(conteudoMDFeXML, "xml", "07364617000135", "XP", "2", @".\MDFe\", true, false);
        } 
    }
}
