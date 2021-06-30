using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos._Genéricos.Respostas
{
    public class ListarNSNRecResp
    {
        public string status { get; set; }
        public string motivo { get; set; }
        public List<NSNREcs> nsNRecs { get; set; }
    }
    public class NSNREcs
    {
        public string nsNRecs { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
    }

}
