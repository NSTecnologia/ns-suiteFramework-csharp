using NSSuiteClientCSharp.Projetos;
using NSSuiteClientCSharp.Projetos._Genéricos.Requisições;
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
            NFCeAPI nfceapiEvento = new NFCeAPI();
            CancelarReqNFe cancNFCe = new CancelarReqNFe
            {
                chNFe = "11111111111111111111111111111111111111111111",
                nProt = "143210000351228",
                tpAmb = "2",
                dhEvento = "2019-03-15T15:37:14-03:00",
                xJust = "TESTE DE CANCELAMENTO INTEGRAÇÃO NS"
            };
            var resposta = nfceapiEvento.CancelamentoNFCe(cancNFCe.ToJSONString(), "2");
            Console.WriteLine(resposta);
            Console.ReadLine();


            string chNFe = "11111111111111111111111111111111111111111111";
            string tpAmb = "2";
            string caminho = ".\\Notas\\";
            bool exibirPDF = true;
            string tipoImpressao = "PDF";
            string modeloImpEscPos = ""; //Se o tipo de impressão selecionado acima for ESCPOS, será necessário informar um dos modelos de impressora(BEMATECH MP-4200 TH,BEMATECH MP-2500 TH,DARUMA,EPSON T20,EPSON T70,ELGIN I9), se não o campo pode ficar vazio
            var respostaCanc = nfceapiEvento.DownloadNFCeESalvar(chNFe, tpAmb, caminho, exibirPDF, tipoImpressao, modeloImpEscPos);
            Console.WriteLine(respostaCanc);
            Console.ReadLine();

            string licencaCNPJ = "11111111111111";
            //string tpAmb = "2";
            //string chNFe = "11111111111111111111111111111111111111111111";
            var respostaCons = nfceapiEvento.ConsultarSituacao(chNFe, tpAmb, licencaCNPJ);
            Console.WriteLine(respostaCons);
            Console.ReadLine();

            //NFesExemplo nfesexemplos = new NFesExemplo();
            //LayoutNFe nfe102 = nfesexemplos.NotaICMS102();

            //Console.WriteLine(nfe102.ToJSONString());
            //Console.ReadLine();

            //NFeAPI nfeapi = new NFeAPI();

            //var resposta = nfeapi.EmitirNFeSincrono(nfe102.ToJSONString(), "json", "2", "07364617000135", "P", ".\\Notas\\", true);

            //Console.WriteLine(resposta);
            //Console.ReadLine();
        }
    }
}
