using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos._Genéricos.Respostas
{
    public class ConsSitResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public Erro erro { get; set; }
    }
}
