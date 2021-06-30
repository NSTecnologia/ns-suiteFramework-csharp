using NSSuiteClientCSharp.Projetos._Genéricos.Requisições;

namespace NSSuiteClientCSharp.Projetos.NFCe.Requisições
{
    public class DownloadReqNFCe : DownloadReq
    {
        public string chNFe { get; set; }
        public Impressao impressao { get; set; }
    }
}