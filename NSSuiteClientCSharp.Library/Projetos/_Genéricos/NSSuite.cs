using System;
using System.IO;
using System.Net;
using NSSuiteClientCSharp.Projetos.Genéricos;
using NSSuiteClientCSharp.Projetos._Genéricos.Requisições;
using System.Windows.Forms;

namespace NSSuiteClientCSharp.Projetos
{
    public abstract class NSSuite
    {      
        private const string _token = "ADQWREQW561D32AWS1D6";
        private string EnviaConteudoParaAPI(string conteudo, string url, string tpConteudo = "json", string tpAmb = null)
        {
            string retorno = "";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            //httpWebRequest.Timeout = 10000;
            //httpWebRequest.ReadWriteTimeout = 10000;
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers["X-AUTH-TOKEN"] = _token;
            if (!string.IsNullOrEmpty(tpAmb))
                httpWebRequest.Headers["tpAmb"] = tpAmb;

            if (tpConteudo == "txt")
                httpWebRequest.ContentType = "text/plain;charset=utf-8";
            else if (tpConteudo == "xml")
                httpWebRequest.ContentType = "application/xml;charset=utf-8";
            else
                httpWebRequest.ContentType = "application/json;charset=utf-8";


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(conteudo);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    retorno = streamReader.ReadToEnd();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)ex.Response;

                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                        retorno = streamReader.ReadToEnd();

                    switch (Convert.ToInt32(response.StatusCode))
                    {
                        case 401:
                            {
                                MessageBox.Show("Token não enviado ou inválido");
                                break;
                            }

                        case 403:
                            {
                                MessageBox.Show("Token sem permissão");
                                break;
                            }

                        case 404:
                            {
                                MessageBox.Show("Não encontrado, verifique o retorno para mais informações");
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }
            }

            return retorno;
        }
        protected string RequisitarNaAPI(string requisiticao, string conteudo, string url, string tpConteudo = "json", string tpAmb = null)
        {

            Util.GravarLinhaLog($"[{requisiticao.ToUpper()}_DADOS]");
            Util.GravarLinhaLog(conteudo);

            string resposta = EnviaConteudoParaAPI(conteudo, url, tpConteudo);

            Util.GravarLinhaLog($"[{requisiticao.ToUpper()}_RESPOSTA]");
            Util.GravarLinhaLog(resposta);

            return resposta;
        }

