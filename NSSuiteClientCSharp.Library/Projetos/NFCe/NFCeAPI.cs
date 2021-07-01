using Newtonsoft.Json;
using NSSuiteClientCSharp.Projetos._Genéricos.Requisições;
using NSSuiteClientCSharp.Projetos.Genéricos;
using NSSuiteClientCSharp.Projetos.NFCe.Requisições;
using NSSuiteClientCSharp.Projetos.NFe.Requisições;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos
{
    public class NFCeAPI : NSSuite
    {

        public string EmitirNFCeSincrono(LayoutNFe NFCe, string tipoImpresao, string modeloImpEscPos, string caminho, bool exibirPDF = false, bool a3 = false)
        {
            string conteudo;
            string tpConteudo;
            string idEmitente;
            string tpAmb;
            string statusEnvio = string.Empty;
            string statusConsulta = string.Empty;
            string statusDownload = string.Empty;
            string motivo = string.Empty;
            string nsNRec = string.Empty;
            string chNFe = string.Empty;
            string cStat = string.Empty;
            string nProt = string.Empty;
            List<string> erros = null;

            Util.GravarLinhaLog("[EMISSAO_NFCE_SINCRONA_INICIO]");

            if (a3)
            {
                conteudo = NFCe.ToXMLString();
                tpConteudo = "xml";
            }
            else
            {
                conteudo = NFCe.ToJSONString();
                tpConteudo = "json";
            }

            if (string.IsNullOrEmpty(NFCe.infNFe.emit.CNPJ))
                idEmitente = NFCe.infNFe.emit.CPF;
            else
                idEmitente = NFCe.infNFe.emit.CNPJ;

            tpAmb = NFCe.infNFe.ide.tpAmb.ToString();

            return EmitirNFCeSincrono(conteudo, tpConteudo, tpAmb, idEmitente, caminho, tipoImpresao, modeloImpEscPos, exibirPDF, a3);
        }
        public string EmitirNFCeSincrono(string conteudo, string tpConteudo, string tpAmb, string cnpjEmitente, string tipoImpresao, string modeloImpEscPos, string caminho, bool exibirPDF = true, bool a3 = false)
        {
            string statusEnvio = string.Empty;
            string statusConsulta = string.Empty;
            string statusDownload = string.Empty;
            string motivo = string.Empty;
            string xMotivo = string.Empty;
            string nsNRec = string.Empty;
            string chNFe = string.Empty;
            string cStat = string.Empty;
            string nProt = string.Empty;
            List<string> erros = null;

            Util.GravarLinhaLog("[EMISSAO_NFE_SINCRONA_INICIO]");

            var respEnvio = EnviarNFCe(conteudo, tpConteudo, cnpjEmitente, a3);
            statusEnvio = respEnvio.status;
            switch (statusEnvio)
            {
                case "100":
                case "200":
                    {
                        cStat = respEnvio.nfeProc.cStat;
                        if (cStat.Equals("100") || cStat.Equals("150"))
                        {
                            chNFe = respEnvio.nfeProc.chNFe;
                            nProt = respEnvio.nfeProc.nProt;
                            motivo = respEnvio.nfeProc.xMotivo;

                            var DownloadRespNFCe = DownloadNFCeESalvar(chNFe, tpAmb, caminho, exibirPDF, tipoImpresao, modeloImpEscPos);
                            statusDownload = DownloadRespNFCe.status;

                            if (!statusDownload.Equals("200"))
                                motivo = DownloadRespNFCe.motivo;
                        }
                        else {
                            motivo = respEnvio.motivo;
                            cStat = respEnvio.nfeProc.cStat;
                            xMotivo = respEnvio.nfeProc.xMotivo;
                        }
                        break;
                    }
                case "-100":
                    motivo = respEnvio.motivo;
                    cStat = respEnvio.nfeProc.cStat;
                    xMotivo = respEnvio.nfeProc.xMotivo;
                    break;
                case "-995":
                    motivo = respEnvio.motivo;
                    erros = respEnvio.erros;
                    break;
                case "-999":
                    {
                        motivo = respEnvio.motivo;
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
            var EmitirSincronoRetNFCe = new EmitirSincronoRetNFCe
            {
                statusEnvio = statusEnvio,
                statusConsulta = statusConsulta,
                statusDownload = statusDownload,
                cStat = cStat,
                xMotivo = xMotivo,
                chNFe = chNFe,
                nProt = nProt,
                motivo = motivo,
                nsNRec = nsNRec,
                erros = erros
            };
            string retorno = JsonConvert.SerializeObject(EmitirSincronoRetNFCe, Formatting.Indented);
            Util.GravarLinhaLog("[JSON_RETORNO]");
            Util.GravarLinhaLog(retorno);
            Util.GravarLinhaLog("[EMISSAO_NFCE_SINCRONA_FIM]");

            return retorno;
        }


        public EmitirRespNFCe EnviarNFCe(string conteudo, string tpConteudo, string cnpjEmitente, bool a3)
        {
            string urlEnvio = "https://nfce.ns.eti.br/v1/nfce/issue";
            string resposta = EnviarDocumento(conteudo, tpConteudo, urlEnvio, cnpjEmitente, "infNFe", a3);
            return JsonConvert.DeserializeObject<EmitirRespNFCe>(resposta);
        }

        public DownloadRespNFCe DownloadNFCe(string chNFe, string tpAmb, string tipoImpressao, string modeloImpEscPos)
        {
            var download = new DownloadReqNFCe()
            {
                chNFe = chNFe,
                tpAmb = tpAmb,
                impressao = new Impressao()
                {
                    tipo = tipoImpressao,
                    modMiniImpressora = modeloImpEscPos
                }
            };

            string urlDownload = "https://nfce.ns.eti.br/v1/nfce/get";

            string resposta = DownloadDocumento(download, urlDownload);

            return JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);

        }


        public DownloadRespNFCe DownloadNFCeESalvar(string chNFe, string tpAmb, string caminho, bool exibirPDF = false, string tipoImpressao = "PDF", string modeloImpEscPos = null)
        {
            var downloadRespNFCe = DownloadNFCe(chNFe, tpAmb, tipoImpressao, modeloImpEscPos);
            string status = downloadRespNFCe.status;

            if (status.Equals("100"))
            {
                Util.GravarLinhaLog("DOWNLOAD_STATUS");
                Util.GravarLinhaLog(status);

                Util.CriaCaminhoDiretorio(caminho);

                string nomeArq = chNFe + "-procNFe";

                if (tipoImpressao.ToUpper().Contains("PDF"))
                {
                    string xml = downloadRespNFCe.nfeProc.xml;
                    Util.SalvarXML(xml, caminho, nomeArq);
                    string pdf = downloadRespNFCe.pdf;
                    Util.SalvarPDF(pdf, caminho, nomeArq);
                    if (exibirPDF)
                        Process.Start(caminho + nomeArq + ".pdf");
                }
                else
                {
                    string xml = downloadRespNFCe.nfeProc.xml;
                    Util.SalvarXML(xml, caminho, nomeArq);
                    string escpos = downloadRespNFCe.escpos;
                }
            }
            else
            {
                Util.GravarLinhaLog("DOWNLOAD_RESPOSTA");
                Util.GravarLinhaLog(JsonConvert.SerializeObject(downloadRespNFCe));
            }
            return downloadRespNFCe;
        }

    }
}
