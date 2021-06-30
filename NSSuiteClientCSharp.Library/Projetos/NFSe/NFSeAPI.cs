using Newtonsoft.Json;
using NSSuiteClientCSharp.Projetos.NFSe.Requisições;
using NSSuiteClientCSharp.Projetos.NFSe.Respostas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos
{
    //public class NFSeAPI : NSSuite
    //{

//        public string EmitirNFSeSincrono(string conteudo, string tpConteudo, string tpAmb, string municipio, string cnpjEmitente)
//        {
//            string statusEnvio = string.Empty;
//            string statusConsulta = string.Empty;
//            string motivo = string.Empty;
//            string nsNRec = string.Empty;
//            string erro = string.Empty;
//            string chave = string.Empty;
//            string nNF = string.Empty;
//            string cStat = string.Empty;
//            string pdf = string.Empty;
//            string xml = string.Empty;

//            var envioResp = EnviaNFSe(conteudo, tpConteudo, tpAmb, municipio);

//            if (envioResp.status.Equals("200") || envioResp.status.Equals("-6"))
//            {
//                nsNRec = envioResp.nsNRec;
//                Thread.Sleep(600);
//                var consultaResp = ConsultaStatusProcessamentoNFSe(cnpjEmitente, tpAmb, nsNRec, municipio);

//                if (consultaResp.status.Equals("200"))
//                {
//                    cStat = consultaResp.cStat;

//                    //if (cStat.Equals("100"))
//                    //{
//                    //    chave = consultaResp
//                    //}
//                }
//            }
//            else
//            {

//            }

//        }
//        public EmitirNFSeResp EnviaNFSe(string conteudo, string tpConteudo, string tpAmb, string municipio)
//        {
//            string urlEnvio = $"https://nfseapi.ns.eti.br/v1/{municipio}/emissao";
//            string resposta = base.RequisitarNaAPI("ENVIO_NFSE", conteudo, urlEnvio, tpConteudo, tpAmb);
//            return JsonConvert.DeserializeObject<EmitirNFSeResp>(resposta);
//        }

//        public ConsStatusProcessamentoRespNFSe ConsultaStatusProcessamentoNFSe(string cnpjEmitente, string tpAmb, string nsNRec, string municipio)
//        {
//            var jsonConsulta = new ConsStatusProcessamentoReqNFSe
//            {
//                CNPJ = cnpjEmitente,
//                nsNRec = nsNRec,
//                tpAmb = tpAmb
//            };

//            string conteudo = jsonConsulta.ToJSONString();

//            string urlConsultaStatus = "https://nfseapi.ns.eti.br/v1/{municipio}/emissao/status";

//            string resposta = base.RequisitarNaAPI("CONSULTA_STATUS_NFSE", conteudo, urlConsultaStatus);

//            return JsonConvert.DeserializeObject<ConsStatusProcessamentoRespNFSe>(resposta);
//        }
//    }
}
