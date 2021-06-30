using Newtonsoft.Json;
using NSSuiteClientCSharp.Projetos._Genéricos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NSPainel.Requisições
{
    public class ChaveAtivacaoNFCeReq : JSON
    {
        [JsonProperty("CNPJ", Required = Required.Always)]
        public string CNPJ { get; set; }
        [DefaultValue(1)]
        [JsonProperty("numChaves", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int numChaves { get; set; }
    }
}
