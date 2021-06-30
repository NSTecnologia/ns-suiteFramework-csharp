using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos._Genéricos.Requisições
{
    public class InutDownloadReq : JSON
    {
        public string chave { get; set; }
        public string tpAmb { get; set; }
        public string tpDown { get; set; }
    }
}
