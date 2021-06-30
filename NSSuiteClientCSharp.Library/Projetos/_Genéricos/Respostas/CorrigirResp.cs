using System.Collections.Generic;
namespace NSSuiteClientCSharp.Projetos._Genéricos.Respostas
{
    public class CorrigirResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetEvento retEvento { get; set; }
        public Erro erro { get; set; }
    }
}