using NSSuiteClientCSharp.Projetos._Genéricos.Respostas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NFe.Respostas
{
    public class ConsSitRespNFe : ConsSitResp
    {
        public RetConsSitNFe retConsSitNFe { get; set; }
    }
    public class RetConsSitNFe
    {
        public string tpAmb { get; set; }
        public string verAplic { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string cUF { get; set; }
        public string dhRecbto { get; set; }
        public List<ProtNFe> protNFe { get; set; }
        public string versao { get; set; }
    }
    public class ProtNFe
    {
        public string versao { get; set; }
        public InfProt infProt { get; set; }
    }
    public class InfProt
    {
        public string Id { get; set; }
        public string tpAmb { get; set; }
        public string verAplic { get; set; }
        public string chNFe { get; set; }
        public string dhRecbto { get; set; }
        public string nProt { get; set; }
        public string digVal { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
    }
}