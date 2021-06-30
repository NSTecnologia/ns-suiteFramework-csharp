using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NSPainel.Respostas
{
    public class ChaveAtivacaoNFCeResp
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string status { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string msg { get; set; }
        [JsonProperty("chaves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> chaves { get; set; }
    }
}
