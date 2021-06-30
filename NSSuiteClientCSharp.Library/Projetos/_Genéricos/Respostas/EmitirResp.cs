using System.Collections.Generic;

namespace NSSuiteClientCSharp.Projetos._Genéricos.Respostas
{
    public class EmitirResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public string xMotivo { get; set; }
        public List<string> erros { get; set; }
        public Erro erro { get; set; }
        public string nsNRec { get; set; }
    }
}