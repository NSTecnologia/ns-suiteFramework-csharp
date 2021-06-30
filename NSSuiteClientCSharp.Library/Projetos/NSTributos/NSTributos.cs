using Newtonsoft.Json;
using NSSuiteClientCSharp.Projetos.NSTributos.Respostas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NSTributos
{
    public class NSTributos : NSSuite
    {
        public string NFeSugestiva(string conteudo, string tpConteudo)
        {
            string urlTributosNFe = "https://tributos.ns.eti.br/v1/nfe";
            string resposta = base.DocumentoSugestivo(conteudo, tpConteudo, urlTributosNFe);
            var resp = JsonConvert.DeserializeObject<NSTributosNFeResp>(resposta);
            if (!resp.status.Equals("200"))
            {
                throw new Exception(
                "Metodo: NFeSugestiva() - " +
                $"Erro: {resp.motivo}");
            }
            return resp.xml;
        }
    }
}
