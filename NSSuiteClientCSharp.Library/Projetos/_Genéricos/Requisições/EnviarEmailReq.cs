using System.Collections.Generic;
namespace NSSuiteClientCSharp.Projetos._Genéricos.Requisições
{
    public class EnviarEmailReq : JSON
    {
        public bool enviaEmailDoc { get; set; }
        public List<string> email { get; set; }
    }
}