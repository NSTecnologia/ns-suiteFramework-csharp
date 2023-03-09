using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.src.Requisições._Genéricas
{
    public class ConsultaAPIIBPT
    {
        public string token { get; set; }
        public string cnpj { get; set; }
        public string codigo { get; set; }
        public string uf { get; set; }
        public string ex { get; set; }
        public string descricao { get; set; }
        public string unidadeMedida { get; set; }
        public string valor { get; set; }
        public string gtin { get; set; }
    }
}