        // Emissão
        protected string EnviarDocumento(string conteudo, string tpConteudo, string urlEnvio, string cnpjEmitente, string nodoAssinatura, bool a3)
        {
            if (a3)
                conteudo = Util.VerificaAssinaturaA3(conteudo, tpConteudo, cnpjEmitente, nodoAssinatura);

            return this.RequisitarNaAPI($"ENVIO", conteudo, urlEnvio, tpConteudo);
        }
        protected string ConsultarStatusProcessamentoDocumento(ConsStatusProcessamentoReq json, string urlConsulta)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("CONSULTA", conteudo, urlConsulta);
        }
        protected string DownloadDocumento(DownloadReq json, string urlDownload)
        {
            string conteudo = json.ToJSONString();

            Util.GravarLinhaLog("DOWNLOAD_DADOS");
            Util.GravarLinhaLog(conteudo);

            return this.EnviaConteudoParaAPI(conteudo, urlDownload);
        }

        // Eventos
        protected string DownloadEventoDocumento(DownloadEventoReq json, string urlDownload)
        {
            string conteudo = json.ToJSONString();

            Util.GravarLinhaLog("DOWNLOAD_EVENTO_DADOS");
            Util.GravarLinhaLog(conteudo);

            return this.EnviaConteudoParaAPI(conteudo, urlDownload, "json");
        }
        protected string CancelarDocumento(string conteudo, string tpConteudo, string urlCancelamento, string cnpjEmitente, string nodoAssinatura, bool a3)
        {
            if (a3)
                conteudo = Util.VerificaAssinaturaA3(conteudo, tpConteudo, cnpjEmitente, nodoAssinatura);

            return this.RequisitarNaAPI("CANCELAMENTO", conteudo, urlCancelamento, tpConteudo);
        }
        protected string CorrigirDocumento(string conteudo, string tpConteudo, string urlCC, string cnpjEmitente, string nodoAssinatura, bool a3)
        {
            if (a3)
                conteudo = Util.VerificaAssinaturaA3(conteudo, tpConteudo, cnpjEmitente, nodoAssinatura);

            return this.RequisitarNaAPI("CARTA_CORRECAO", conteudo, urlCC, tpConteudo);
        }
        protected string InutilizarNumeracaoDocumento(string conteudo, string tpConteudo, string urlInutilizacao, string cnpjEmitente, string nodoAssinatura, bool a3)
        {
            if (a3)
                conteudo = Util.VerificaAssinaturaA3(conteudo, tpConteudo, cnpjEmitente, nodoAssinatura);
            return this.RequisitarNaAPI("INUTILIZAR_NUMERACAO", conteudo, urlInutilizacao, tpConteudo);
        }
        protected string DownloadInutilizacao(InutDownloadReq json, string urlInutDownload)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("DOWNLOAD_INUTILIZACAO", conteudo, urlInutDownload);
        }
        protected string ListarNSNRecsDocumento(ListarNSNRecReq json, string urlListarNSNRecs)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("LISTAR_NSNRECS_DOC", conteudo, urlListarNSNRecs);
        }
        protected string ConsultarSituacaoDocumento(ConsSitReq json, string urlConsSit)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("CONSULTA_SITUACAO", conteudo, urlConsSit);
        }

        // Funcões
        protected string EnviarDocumentoPorEmail(EnviarEmailReq json, string urlEnvioEmail)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("ENVIAR_POR_EMAIL", conteudo, urlEnvioEmail);
        }
        protected string GerarPreviaDocumento(string conteudo, string tpConteudo, string urlPrevia)
        {
            return this.RequisitarNaAPI("PREVIA", conteudo, urlPrevia, tpConteudo);
        }
        protected string GerarXMLEnvioDocumento(string conteudo, string tpConteudo, string urlGeracaoXMLEnvio)
        {
            return this.RequisitarNaAPI("GERAÇÃO_XML_ENVIO", conteudo, urlGeracaoXMLEnvio, tpConteudo);
        }
        protected string GerarXMLCancelamento(string conteudo, string urlGeracaoXMLEnvio)
        {
            return this.RequisitarNaAPI("GERAÇÃO_XML_CANCELAMENTO", conteudo, urlGeracaoXMLEnvio);
        }
        protected string GerarXMLCorrecao(string conteudo, string urlGerarXMLCorrecao)
        {
            return this.RequisitarNaAPI("GERAÇÃO_XML_CARTA_CORRECAO", conteudo, urlGerarXMLCorrecao);
        }
        protected string GerarXMLInutilizacaoDocumento(string conteudo, string urlGerarXMLInut)
        {
            return this.RequisitarNaAPI("GERAÇÃO_XML_INUTILIZACAO", conteudo, urlGerarXMLInut);
        }
        protected string ConsultarStatusWS(ConsStatusWSReq json, string urlConsStatusSefaz)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("GERAÇÃO_XML_INUTILIZACAO", conteudo, urlConsStatusSefaz);
        }
        protected string ConsultarCadastroContribuinte(ConsCadReq json, string urlConsCad)
        {
            string conteudo = json.ToJSONString();
            return this.RequisitarNaAPI("GERAÇÃO_XML_INUTILIZACAO", conteudo, urlConsCad);
        }

        // Tributos
        protected string DocumentoSugestivo(string conteudo, string tpConteudo, string urlTributos)
        {
            return this.RequisitarNaAPI("GERAR_XML_NS_TRIBUTOS", conteudo, urlTributos, tpConteudo);
        }
        
    }
}
