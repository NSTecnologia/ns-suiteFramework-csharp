using Newtonsoft.Json;
using NSSuiteClientCSharp.Projetos._Genéricos;
using NSSuiteClientCSharp.Projetos.Genéricos;
using NSSuiteClientCSharp.Projetos.NFe.Requisições;
using NSSuiteClientCSharp.Projetos.NFe.Respostas;
using NSSuiteClientCSharp.Projetos.NFe.Schema;
using NSSuiteClientCSharp.Schema.Requisições;
using NSSuiteClientCSharp.Schema.Respostas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NFe
{
    public class NFeAPI : NSSuite
    {
        public string EmitirNFeSincrono(LayoutNFe NFe, string tpDown, string caminho, bool exibirPDF = false, bool a3 = false)
        {
            string conteudo;
            string tpConteudo;
            string idEmitente;
            string tpAmb;

            if (a3)
            {
                conteudo = NFe.ToXMLString();
                tpConteudo = "xml";
            }
            else
            {
                conteudo = NFe.ToJSONString();
                tpConteudo = "json";
            }

            if (string.IsNullOrEmpty(NFe.infNFe.emit.CNPJ))
                idEmitente = NFe.infNFe.emit.CPF;
            else
                idEmitente = NFe.infNFe.emit.CNPJ;
            
            tpAmb = NFe.infNFe.ide.tpAmb.ToString();

            return EmitirNFeSincrono(conteudo, tpConteudo, tpAmb, idEmitente, tpDown, caminho, exibirPDF, a3);
        }
        public string EmitirNFeSincrono(string conteudo, string tpConteudo, string tpAmb, string cnpjEmitente, string tpDown, string caminho, bool exibirPDF = false, bool a3 = false)
        {
            string statusEnvio = string.Empty;
            string statusConsulta = string.Empty;
            string statusDownload = string.Empty;
            string motivo = string.Empty;
            string nsNRec = string.Empty;
            string chNFe = string.Empty;
            string cStat = string.Empty;
            string nProt = string.Empty;
            List<string> erros = null;

            Util.GravarLinhaLog("[EMISSAO_NFE_SINCRONA_INICIO]");

            var respEnvio = EnviarNFe(conteudo, tpConteudo, a3, cnpjEmitente);
            statusEnvio = respEnvio.status;

            switch (statusEnvio)
            {
                case "200":
                case "-6":
                    {
                       nsNRec = respEnvio.nsNRec;
                       var respConsultaProcessamentoNFe = ConsultarProcessamentoNFe(cnpjEmitente, tpAmb, nsNRec);

                        statusConsulta = respConsultaProcessamentoNFe.status;
                        if (statusConsulta.Equals("-2"))
                        {
                            cStat = respConsultaProcessamentoNFe.erro.cStat;
                            if (cStat.Equals("996"))
                            {
                                for (int i = 1; i <= 5; i++)
                                {
                                    Thread.Sleep(i*500);
                                    respConsultaProcessamentoNFe = ConsultarProcessamentoNFe(cnpjEmitente, tpAmb, nsNRec);
                                    if (!respConsultaProcessamentoNFe.status.Equals("-2"))
                                        break;
                                }
                            }
                            else
                            {
                                cStat = respConsultaProcessamentoNFe.cStat;
                                motivo = respConsultaProcessamentoNFe.erro.xMotivo;
                            }
                        }

                        if (statusConsulta.Equals("200"))
                        {
                            cStat = respConsultaProcessamentoNFe.cStat;

                            if (cStat.Equals("100") || cStat.Equals("150"))
                            {
                                chNFe = respConsultaProcessamentoNFe.chNFe;
                                nProt = respConsultaProcessamentoNFe.nProt;
                                motivo = respConsultaProcessamentoNFe.xMotivo;

                                var DownloadRespNFe = DownloadNFeESalvar(chNFe, tpAmb, tpDown, caminho, exibirPDF);
                                statusDownload = DownloadRespNFe.status;

                                if (!statusDownload.Equals("200"))
                                    motivo = DownloadRespNFe.motivo;
                            }
                            else
                                motivo = respConsultaProcessamentoNFe.xMotivo;
                        }
                        else
                            motivo = respConsultaProcessamentoNFe.motivo;
                        break;
                    }
                case "-7":
                    {
                        motivo = respEnvio.motivo;
                        nsNRec = respEnvio.nsNRec;
                        break;
                    }
                case "-4":
                case "-2":
                    {
                        motivo = respEnvio.motivo;
                        erros = respEnvio.erros;
                        break;
                    }
                case "-999":
                case "-5":
                    {
                        motivo = respEnvio.erro.xMotivo;
                        break;
                    }
                default:
                    {
                        try 
                        { 
                            motivo = respEnvio.motivo; 
                        }
                        catch 
                        {
                            motivo = respEnvio.ToString(); 
                        }
                        break;
                    }
            }

            var EmitirSincronoRetNFe = new EmitirSincronoRetNFe
            {
                statusEnvio = statusEnvio,
                statusConsulta = statusConsulta,
                statusDownload = statusDownload,
                cStat = cStat,
                chNFe = chNFe,
                nProt = nProt,
                motivo = motivo,
                nsNRec = nsNRec,
                erros = erros
            };

            string retorno = JsonConvert.SerializeObject(EmitirSincronoRetNFe, Formatting.Indented);

            Util.GravarLinhaLog("[JSON_RETORNO]");
            Util.GravarLinhaLog(retorno);
            Util.GravarLinhaLog("[EMISSAO_NFE_SINCRONA_FIM]");

            return retorno;
        }      
        public EmitirRespNFe EnviarNFe(string conteudo, string tpConteudo, bool a3, string cnpjEmitente)
        {            
            string urlEnvio = "https://nfe.ns.eti.br/nfe/issue";
            string resposta = EnviarDocumento(conteudo, tpConteudo, urlEnvio, cnpjEmitente, "infNFe", a3);
            return JsonConvert.DeserializeObject<EmitirRespNFe>(resposta);
        }
        public ConsStatusProcessamentoRespNFe ConsultarProcessamentoNFe(string cnpjEmitente, string tpAmb, string nsNRec)
        {
            var jsonConsulta = new ConsStatusProcessamentoReqNFe
            {
                CNPJ = cnpjEmitente,
                nsNRec = nsNRec,
                tpAmb = tpAmb
            };

            string urlConsulta = "https://nfe.ns.eti.br/nfe/issue/status";

            string resposta = ConsultarStatusProcessamentoDocumento(jsonConsulta, urlConsulta);

            return JsonConvert.DeserializeObject<ConsStatusProcessamentoRespNFe>(resposta);
        }
        public DownloadRespNFe DownloadNFe(string chNFe, string tpAmb, string tpDown)
        {
            var download = new DownloadReqNFe()
            {
                chNFe = chNFe,
                tpAmb = tpAmb,
                tpDown = tpDown.ToUpper()
            };

            string urlDownload = "https://nfe.ns.eti.br/nfe/get";

            string resposta = DownloadDocumento(download, urlDownload);

            return JsonConvert.DeserializeObject<DownloadRespNFe>(resposta);

        }    
        public DownloadRespNFe DownloadNFeESalvar(string chNFe, string tpAmb, string tpDown, string caminho, bool exibirPDF = false)
        {
            var downloadRespNFe = DownloadNFe(chNFe, tpAmb, tpDown);
            string status = downloadRespNFe.status;

            if (status.Equals("200"))
            {
                Util.GravarLinhaLog("DOWNLOAD_STATUS");
                Util.GravarLinhaLog(status);

                Util.CriaCaminhoDiretorio(caminho);

                string nomeArq = chNFe + "-procNFe";

                if (tpDown.ToUpper().Contains("X"))
                {
                    string xml = downloadRespNFe.xml;
                    Util.SalvarXML(xml, caminho, nomeArq);
                }

                if (tpDown.ToUpper().Contains("P"))
                {
                    string pdf = downloadRespNFe.pdf;
                    Util.SalvarPDF(pdf, caminho, nomeArq);

                    if (exibirPDF)
                        Process.Start(caminho + nomeArq + ".pdf");
                }
            }
            else
            {
                Util.GravarLinhaLog("DOWNLOAD_RESPOSTA");
                Util.GravarLinhaLog(JsonConvert.SerializeObject(downloadRespNFe));
            }

            return downloadRespNFe;
        }

        // Eventos
        public DownloadEventoRespNFe DownloadEventoNFe(string chNFe, string tpEvento, string nSeqEvento, string tpDown, string tpAmb)
        {
            var downloadEvento = new DownloadEventoReqNFe
            {
                chNFe = chNFe,
                tpDown = tpDown.ToUpper(),
                tpAmb = tpAmb,
                nSeqEvento = nSeqEvento,
                tpEvento = tpEvento.ToUpper()
            };
            string urlDownloadEvento = "https://nfe.ns.eti.br/nfe/get/event";

            string resposta = base.DownloadEventoDocumento(downloadEvento, urlDownloadEvento);

            return JsonConvert.DeserializeObject<DownloadEventoRespNFe>(resposta);

        }
        public DownloadEventoRespNFe DownloadEventoNFeESalvar(string chNFe, string tpEvento, string nSeqEvento, string tpDown, string tpAmb, string caminho, bool exibirPDF = false)
        {
            var downloadEventoRespNFe = DownloadEventoNFe(chNFe, tpEvento, nSeqEvento, tpDown, tpAmb);
            string status = downloadEventoRespNFe.status;

            if (status.Equals("200"))
            {
                Util.GravarLinhaLog("DOWNLOAD_EVENTO");
                Util.GravarLinhaLog(status);

                Util.CriaCaminhoDiretorio(caminho);


                if (tpEvento.ToLower().Equals("canc"))
                    tpEvento = "110111";
                else if (tpEvento.ToLower().Equals("cce"))
                    tpEvento = "110110";

                string nomeArq = tpEvento + chNFe + nSeqEvento + "-procEventoNFe";

                if (tpDown.ToUpper().Contains("X"))
                {
                    string xml = downloadEventoRespNFe.xml;
                    Util.SalvarXML(xml, caminho, nomeArq);
                }

                if (tpDown.ToUpper().Contains("P"))
                {
                    string pdf = downloadEventoRespNFe.pdf;
                    Util.SalvarPDF(pdf, caminho, nomeArq);

                    if (exibirPDF)
                        Process.Start(caminho + nomeArq + ".pdf");
                }
            }
            else if (status.Equals("-5"))
                throw new Exception($"Motivo: {downloadEventoRespNFe.motivo} - Erros: {downloadEventoRespNFe.erro}");
            else
                throw new Exception($"Motivo: {downloadEventoRespNFe.motivo}");
            return downloadEventoRespNFe;
        }
        private CancelarRespNFe CancelarNFe(string conteudo, string tpConteudo, bool a3, string cnpjEmitente)
        {
            string urlCancelamento = "https://nfe.ns.eti.br/nfe/cancel";
            string resposta = base.CancelarDocumento(conteudo, tpConteudo, urlCancelamento, cnpjEmitente, "infEvento", a3);
            return JsonConvert.DeserializeObject<CancelarRespNFe>(resposta);
        }
        public CancelarRespNFe CancelarNFeESalvar(string conteudo, string tpConteudo, string tpAmb, string tpDown, string caminho, bool exibirPDF = false, bool a3 = false, string cnpjEmitente = "")
        {
            var cancelarResp = CancelarNFe(conteudo, tpConteudo, a3, cnpjEmitente);
            string status = cancelarResp.status;

            if (status.Equals("200"))
            {
                string cStat = cancelarResp.retEvento.cStat;
                if (cStat.Equals("135"))
                {
                    string chNFe = cancelarResp.retEvento.chNFe;
                    DownloadEventoNFeESalvar(chNFe, "canc", "1", tpDown, tpAmb, caminho, exibirPDF);
                }
            }
            else if(status.Equals("-2"))
            {
                throw new Exception(cancelarResp.motivo);
            }
            else if(status.Equals("-3"))
            {
                throw new Exception($"Motivo: {cancelarResp.motivo} - Erros: {cancelarResp.erro}");
            }

            return cancelarResp;
        }
        public CorrigirRespNFe CorrigirNFe(string conteudo, string tpConteudo, bool a3 = false, string cnpjEmitente = "")
        {
            string urlCC = "https://nfe.ns.eti.br/nfe/cce";
            string resposta = base.CorrigirDocumento(conteudo, tpConteudo, urlCC, cnpjEmitente, "infEvento", a3);
            return JsonConvert.DeserializeObject<CorrigirRespNFe>(resposta);
        }
        public CorrigirRespNFe CorrigirNFeESalvar(string conteudo, string tpConteudo, string nSeqEvento, string tpAmb, string tpDown, string caminho, bool exibirPDF = false, bool a3 = false, string cnpjEmitente = "")
        {
            var corrigirResp = CorrigirNFe(conteudo, tpConteudo, a3, cnpjEmitente);
            string status = corrigirResp.status;

            if (status.Equals("200"))
            {
                string cStat = corrigirResp.retEvento.cStat;
                if (cStat.Equals("135"))
                {
                    string chNFe = corrigirResp.retEvento.chNFe;
                    DownloadEventoNFeESalvar(chNFe, "cc", nSeqEvento, tpDown, tpAmb, caminho, exibirPDF);
                }
            }
            else if (status.Equals("-2"))
            {
                throw new Exception(corrigirResp.motivo);
            }
            else if (status.Equals("-3"))
            {
                throw new Exception($"Motivo: {corrigirResp.motivo} - Erros: {corrigirResp.erro}");
            }

            return corrigirResp;
        }
        public ConsSitRespNFe ConsultarSituacao(string chNFe, string tpAmb, string licencaCNPJ = null, string versao = "4.00")
        {
            string urlConsSit = "https://nfe.ns.eti.br/nfe/stats";
            var json = new ConsSitReqNFe
            {
                chNFe = chNFe,
                tpAmb = tpAmb,
                versao = versao
            };

            if (string.IsNullOrEmpty(licencaCNPJ))
                json.licencaCnpj = licencaCNPJ;

            string resposta = base.ConsultarSituacaoDocumento(json, urlConsSit);
            return JsonConvert.DeserializeObject<ConsSitRespNFe>(resposta);
        }
        public InutDownloadRespNFe DownloadInutilizacaoNFe(string chNFe, string tpAmb, string tpDown)
        {     
            var json = new InutDownloadReqNFe
            {
                chave = chNFe,
                tpAmb = tpAmb,
                tpDown = tpDown.ToUpper()
            };

            string urlInutDownload = "https://nfe.ns.eti.br/nfe/get/inut";

            string resposta = base.DownloadInutilizacao(json, urlInutDownload);

            return JsonConvert.DeserializeObject<InutDownloadRespNFe>(resposta);
        }
        public InutDownloadRespNFe DownloadInutilizacaoNFeESalvar(string chNFe, string tpAmb, string tpDown, string caminho, bool exibirPDF = false)
        {
            var downloadInutResp = DownloadInutilizacaoNFe(chNFe, tpAmb, tpDown);

            if (downloadInutResp.status.Equals("200"))
            {
                if (downloadInutResp.retInut.cStat.Equals("102"))
                {
                    string nomeArq = chNFe + "-procInutNFe";

                    if (tpDown.ToUpper().Contains("X"))
                    {
                        string xml = downloadInutResp.retInut.xml;
                        Util.SalvarXML(xml, caminho, nomeArq);
                    }

                    if (tpDown.ToUpper().Contains("P"))
                    {
                        string pdf = downloadInutResp.retInut.pdf;
                        Util.SalvarPDF(pdf, caminho, nomeArq);

                        if (exibirPDF)
                            Process.Start(caminho + nomeArq + ".pdf");
                    }
                }
                return downloadInutResp;
            }
            else if (downloadInutResp.status.Equals("-3"))
            {
                throw new Exception(
                    "Metodo: DownloadInutilizacaoNFeESalvar() - " +
                    $"Erro: {downloadInutResp.erro.xMotivo}");
            }
            else
            {
                throw new Exception("Metodo: DownloadInutilizacaoNFeESalvar() - " +
                    $"Erro: {downloadInutResp.motivo}");
            }
        }      
        public InutilizarRespNFe InutilizarNumeracaoNFe(string conteudo, string tpConteudo, bool a3 = false, string cnpjEmitente = "")
        {
            string urlInutilizacao = "https://nfe.ns.eti.br/nfe/inut";

            string resposta = base.InutilizarNumeracaoDocumento(conteudo, tpConteudo, urlInutilizacao, cnpjEmitente, "infInut", a3);

            return JsonConvert.DeserializeObject<InutilizarRespNFe>(resposta);
        }
        public InutilizarRespNFe InutilizarNumeracaoNFeESalvar(string conteudo, string tpConteudo, string tpDown, string caminho, bool exibirPDF = false, bool a3 = false, string cnpjEmitente = "")
        {
            var inutResp = InutilizarNumeracaoNFe(conteudo, tpConteudo, a3, cnpjEmitente);

            if (inutResp.status.Equals("200"))
            {
                if (inutResp.retornoInutNFe.cStat.Equals("102"))
                {
                    string chNFe = inutResp.retornoInutNFe.chave;
                    string tpAmb = inutResp.retornoInutNFe.tpAmb;
                    DownloadInutilizacaoNFeESalvar(chNFe, tpAmb, tpDown, caminho, exibirPDF);
                    return inutResp;
                }
                else
                    throw new Exception($"Metodo: InutilizarNumeracaoNFeESalvar() - Erro: {inutResp.retornoInutNFe.xMotivo}");
            } 
            else 
                throw new Exception($"Metodo: InutilizarNumeracaoNFeESalvar() - Erro: {inutResp.motivo}");
        }

        // Funções
        public EnviarEmailRespNFe EnviarNFePorEmail(string chave, List<string> emails, bool enviarParaEmailsXML)
        {
            string urlEnvioEmail  = "https://nfe.ns.eti.br/util/resendemail";

            var json = new EnviarEmailReqNFe
            {
                chNFe = chave,
                email = emails,
                enviaEmailDoc = enviarParaEmailsXML              
            };

            string resposta = base.EnviarDocumentoPorEmail(json, urlEnvioEmail);
            return JsonConvert.DeserializeObject<EnviarEmailRespNFe>(resposta);
        }
        public ListarNSNRecRespNFe ListarNSNRecsNFes(string chNFe)
        {
            string urlListarNSNRecs = "https://nfe.ns.eti.br/util/list/nsnrecs";

            var json = new ListarNSNRecReqNFe
            {
                chNFe = chNFe
            };

            string resposta = base.ListarNSNRecsDocumento(json, urlListarNSNRecs);

            return JsonConvert.DeserializeObject<ListarNSNRecRespNFe>(resposta);
        }
        public PreviaRespNFe GerarPreviaNFe(string conteudo, string tpConteudo)
        {
            string urlPrevia = "https://nfe.ns.eti.br/util/preview/nfe";

            string resposta = base.GerarPreviaDocumento(conteudo, tpConteudo, urlPrevia);

            return JsonConvert.DeserializeObject<PreviaRespNFe>(resposta);
        }
        public ConsSitRespNFe ConsultarStatusWS(string cnpjCont, string ufConsulta, string tpAmb, string versao = "4.00")
        {
            var json = new ConsStatusWSReqNFe
            {
                CNPJCont = cnpjCont,
                tpAmb = tpAmb,
                UF = ufConsulta,
                versao = versao
            };

            string urlConsStatusSefaz = "https://nfe.ns.eti.br/util/wssefazstatus";

            string resposta = base.ConsultarStatusWS(json, urlConsStatusSefaz);

            return JsonConvert.DeserializeObject<ConsSitRespNFe>(resposta);
        }
        public ConsCadRespNFe ConsultarCadastroContribuinteNFe(string cnpjContribuite, string ufConsultoria, string ieConsultoria, string cnpjConsultada)
        {        
            var json = new ConsCadReqNFe
            {
                CNPJCont = cnpjContribuite,
                UF = ufConsultoria,
                IE = ieConsultoria,
                CNPJ = cnpjConsultada
            };
            
            string urlConsCad = "https://nfe.ns.eti.br/util/conscad";

            string resposta = base.ConsultarCadastroContribuinte(json, urlConsCad);

            return JsonConvert.DeserializeObject<ConsCadRespNFe>(resposta);
        }
        public string GerarXMLEnvioNFe(string conteudo, string tpConteudo)
        {
            string urlGeracaoXMLEnvio = "https://nfe.ns.eti.br/util/generatexml";

            string resposta = base.GerarXMLEnvioDocumento(conteudo, tpConteudo, urlGeracaoXMLEnvio);

            var gerarXMLEmissaoResp = JsonConvert.DeserializeObject<GerarXMLEmissaoRespNFe>(resposta);

            string status = gerarXMLEmissaoResp.status;
            if (status.Equals("200"))
            {
                return gerarXMLEmissaoResp.xml;
            }
            else if (status.Equals("-2"))
            {
                throw new Exception($"Metodo: GerarXMLEnvioNFe() " +
                    $"- Motivo: {gerarXMLEmissaoResp.motivo} " +
                    $"- Erro: {gerarXMLEmissaoResp.erros}");
            }
            else
            {
                throw new Exception($"Metodo: GerarXMLEnvioNFe() " +
                    $"- Erro: {gerarXMLEmissaoResp.motivo}");
            }
        }
        public string GerarXMLCancelamentoNFe(string conteudo)
        {
            string urlGerarXMLCancelamento = "https://nfe.ns.eti.br/util/generatecancel";

            string resposta =  base.GerarXMLCancelamento(conteudo, urlGerarXMLCancelamento);
            var gerarXMLCancResp = JsonConvert.DeserializeObject<GerarXMLCancelamentoRespNFe>(resposta);

            string status = gerarXMLCancResp.status;
            if (status.Equals("200"))
            {
                return gerarXMLCancResp.xml;
            }
            else if (status.Equals("-2"))
            {
                throw new Exception($"Metodo: GerarXMLEnvioNFe() " +
                    $"- Motivo: {gerarXMLCancResp.motivo} " +
                    $"- Erro: {gerarXMLCancResp.erros}");
            }
            else
            {
                throw new Exception($"Metodo: GerarXMLEnvioNFe() " +
                    $"- Erro: {gerarXMLCancResp.motivo}");
            }
        }
        public string GerarXMLCorrecaoNFe(string conteudo)
        {
            string urlGerarXMLCorrecao = "https://nfe.ns.eti.br/util/generatecce";
            return base.GerarXMLCorrecao(conteudo, urlGerarXMLCorrecao);
        }
        public string GerarXMLInutilizacao(string conteudo)
        {
            string urlGerarXMLInut = "https://nfe.ns.eti.br/util/generateinut";
            return base.GerarXMLInutilizacaoDocumento(conteudo, urlGerarXMLInut);
        }     
    }
}
