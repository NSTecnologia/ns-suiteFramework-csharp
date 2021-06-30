using NSSuiteClientCSharp.Projetos.NFe;
using NSSuiteClientCSharp.Projetos.NFe.Requisições;
using NSSuiteClientCSharp.Projetos.NFe.Schema.Exemplos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Testes
{
    static class Program
    {
        static void Main(string[] args)
        {
            //CancelarReqNFe canc = new CancelarReqNFe
            //{
            //    chNFe = "aaaa"
            //};
            //canc.ToJSONString();
            NFesExemplo nfesexemplos = new NFesExemplo();
            LayoutNFe nfe102 = nfesexemplos.NotaICMS102();

            Console.WriteLine(nfe102.ToJSONString());
            Console.ReadLine();

            NFeAPI nfeapi = new NFeAPI();

            var resposta = nfeapi.EmitirNFeSincrono(nfe102.ToJSONString(), "json", "2", "07364617000135", "P", ".\\Notas\\", true);

            Console.WriteLine(resposta);
            Console.ReadLine();
        }
    }
}
