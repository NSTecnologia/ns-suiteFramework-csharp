using NSSuiteClientCSharp.Projetos._Genéricos.Requisições;

namespace NSSuiteClientCSharp.Projetos.NFe.Requisições
{
    public class DownloadReqNFe : DownloadReq
    {
        public string chNFe { get; set; }
        public bool printCEAN { get; set; }
    }
}