using Newtonsoft.Json;

namespace NSSuiteClientCSharp.Schema.Respostas.PainelNS
{
    public class RegistarLicencaResp
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("erro")]
        public string erro { get; set; }

        [JsonProperty("validacao")]
        public string validacao { get; set; }
    }
}
