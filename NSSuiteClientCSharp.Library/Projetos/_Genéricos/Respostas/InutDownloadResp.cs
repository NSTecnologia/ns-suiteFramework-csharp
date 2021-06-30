using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos._Genéricos.Respostas
{
    public class InutDownloadResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public RetInut retInut { get; set; }
        public Erro erro { get; set; }
    }
    public class RetInut
    {
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string chave { get; set; }
        public string tpAmb { get; set; }
        public string dhRecepto { get; set; }
        public string nProt { get; set; }
        public string xml { get; set; }
        public string pdf { get; set; }
    }
}
