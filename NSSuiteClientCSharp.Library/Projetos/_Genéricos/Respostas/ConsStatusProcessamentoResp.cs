using System.Collections.Generic;
namespace NSSuiteClientCSharp.Projetos._Genéricos.Respostas
{
    public class ConsStatusProcessamentoResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string xMotivo { get; set; }
        public string dhRecbto { get; set; }
        public Erro erro { get; set; }
        public string cStat { get; set; }
        public string nProt { get; set; }
        public string xml { get; set; }
    }
}