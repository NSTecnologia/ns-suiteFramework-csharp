using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using NSSuiteClientCSharp.src.Requisições._Genéricas;
using System.Net.Http;
using System.Web;
using System.Security.Policy;
using System.Reflection;

public class NSSuite
{
    private static string token = "SEU_TOKEN";
    private static Endpoints Endpoints = new Endpoints();
    private static Parametros Parametros = new Parametros();

    // Esta função envia um conteúdo para uma URL, em requisições do tipo POST
    public static string enviaConteudoParaAPI(string conteudo, string url, string tpConteudo)
    {
        string retorno = "";
        var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
        httpWebRequest.Method = "POST";
        httpWebRequest.Headers["X-AUTH-TOKEN"] = token;

        if (tpConteudo == "txt")
        {
            httpWebRequest.ContentType = "text/plain;charset=utf-8";
        }
        else if (tpConteudo == "xml")
        {
            httpWebRequest.ContentType = "application/xml;charset=utf-8";
        }
        else
        {
            httpWebRequest.ContentType = "application/json;charset=utf-8";
        }

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
            {
                retorno = streamReader.ReadToEnd();
            }
        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError)
            {
                HttpWebResponse response = (HttpWebResponse)ex.Response;

                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    retorno = streamReader.ReadToEnd();
                }

                switch (System.Convert.ToInt32(response.StatusCode))
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

    // Métodos específicos de BPe
    public static string emitirBPeSincrono(string conteudo, string tpConteudo, string CNPJ, string tpDown, string tpAmb, string caminho, bool exibeNaTela = false, bool a3 = false)
    {
        string statusEnvio, statusConsulta, statusDownload, motivo, nsNRec, chBPe, cStat, nProt;
        string retorno, resposta;
        IList<string> erros = null;
        string modelo = "63";

        statusEnvio = "";
        statusConsulta = "";
        statusDownload = "";
        motivo = "";
        nsNRec = "";
        chBPe = "";
        cStat = "";
        nProt = "";

        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_INICIO]");

        resposta = emitirDocumento(modelo, conteudo, tpConteudo, CNPJ, a3);

        var EmitirRespBPe = JsonConvert.DeserializeObject<EmitirRespBPe>(resposta);
        statusEnvio = EmitirRespBPe.status;

        // Testa se o envio foi feito com sucesso (200) ou se é para reconsultar (-6)
        if ((statusEnvio.Equals("200")) || (statusEnvio.Equals("-6")))
        {
            nsNRec = EmitirRespBPe.nsNRec;

            // É necessário aguardar alguns milisegundos antes de consultar o status de processamento
            Thread.Sleep(Parametros.TEMPO_ESPERA);

            ConsStatusProcessamentoReqBPe ConsStatusProcessamentoReqBPe = new ConsStatusProcessamentoReqBPe()
            {
                CNPJ = CNPJ,
                nsNRec = nsNRec,
                tpAmb = tpAmb
            };

            resposta = consultarStatusProcessamento(modelo, ConsStatusProcessamentoReqBPe);

            var ConsStatusProcessamentoRespBPe = JsonConvert.DeserializeObject<ConsStatusProcessamentoRespBPe>(resposta);
            statusConsulta = ConsStatusProcessamentoRespBPe.status;

            // Testa se a consulta foi feita com sucesso (200)
            if ((statusConsulta.Equals("200")))
            {
                cStat = ConsStatusProcessamentoRespBPe.cStat;

                // Testa se o cStat é igual a 100, pois significa "Autorizado"
                if ((cStat.Equals("100")))
                {
                    chBPe = ConsStatusProcessamentoRespBPe.chBPe;

                    nProt = ConsStatusProcessamentoRespBPe.nProt;

                    motivo = ConsStatusProcessamentoRespBPe.xMotivo;

                    DownloadReqBPe DownloadReqBPe = new DownloadReqBPe()
                    {
                        chBPe = chBPe,
                        tpAmb = tpAmb,
                        tpDown = tpDown
                    };

                    resposta = downloadDocumentoESalvar(modelo, DownloadReqBPe, caminho, chBPe + "-procBPe", exibeNaTela);

                    var DownloadRespBPe = JsonConvert.DeserializeObject<DownloadRespBPe>(resposta);
                    statusDownload = DownloadRespBPe.status;

                    // Testa se houve problema no download
                    if (!statusDownload.Equals("200"))
                    {
                        motivo = DownloadRespBPe.motivo;
                    }
                }
                else
                {
                    motivo = ConsStatusProcessamentoRespBPe.xMotivo;
                }
            }
            else if (statusConsulta.Equals("-2"))
            {
                cStat = ConsStatusProcessamentoRespBPe.erro.cStat;
                motivo = ConsStatusProcessamentoRespBPe.erro.xMotivo;
            }
            else
            {
                motivo = ConsStatusProcessamentoRespBPe.motivo;
            }
        }
        else if (statusEnvio.Equals("-5"))
        {
            cStat = EmitirRespBPe.erro.cStat;
            motivo = EmitirRespBPe.erro.xMotivo;
        }
        else if (statusEnvio.Equals("-4") || statusEnvio.Equals("-2"))
        {
            motivo = EmitirRespBPe.motivo;
            erros = EmitirRespBPe.erros;
        }
        else
        {
            try
            {
                motivo = EmitirRespBPe.motivo;
            }
            catch
            {
                motivo = EmitirRespBPe.ToString();
            }
        }

        EmitirSincronoRetBPe EmitirSincronoRetBPe = new EmitirSincronoRetBPe()
        {
            statusEnvio = statusEnvio,
            statusConsulta = statusConsulta,
            statusDownload = statusDownload,
            cStat = cStat,
            chBPe = chBPe,
            nProt = nProt,
            motivo = motivo,
            nsNRec = nsNRec,
            erros = erros
        };

        retorno = JsonConvert.SerializeObject(EmitirSincronoRetBPe);

        Genericos.gravarLinhaLog(modelo, "[JSON_RETORNO]");
        Genericos.gravarLinhaLog(modelo, retorno);
        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_FIM]");

        return retorno;
    }

    public static string naoEmbarque(string modelo, NaoEmbReqBPe NaoEmbReq)
    {
        string urlNaoEmb;

        switch (modelo)
        {
            case "63":
                {
                    urlNaoEmb = Endpoints.BPeNaoEmb;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de não embarque para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(NaoEmbReq);

        Genericos.gravarLinhaLog(modelo, "[NAO_EMBARQUE_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlNaoEmb, "json");

        Genericos.gravarLinhaLog(modelo, "[NAO_EMBARQUE_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string naoEmbarqueESalvar(string modelo, NaoEmbReqBPe NaoEmbReq, DownloadEventoReq DownloadEventoReq, string caminho, string chave, bool exibeNaTela = false)
    {
        string resposta = naoEmbarque(modelo, NaoEmbReq);
        NaoEmbResp NaoEmbResp = new NaoEmbResp();
        string status;
        string cStat;

        NaoEmbResp = JsonConvert.DeserializeObject<NaoEmbResp>(resposta);
        status = NaoEmbResp.status;

        if (status.Equals("200"))
        {
            cStat = NaoEmbResp.retEvento.cStat;
            if (cStat.Equals("135"))
            {
                downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chave, "", exibeNaTela);
            }

        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao não embarcar, veja o retorno da API para mais informações");
        }


        return resposta;
    }


    // Métodos específicos de CTe
    public static string emitirCTeSincrono(string conteudo, string mod, string tpConteudo, string CNPJ, string tpDown, string tpAmb, string caminho, bool exibeNaTela = false, bool a3 = false)
    {
        string statusEnvio, statusConsulta, statusDownload, motivo, nsNRec, chCTe, cStat, nProt;
        string retorno, resposta;
        IList<string> erros = null;
        string modelo = mod;

        statusEnvio = "";
        statusConsulta = "";
        statusDownload = "";
        motivo = "";
        nsNRec = "";
        chCTe = "";
        cStat = "";
        nProt = "";

        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_INICIO]");

        resposta = emitirDocumento(modelo, conteudo, tpConteudo, CNPJ, a3);

        var EmitirRespCTe = JsonConvert.DeserializeObject<EmitirRespCTe>(resposta);
        statusEnvio = EmitirRespCTe.status;

        // Testa se o envio foi feito com sucesso (200) ou se é para reconsultar (-6)
        if (statusEnvio.Equals("200") || statusEnvio.Equals("-6"))
        {
            nsNRec = EmitirRespCTe.nsNRec;

            // É necessário aguardar alguns milisegundos antes de consultar o status de processamento
            Thread.Sleep(Parametros.TEMPO_ESPERA);

            ConsStatusProcessamentoReqCTe ConsStatusProcessamentoReqCTe = new ConsStatusProcessamentoReqCTe()
            {
                CNPJ = CNPJ,
                nsNRec = nsNRec,
                tpAmb = tpAmb
            };

            resposta = consultarStatusProcessamento(modelo, ConsStatusProcessamentoReqCTe);

            var ConsStatusProcessamentoRespCTe = JsonConvert.DeserializeObject<ConsStatusProcessamentoRespCTe>(resposta);
            statusConsulta = ConsStatusProcessamentoRespCTe.status;

            // Testa se a consulta foi feita com sucesso (200)
            if (statusConsulta.Equals("200"))
            {
                cStat = ConsStatusProcessamentoRespCTe.cStat;

                if (cStat.Equals("100") || cStat.Equals("150"))
                {
                    chCTe = ConsStatusProcessamentoRespCTe.chCTe;

                    nProt = ConsStatusProcessamentoRespCTe.nProt;

                    motivo = ConsStatusProcessamentoRespCTe.xMotivo;

                    DownloadReqCTe DownloadReqCTe = new DownloadReqCTe()
                    {
                        chCTe = chCTe,
                        CNPJ = CNPJ,
                        tpAmb = tpAmb,
                        tpDown = tpDown
                    };

                    resposta = downloadDocumentoESalvar(modelo, DownloadReqCTe, caminho, chCTe + "-procCTe", exibeNaTela);

                    var DownloadRespCTe = JsonConvert.DeserializeObject<DownloadRespCTe>(resposta);

                    statusDownload = DownloadRespCTe.status;

                    if (!statusDownload.Equals("200")) motivo = DownloadRespCTe.motivo;
                }
                else
                {
                    motivo = ConsStatusProcessamentoRespCTe.xMotivo;
                }
            }
            else
            {
                motivo = ConsStatusProcessamentoRespCTe.motivo;
                erros = ConsStatusProcessamentoRespCTe.erros;
            }
        }
        else if (statusEnvio.Equals("-7"))
        {
            motivo = EmitirRespCTe.motivo;
            nsNRec = EmitirRespCTe.nsNRec;
        }
        else if (statusEnvio.Equals("-4"))
        {
            motivo = EmitirRespCTe.motivo;

            try
            {
                erros = EmitirRespCTe.erros;
            }
            catch { }

        }
        else if (statusEnvio.Equals("-9"))
        {
            motivo = EmitirRespCTe.erro.xMotivo;
            cStat = EmitirRespCTe.erro.cStat;
        }
        else
        {
            try
            {
                motivo = EmitirRespCTe.motivo;
            }
            catch { motivo = EmitirRespCTe.ToString(); }
        }

        EmitirSincronoRetCTe EmitirSincronoRetCTe = new EmitirSincronoRetCTe()
        {
            statusEnvio = statusEnvio,
            statusConsulta = statusConsulta,
            statusDownload = statusDownload,
            cStat = cStat,
            chCTe = chCTe,
            nProt = nProt,
            motivo = motivo,
            nsNRec = nsNRec,
            erros = erros
        };

        retorno = JsonConvert.SerializeObject(EmitirSincronoRetCTe);

        Genericos.gravarLinhaLog(modelo, "[JSON_RETORNO]");
        Genericos.gravarLinhaLog(modelo, retorno);
        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_FIM]");

        return retorno;
    }

    public static string informarGTV(string modelo, InfGTVReqCTe InfGTVReqCTe)
    {
        string urlInfGTV;

        switch (modelo)
        {
            case "57":
            case "67":
                {
                    urlInfGTV = Endpoints.CTeCancelamento;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de informação de GTV para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(InfGTVReqCTe);

        Genericos.gravarLinhaLog(modelo, "[INFORMACOES_GTV_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlInfGTV, "json");

        Genericos.gravarLinhaLog(modelo, "[INFORMACOES_GTV_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string informarGTVESalvar(string modelo, InfGTVReqCTe InfGTVReqCTe, DownloadEventoReq DownloadEventoReq, string caminho, string chave, bool exibeNaTela = false)
    {
        string resposta = informarGTV(modelo, InfGTVReqCTe);
        InfGTVRespCTe InfGTVRespCTe = new InfGTVRespCTe();
        string status;

        InfGTVRespCTe = JsonConvert.DeserializeObject<InfGTVRespCTe>(resposta);
        status = InfGTVRespCTe.status;

        if (status.Equals("200"))
        {
            downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chave, "", exibeNaTela);
        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao cancelar, veja o retorno da API para mais informações");
        }

        return resposta;
    }


    // Métodos específicos de MDFe
    public static string emitirMDFeSincrono(string conteudo, string tpConteudo, string CNPJ, string tpDown, string tpAmb, string caminho, bool exibeNaTela = false, bool a3 = false)
    {
        string statusEnvio, statusConsulta, statusDownload, motivo, nsNRec, chMDFe, cStat, nProt;
        string retorno, resposta;
        IList<string> erros = null;
        string modelo = "58";

        statusEnvio = "";
        statusConsulta = "";
        statusDownload = "";
        motivo = "";
        nsNRec = "";
        chMDFe = "";
        cStat = "";
        nProt = "";

        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_INICIO]");

        resposta = emitirDocumento(modelo, conteudo, tpConteudo, CNPJ, a3);

        var EmitirRespMDFe = JsonConvert.DeserializeObject<EmitirRespMDFe>(resposta);
        statusEnvio = EmitirRespMDFe.status;

        // Testa se o envio foi feito com sucesso (200) ou se é para reconsultar (-6)
        if (statusEnvio.Equals("200") || statusEnvio.Equals("-6"))
        {
            nsNRec = EmitirRespMDFe.nsNRec;

            // É necessário aguardar alguns milisegundos antes de consultar o status de processamento
            Thread.Sleep(Parametros.TEMPO_ESPERA);

            ConsStatusProcessamentoReqMDFe ConsStatusProcessamentoReqMDFe = new ConsStatusProcessamentoReqMDFe()
            {
                CNPJ = CNPJ,
                nsNRec = nsNRec,
                tpAmb = tpAmb
            };

            resposta = consultarStatusProcessamento(modelo, ConsStatusProcessamentoReqMDFe);

            var ConsStatusProcessamentoRespMDFe = JsonConvert.DeserializeObject<ConsStatusProcessamentoRespMDFe>(resposta);
            statusConsulta = ConsStatusProcessamentoRespMDFe.status;

            // Testa se a consulta foi feita com sucesso (200)
            if (statusConsulta == "200")
            {
                cStat = ConsStatusProcessamentoRespMDFe.cStat;

                // Testa se o cStat é igual a 100, pois significa "Autorizado"
                if (cStat.Equals("100"))
                {
                    chMDFe = ConsStatusProcessamentoRespMDFe.chMDFe;

                    nProt = ConsStatusProcessamentoRespMDFe.nProt;

                    motivo = ConsStatusProcessamentoRespMDFe.xMotivo;

                    DownloadReqMDFe DownloadReqMDFe = new DownloadReqMDFe()
                    {
                        chMDFe = chMDFe,
                        tpAmb = tpAmb,
                        tpDown = tpDown
                    };

                    resposta = downloadDocumentoESalvar(modelo, DownloadReqMDFe, caminho, chMDFe + "-procMDFe", exibeNaTela);

                    var DownloadRespMDFe = JsonConvert.DeserializeObject<DownloadRespMDFe>(resposta);

                    statusDownload = DownloadRespMDFe.status;

                    // Testa se houve problema no download
                    if (!statusDownload.Equals("200")) motivo = DownloadRespMDFe.motivo;
                }
                else
                {
                    motivo = ConsStatusProcessamentoRespMDFe.xMotivo;
                }

            }
            else if (statusConsulta.Equals("-2"))
            {
                cStat = ConsStatusProcessamentoRespMDFe.erro.cStat;

                motivo = ConsStatusProcessamentoRespMDFe.erro.xMotivo;
            }
            else
            {
                motivo = ConsStatusProcessamentoRespMDFe.motivo;
            }

        }
        else if (statusEnvio.Equals("-5"))
        {
            cStat = EmitirRespMDFe.erro.cStat;

            motivo = EmitirRespMDFe.erro.xMotivo;
        }
        else if (statusEnvio.Equals("-4") || statusEnvio.Equals("-2"))
        {
            motivo = EmitirRespMDFe.motivo;

            try
            {
                erros = EmitirRespMDFe.erros;
            }
            catch { }
        }
        else if (statusEnvio.Equals("-999"))
        {
            motivo = EmitirRespMDFe.erro.xMotivo;
        }
        else
        {
            try
            {
                motivo = EmitirRespMDFe.motivo;
            }
            catch { motivo = EmitirRespMDFe.ToString(); }
        }

        EmitirSincronoRetMDFe EmitirSincronoRetMDFe = new EmitirSincronoRetMDFe()
        {
            statusEnvio = statusEnvio,
            statusConsulta = statusConsulta,
            statusDownload = statusDownload,
            cStat = cStat,
            chMDFe = chMDFe,
            nProt = nProt,
            motivo = motivo,
            nsNRec = nsNRec,
            erros = erros
        };

        retorno = JsonConvert.SerializeObject(EmitirSincronoRetMDFe);

        Genericos.gravarLinhaLog(modelo, "[JSON_RETORNO]");
        Genericos.gravarLinhaLog(modelo, retorno);
        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_FIM]");

        return retorno;
    }

    public static string encerrarDocumento(string modelo, EncerrarReq EncerrarReq)
    {
        string urlEncerramento;

        switch (modelo)
        {
            case "58":
                {
                    urlEncerramento = Endpoints.MDFeEncerramento;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de encerramento para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(EncerrarReq);

        Genericos.gravarLinhaLog(modelo, "[ENCERRAMENTO_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlEncerramento, "json");

        Genericos.gravarLinhaLog(modelo, "[ENCERRAMENTO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string encerrarDocumentoESalvar(string modelo, EncerrarReq EncerrarReq, DownloadEventoReq DownloadEventoReq, string caminho, string chave, bool exibeNaTela = false)
    {
        string resposta = encerrarDocumento(modelo, EncerrarReq);
        EncerrarResp EncerrarResp = new EncerrarResp();
        string status;

        EncerrarResp = JsonConvert.DeserializeObject<EncerrarResp>(resposta);
        status = EncerrarResp.status;

        if (status.Equals("200"))
        {
            downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chave, "", exibeNaTela);
        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao encerrar, veja o retorno da API para mais informações");
        }

        return resposta;
    }

    public static string incluirCondutor(string modelo, IncCondutorReq IncCondutorReq)
    {
        string urlIncCondutor;

        switch (modelo)
        {
            case "58":
                {
                    urlIncCondutor = Endpoints.MDFeIncCondutor;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de inclusão de condutor para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(IncCondutorReq);

        Genericos.gravarLinhaLog(modelo, "[INC_CONDUTOR_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlIncCondutor, "json");

        Genericos.gravarLinhaLog(modelo, "[INC_CONDUTOR_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string incluirCondutorESalvar(string modelo, IncCondutorReq IncCondutorReq, DownloadEventoReq DownloadEventoReq, string caminho, string chave, bool exibeNaTela = false)
    {
        string resposta = incluirCondutor(modelo, IncCondutorReq);
        IncCondutorResp IncCondutorResp = new IncCondutorResp();
        string status;

        IncCondutorResp = JsonConvert.DeserializeObject<IncCondutorResp>(resposta);
        status = IncCondutorResp.status;

        if (status.Equals("200"))
        {
            downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chave, "", exibeNaTela);
        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao incluir condutor, veja o retorno da API para mais informações");
        }

        return resposta;
    }

    public static string consultarNaoEncerrados(string modelo, ConsNaoEncerradosReq ConsNaoEncerradosReq)
    {
        string urlConsNaoEncerrados;

        switch (modelo)
        {
            case "58":
                {
                    urlConsNaoEncerrados = Endpoints.MDFeConsNaoEncerrados;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de consulta de não encerrados para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(ConsNaoEncerradosReq);

        Genericos.gravarLinhaLog(modelo, "[CONS_NAO_ENCERRADOS_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlConsNaoEncerrados, "json");

        Genericos.gravarLinhaLog(modelo, "[CONS_NAO_ENCERRADOS_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }


    // Métodos específicos de NFCe
    public static string emitirNFCeSincrono(string conteudo, string tpConteudo, string CNPJ, string tpAmb, string caminho, bool exibeNaTela = false, bool a3 = false)
    {
        string statusEnvio, statusDownload, motivo, chNFe, cStat, nProt;
        string retorno, resposta;
        IList<string> erros = null;
        string modelo = "65";

        statusEnvio = "";
        statusDownload = "";
        motivo = "";
        chNFe = "";
        cStat = "";
        nProt = "";

        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_INICIO]");

        resposta = emitirDocumento(modelo, conteudo, tpConteudo, CNPJ, a3);

        var EmitirRespNFCe = JsonConvert.DeserializeObject<EmitirRespNFCe>(resposta);
        statusEnvio = EmitirRespNFCe.status;

        if (statusEnvio.Equals("100") || statusEnvio.Equals("-100"))
        {
            cStat = EmitirRespNFCe.nfeProc.cStat;

            if (cStat.Equals("100") || cStat.Equals("150"))
            {
                chNFe = EmitirRespNFCe.nfeProc.chNFe;

                nProt = EmitirRespNFCe.nfeProc.nProt;

                motivo = EmitirRespNFCe.nfeProc.xMotivo;

                Thread.Sleep(Parametros.TEMPO_ESPERA);

                DownloadReqNFCe DownloadReqNFCe = new DownloadReqNFCe()
                {
                    chNFe = chNFe,
                    tpAmb = tpAmb,
                    impressao = new Impressao()
                };

                resposta = downloadDocumentoESalvar(modelo, DownloadReqNFCe, caminho, chNFe + "-procNFCe", exibeNaTela);

                var DownloadRespNFCe = JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);
                statusDownload = DownloadRespNFCe.status;

                if (!statusDownload.Equals("100"))
                {
                    motivo = DownloadRespNFCe.motivo;
                }

            }
            else
            {
                motivo = EmitirRespNFCe.nfeProc.xMotivo;
            }
        }
        else if (statusEnvio.Equals("-995"))
        {
            motivo = EmitirRespNFCe.motivo;

            try
            {
                erros = EmitirRespNFCe.erros;
            }
            catch { }
        }
        else
        {
            motivo = EmitirRespNFCe.motivo;
        }

        EmitirSincronoRetNFCe EmitirSincronoRetNFCe = new EmitirSincronoRetNFCe()
        {
            statusEnvio = statusEnvio,
            statusDownload = statusDownload,
            cStat = cStat,
            chNFe = chNFe,
            nProt = nProt,
            motivo = motivo,
            erros = erros
        };

        retorno = JsonConvert.SerializeObject(EmitirSincronoRetNFCe);

        Genericos.gravarLinhaLog(modelo, "[JSON_RETORNO]");
        Genericos.gravarLinhaLog(modelo, retorno);
        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_FIM]");
        return retorno;
    }


    // Métodos específicos de NFe
    public static string emitirNFeSincrono(string conteudo, string tpConteudo, string CNPJ, string tpDown, string tpAmb, string caminho, bool exibeNaTela = false, bool a3 = false)
    {
        string statusEnvio, statusConsulta, statusDownload, motivo, nsNRec, chNFe, cStat, nProt;
        string retorno, resposta;
        IList<string> erros = null;
        string modelo = "55";

        statusEnvio = "";
        statusConsulta = "";
        statusDownload = "";
        motivo = "";
        nsNRec = "";
        chNFe = "";
        cStat = "";
        nProt = "";

        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_INICIO]");

        resposta = emitirDocumento(modelo, conteudo, tpConteudo, CNPJ, a3);

        var EmitirRespNFe = JsonConvert.DeserializeObject<EmitirRespNFe>(resposta);
        statusEnvio = EmitirRespNFe.status;

        // Testa se o envio foi feito com sucesso (200) ou se é para reconsultar (-6)
        if ((statusEnvio == "200") || (statusEnvio == "-6"))
        {
            nsNRec = EmitirRespNFe.nsNRec;

            // É necessário aguardar alguns milisegundos antes de consultar o status de processamento
            Thread.Sleep(Parametros.TEMPO_ESPERA);

            ConsStatusProcessamentoReqNFe ConsStatusProcessamentoReqNFe = new ConsStatusProcessamentoReqNFe()
            {
                CNPJ = CNPJ,
                nsNRec = nsNRec,
                tpAmb = tpAmb
            };

            resposta = consultarStatusProcessamento(modelo, ConsStatusProcessamentoReqNFe);

            var ConsStatusProcessamentoRespNFe = JsonConvert.DeserializeObject<ConsStatusProcessamentoRespNFe>(resposta);
            statusConsulta = ConsStatusProcessamentoRespNFe.status;

            // Testa se a consulta foi feita com sucesso (200)
            if (statusConsulta == "200")
            {
                cStat = ConsStatusProcessamentoRespNFe.cStat;

                // Testa se o cStat é igual a 100 ou 150, pois ambos significam "Autorizado"
                if ((cStat == "100") || (cStat == "150"))
                {
                    chNFe = ConsStatusProcessamentoRespNFe.chNFe;

                    nProt = ConsStatusProcessamentoRespNFe.nProt;

                    motivo = ConsStatusProcessamentoRespNFe.xMotivo;

                    DownloadReqNFe DownloadReqNFe = new DownloadReqNFe()
                    {
                        chNFe = chNFe,
                        tpAmb = tpAmb,
                        tpDown = tpDown
                    };

                    resposta = downloadDocumentoESalvar(modelo, DownloadReqNFe, caminho, chNFe + "-procNFe", exibeNaTela);

                    var DownloadRespNFe = JsonConvert.DeserializeObject<DownloadRespNFe>(resposta);
                    statusDownload = DownloadRespNFe.status;

                    // Testa se houve problema no download
                    if (!statusDownload.Equals("200"))
                    {
                        motivo = DownloadRespNFe.motivo;
                    }
                }
                else
                {
                    motivo = ConsStatusProcessamentoRespNFe.xMotivo;
                }

            }
            else if (statusConsulta.Equals("-2"))
            {
                cStat = ConsStatusProcessamentoRespNFe.cStat;

                motivo = ConsStatusProcessamentoRespNFe.erro.xMotivo;
            }
            else
            {
                motivo = ConsStatusProcessamentoRespNFe.motivo;
            }
        }
        else if (statusEnvio.Equals("-7"))
        {
            motivo = EmitirRespNFe.motivo;

            nsNRec = EmitirRespNFe.nsNRec;
        }
        else if (statusEnvio.Equals("-4") || statusEnvio.Equals("-2"))
        {
            motivo = EmitirRespNFe.motivo;

            try { erros = EmitirRespNFe.erros; }
            catch { }
        }
        else if (statusEnvio.Equals("-999") || statusEnvio.Equals("-5"))
        {
            motivo = EmitirRespNFe.erro.xMotivo;
        }
        else
        {
            try { motivo = EmitirRespNFe.motivo; }
            catch { motivo = EmitirRespNFe.ToString(); }
        }

        EmitirSincronoRetNFe EmitirSincronoRetNFe = new EmitirSincronoRetNFe()
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

        retorno = JsonConvert.SerializeObject(EmitirSincronoRetNFe);

        Genericos.gravarLinhaLog(modelo, "[JSON_RETORNO]");
        Genericos.gravarLinhaLog(modelo, retorno);
        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_FIM]");

        return retorno;
    }

    // Métodos específicos de NF3e
    public static string emitirNF3eSincrono(string conteudo, string tpConteudo, string CNPJ, string tpDown, string tpAmb, string caminho, bool exibeNaTela = false)
    {
        string statusEnvio, statusConsulta, statusDownload, motivo, nsNRec, chNF3e, cStat, nProt;
        string retorno, resposta;
        IList<string> erros = null;
        string modelo = "66";
        bool a3 = false;

        statusEnvio = "";
        statusConsulta = "";
        statusDownload = "";
        motivo = "";
        nsNRec = "";
        chNF3e = "";
        cStat = "";
        nProt = "";

        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_INICIO_NF3e]");

        resposta = emitirDocumento(modelo, conteudo, tpConteudo, CNPJ, a3);

        var EmitirRespNF3e = JsonConvert.DeserializeObject<EmitirRespNF3e>(resposta);
        statusEnvio = EmitirRespNF3e.status;

        // Testa se o envio foi feito com sucesso (200) ou se é para reconsultar (-6)
        if ((statusEnvio == "200") || (statusEnvio == "-6"))
        {
            nsNRec = EmitirRespNF3e.nsNRec;

            // É necessário aguardar alguns milisegundos antes de consultar o status de processamento
            Thread.Sleep(Parametros.TEMPO_ESPERA);

            //Aqui a NF3e poderá usar o mesmo objeto da NFe, pois são os mesmos dados
            ConsStatusProcessamentoReqNFe ConsStatusProcessamentoReqNFe = new ConsStatusProcessamentoReqNFe()
            {
                CNPJ = CNPJ,
                nsNRec = nsNRec,
                tpAmb = tpAmb
            };

            resposta = consultarStatusProcessamento(modelo, ConsStatusProcessamentoReqNFe);

            var ConsStatusProcessamentoRespNF3e = JsonConvert.DeserializeObject<ConsStatusProcessamentoRespNF3e>(resposta);
            statusConsulta = ConsStatusProcessamentoRespNF3e.status;

            // Testa se a consulta foi feita com sucesso (200)
            if (statusConsulta == "200")
            {
                cStat = ConsStatusProcessamentoRespNF3e.cStat;

                // Testa se o cStat é igual a 100 ou 150, pois ambos significam "Autorizado"
                if ((cStat == "100") || (cStat == "150"))
                {
                    chNF3e = ConsStatusProcessamentoRespNF3e.chNF3e;

                    nProt = ConsStatusProcessamentoRespNF3e.nProt;

                    motivo = ConsStatusProcessamentoRespNF3e.xMotivo;


                    DownloadReqNF3e DownloadReqNF3e = new DownloadReqNF3e()
                    {
                        chNF3e = chNF3e,
                        tpAmb = tpAmb,
                        tpDown = tpDown
                    };

                    resposta = downloadDocumentoESalvar(modelo, DownloadReqNF3e, caminho, chNF3e + "-procNF3e", exibeNaTela);

                    var DownloadRespNFe = JsonConvert.DeserializeObject<DownloadRespNFe>(resposta);
                    statusDownload = DownloadRespNFe.status;

                    // Testa se houve problema no download
                    if (!statusDownload.Equals("200"))
                    {
                        motivo = DownloadRespNFe.motivo;
                    }
                }
                else
                {
                    motivo = ConsStatusProcessamentoRespNF3e.xMotivo;
                }

            }
            else if (statusConsulta.Equals("-2"))
            {
                cStat = ConsStatusProcessamentoRespNF3e.cStat;

                motivo = ConsStatusProcessamentoRespNF3e.erro.xMotivo;
            }
            else
            {
                motivo = ConsStatusProcessamentoRespNF3e.motivo;
            }
        }
        else if (statusEnvio.Equals("-7"))
        {
            motivo = EmitirRespNF3e.motivo;

            nsNRec = EmitirRespNF3e.nsNRec;
        }
        else if (statusEnvio.Equals("-4") || statusEnvio.Equals("-2"))
        {
            motivo = EmitirRespNF3e.motivo;

            try { erros = EmitirRespNF3e.erros; }
            catch { }
        }
        else if (statusEnvio.Equals("-999") || statusEnvio.Equals("-5"))
        {
            motivo = EmitirRespNF3e.erro.xMotivo;
        }
        else
        {
            try { motivo = EmitirRespNF3e.motivo; }
            catch { motivo = EmitirRespNF3e.ToString(); }
        }

        EmitirSincronoRetNF3e EmitirSincronoRetNF3e = new EmitirSincronoRetNF3e()
        {
            statusEnvio = statusEnvio,
            statusConsulta = statusConsulta,
            statusDownload = statusDownload,
            cStat = cStat,
            chNF3e = chNF3e,
            nProt = nProt,
            motivo = motivo,
            nsNRec = nsNRec,
            erros = erros
        };

        retorno = JsonConvert.SerializeObject(EmitirSincronoRetNF3e);

        Genericos.gravarLinhaLog(modelo, "[JSON_RETORNO]");
        Genericos.gravarLinhaLog(modelo, retorno);
        Genericos.gravarLinhaLog(modelo, "[EMISSAO_SINCRONA_FIM]");

        return retorno;
    }

    //Cancelamento NF3e
    public static string cancelarNF3eESalvar(string modelo, CancelarReqNF3e CancelarReqNF3e, DownloadEventoReq DownloadEventoReq, string caminho, string cnpjEmitente, bool exibeNaTela = false, bool a3 = false)
    {
        //string resposta = cancelarDocumento(modelo, CancelarReqNF3e, cnpjEmitente, a3);
        string conteudo = JsonConvert.SerializeObject(CancelarReqNF3e);
        string urlCancNF3e = Endpoints.NF3eCancelamento;

        Genericos.gravarLinhaLog(modelo, "[CANCELAMENTO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);


        string resposta = enviaConteudoParaAPI(conteudo, urlCancNF3e, "json");


        CancelarRespNF3e CancRespNF3e = new CancelarRespNF3e();
        string status;
        string cStat;
        string chNF3e;

        CancRespNF3e = JsonConvert.DeserializeObject<CancelarRespNF3e>(resposta);
        status = CancRespNF3e.status;
        chNF3e = CancRespNF3e.chNF3e;
        if (status.Equals("200") || status.Equals("135"))
        {
            cStat = CancRespNF3e.retEvento.cStat;
            if (cStat.Equals("135")) downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chNF3e, "1", exibeNaTela);
        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao cancelar a NF3e, veja o retorno da API para mais informações");
        }
        return resposta;
    }


    // Métodos genéricos, compartilhados entre diversas funções
    public static string emitirDocumento(string modelo, string conteudo, string tpConteudo, string cnpjEmitente, bool a3)
    {
        string urlEnvio;
        string nodo;

        switch (modelo)
        {
            case "63":
                {
                    urlEnvio = Endpoints.BPeEnvio;
                    nodo = "infBPe";
                    break;
                }

            case "57":
                {
                    urlEnvio = Endpoints.CTeEnvio;
                    nodo = "infCTe";
                    break;
                }

            case "67":
                {
                    urlEnvio = Endpoints.CTeOSEnvio;
                    nodo = "infCTe";
                    break;
                }

            case "58":
                {
                    urlEnvio = Endpoints.MDFeEnvio;
                    nodo = "infMDFe";
                    break;
                }

            case "65":
                {
                    urlEnvio = Endpoints.NFCeEnvio;
                    nodo = "infNFe";
                    break;
                }

            case "55":
                {
                    urlEnvio = Endpoints.NFeEnvio;
                    nodo = "infNFe";
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de envio para o modelo " + modelo);
                }
        }

        if (a3)
        {
            string xml;
            try
            {
                if ("JSON".Equals(tpConteudo.ToUpper()) || "TXT".Equals(tpConteudo.ToUpper()))
                {
                    string respostaJSON = gerarXMLEmissao(modelo, conteudo, tpConteudo);
                    dynamic nodoJSON = JsonConvert.DeserializeObject(respostaJSON);
                    xml = nodoJSON.xml;
                    tpConteudo = "xml";
                } 
                else
                {
                    xml = conteudo;
                }

                X509Certificate2 cert = Genericos.buscaCertificado(cnpjEmitente.Trim());
                if (cert == null)
                {
                    MessageBox.Show("Certificado Digital não encontrado");
                    return null;
                }

                conteudo = Genericos.assinaXML(xml.Trim(), nodo, cert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Genericos.gravarLinhaLog(modelo, "[ENVIO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlEnvio, tpConteudo);

        Genericos.gravarLinhaLog(modelo, "[ENVIO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string consultarStatusProcessamento(string modelo, ConsStatusProcessamentoReq ConsStatusProcessamentoReq)
    {
        string urlConsulta;

        switch (modelo)
        {
            case "63":
                {
                    urlConsulta = Endpoints.BPeConsStatusProcessamento;
                    break;
                }

            case "57":
            case "67":
                {
                    urlConsulta = Endpoints.CTeConsStatusProcessamento;
                    break;
                }

            case "58":
                {
                    urlConsulta = Endpoints.MDFeConsStatusProcessamento;
                    break;
                }

            case "55":
                {
                    urlConsulta = Endpoints.NFeConsStatusProcessamento;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de consulta para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(ConsStatusProcessamentoReq);

        Genericos.gravarLinhaLog(modelo, "[CONSULTA_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlConsulta, "json");

        Genericos.gravarLinhaLog(modelo, "[CONSULTA_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);
        return resposta;
    }

    public static string downloadDocumento(string modelo, DownloadReq DownloadReq)
    {
        string urlDownload;

        switch (modelo)
        {
            case "63":
                {
                    urlDownload = Endpoints.BPeDownload;
                    break;
                }

            case "57":
            case "67":
                {
                    urlDownload = Endpoints.CTeDownload;
                    break;
                }

            case "58":
                {
                    urlDownload = Endpoints.MDFeDownload;
                    break;
                }

            case "65":
                {
                    urlDownload = Endpoints.NFCeDownload;
                    break;
                }

            case "55":
                {
                    urlDownload = Endpoints.NFeDownload;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de download para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(DownloadReq);

        Genericos.gravarLinhaLog(modelo, "[DOWNLOAD_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlDownload, "json");

        string status;
        if (!modelo.Equals("65"))
        {
            DownloadResp DownloadResp = new DownloadResp();
            DownloadResp = JsonConvert.DeserializeObject<DownloadResp>(resposta);
            status = DownloadResp.status;
        }
        else
        {
            DownloadRespNFCe DownloadRespNFCe = new DownloadRespNFCe();
            DownloadRespNFCe = JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);
            status = DownloadRespNFCe.status;
        }

        // O retorno da API será gravado somente em caso de erro, 
        // para não gerar um log extenso com o PDF e XML
        if (!status.Equals("200") & !status.Equals("100"))
        {
            Genericos.gravarLinhaLog(modelo, "[DOWNLOAD_RESPOSTA]");
            Genericos.gravarLinhaLog(modelo, resposta);
        }
        else
        {
            Genericos.gravarLinhaLog(modelo, "[DOWNLOAD_STATUS]");
            Genericos.gravarLinhaLog(modelo, status);
        }

        return resposta;
    }

    public static string downloadDocumentoESalvar(string modelo, DownloadReq DownloadReq, string caminho, string nome, bool exibeNaTela = false)
    {
        string resposta = downloadDocumento(modelo, DownloadReq);
        DownloadResp DownloadResp = new DownloadResp();
        DownloadRespNFCe DownloadRespNFCe = new DownloadRespNFCe();

        string status;
        if (!modelo.Equals("65"))
        {
            DownloadResp = JsonConvert.DeserializeObject<DownloadResp>(resposta);
            status = DownloadResp.status;
        }
        else
        {
            DownloadRespNFCe = JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);
            status = DownloadRespNFCe.status;
        }

        if (status.Equals("200") || status.Equals("100"))
        {
            // Cria o diretório, caso não exista
            try
            {
                if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho);
                if (!caminho.EndsWith(@"\")) caminho += @"\";
            }
            catch (IOException ex)
            {
                Genericos.gravarLinhaLog(modelo, "[CRIAR_DIRETORIO]" + caminho);
                Genericos.gravarLinhaLog(modelo, ex.Message);
                throw new Exception("Erro: " + ex.Message);
            }


            if (!modelo.Equals("65"))
            {
                // Verifica quais arquivos deve salvar
                if (DownloadReq.tpDown.ToUpper().Contains("X"))
                {
                    string xml = DownloadResp.xml;
                    Genericos.salvarXML(xml, caminho, nome);
                }

                if (DownloadReq.tpDown.ToUpper().Contains("P"))
                {
                    string pdf = DownloadResp.pdf;
                    Genericos.salvarPDF(pdf, caminho, nome);

                    if (exibeNaTela) Process.Start(caminho + nome + ".pdf");
                }
            }
            else
            {
                string xml = DownloadRespNFCe.nfeProc.xml;
                Genericos.salvarXML(xml, caminho, nome);

                string pdf = DownloadRespNFCe.pdf;
                Genericos.salvarPDF(pdf, caminho, nome);

                if (exibeNaTela) Process.Start(caminho + nome + ".pdf");
            }
        }
        else
        {
            MessageBox.Show("Ocorreu um erro, veja o retorno da API para mais informações");
        }

        return resposta;
    }

    public static string downloadEvento(string modelo, DownloadEventoReq DownloadEventoReq)
    {
        string urlDownloadEvento;

        switch (modelo)
        {
            case "63":
                {
                    urlDownloadEvento = Endpoints.BPeDownloadEvento;
                    break;
                }

            case "57":
            case "67":
                {
                    urlDownloadEvento = Endpoints.CTeDownloadEvento;
                    break;
                }

            case "58":
                {
                    urlDownloadEvento = Endpoints.MDFeDownloadEvento;
                    break;
                }

            case "65":
                {
                    urlDownloadEvento = Endpoints.NFCeDownload;
                    break;
                }

            case "55":
                {
                    urlDownloadEvento = Endpoints.NFeDownloadEvento;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de download de evento para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(DownloadEventoReq);

        Genericos.gravarLinhaLog(modelo, "[DOWNLOAD_EVENTO_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlDownloadEvento, "json");

        string status;
        if (!modelo.Equals("65"))
        {
            DownloadEventoResp DownloadEventoResp = new DownloadEventoResp();
            DownloadEventoResp = JsonConvert.DeserializeObject<DownloadEventoResp>(resposta);
            status = DownloadEventoResp.status;
        }
        else
        {
            DownloadRespNFCe DownloadRespNFCe = new DownloadRespNFCe();
            DownloadRespNFCe = JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);
            status = DownloadRespNFCe.status;
        }

        // O retorno da API será gravado somente em caso de erro, 
        // para não gerar um log extenso com o PDF e XML
        if (!status.Equals("200") && !status.Equals("100"))
        {
            Genericos.gravarLinhaLog(modelo, "[DOWNLOAD_EVENTO_RESPOSTA]");
            Genericos.gravarLinhaLog(modelo, resposta);
        }
        else
        {
            Genericos.gravarLinhaLog(modelo, "[DOWNLOAD_EVENTO_STATUS]");
            Genericos.gravarLinhaLog(modelo, status);
        }

        return resposta;
    }

    public static void downloadEventoESalvar(string modelo, DownloadEventoReq DownloadEventoReq, string caminho, string chave, string nSeqEvento, bool exibeNaTela = false)
    {
        string resposta = downloadEvento(modelo, DownloadEventoReq);
        string tpEventoSalvar = "";
        DownloadEventoResp DownloadEventoResp = new DownloadEventoResp();
        DownloadRespNFCe DownloadRespNFCe = new DownloadRespNFCe();

        string status;
        if (!modelo.Equals("65"))
        {
            DownloadEventoResp = JsonConvert.DeserializeObject<DownloadEventoResp>(resposta);
            status = DownloadEventoResp.status;
        }
        else
        {
            DownloadRespNFCe = JsonConvert.DeserializeObject<DownloadRespNFCe>(resposta);
            status = DownloadRespNFCe.status;
        }

        if (status.Equals("200") || status.Equals("100"))
        {
            // Cria o diretório, caso não exista
            try
            {
                if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho);
                if (!caminho.EndsWith(@"\")) caminho += @"\";
            }
            catch (IOException ex)
            {
                Genericos.gravarLinhaLog(modelo, "[CRIAR_DIRETORIO]" + caminho);
                Genericos.gravarLinhaLog(modelo, ex.Message);
                throw new Exception("Erro: " + ex.Message);
            }

            if (!modelo.Equals("65"))
            {
                if (DownloadEventoReq.tpEvento.ToUpper().Equals("CANC"))
                    tpEventoSalvar = "110111";
                else if (DownloadEventoReq.tpEvento.ToUpper().Equals("ENC"))
                    tpEventoSalvar = "110110";
                else
                    tpEventoSalvar = "110115";

                // Verifica quais arquivos deve salvar
                if (DownloadEventoReq.tpDown.ToUpper().Contains("X"))
                {
                    string xml = DownloadEventoResp.xml;
                    Genericos.salvarXML(xml, caminho, tpEventoSalvar + chave + nSeqEvento + "-procEven");
                }

                if (DownloadEventoReq.tpDown.ToUpper().Contains("P"))
                {
                    string pdf = DownloadEventoResp.pdf;
                    if ((pdf != null) && (pdf != ""))
                    {
                        Genericos.salvarPDF(pdf, caminho, tpEventoSalvar + chave + nSeqEvento + "-procEven");
                        if (exibeNaTela) Process.Start(caminho + tpEventoSalvar + chave + nSeqEvento + "-procEven.pdf");
                    }
                }
            }
            else
            {
                string xml = DownloadRespNFCe.nfeProc.xml;
                Genericos.salvarXML(xml, caminho, tpEventoSalvar + chave + nSeqEvento + "-procEven");

                string pdf = DownloadRespNFCe.pdfCancelamento;
                Genericos.salvarPDF(pdf, caminho, tpEventoSalvar + chave + nSeqEvento + "-procEven");

                if (exibeNaTela) Process.Start(caminho + tpEventoSalvar + chave + nSeqEvento + "-procEven.pdf");
            }
        }
        else
            MessageBox.Show("Ocorreu um erro, veja o retorno da API para mais informações");
    }

    public static string cancelarDocumento(string modelo, CancelarReq CancelarReq, string cnpjEmitente, bool a3)
    {
        string urlCancelamento;
        string nodo = "infEvento";

        switch (modelo)
        {
            case "63":
                {
                    urlCancelamento = Endpoints.BPeCancelamento;
                    break;
                }

            case "57":
            case "67":
                {
                    urlCancelamento = Endpoints.CTeCancelamento;
                    break;
                }

            case "58":
                {
                    urlCancelamento = Endpoints.MDFeCancelamento;
                    break;
                }

            case "65":
                {
                    urlCancelamento = Endpoints.NFCeCancelamento;
                    break;
                }

            case "55":
                {
                    urlCancelamento = Endpoints.NFeCancelamento;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de cancelamento para o modelo " + modelo);
                }
        }

        string conteudo = JsonConvert.SerializeObject(CancelarReq);

        if (a3)
        {
            string xml;
            try
            {
                string respostaJSON = gerarXMLCancelamento(modelo, conteudo, "json");
                dynamic nodoJSON = JsonConvert.DeserializeObject(respostaJSON);
                xml = nodoJSON.xml;

                X509Certificate2 cert = Genericos.buscaCertificado(cnpjEmitente.Trim());
                if (cert == null)
                {
                    MessageBox.Show("Certificado Digital não encontrado");
                    return null;
                }

                conteudo = Genericos.assinaXML(xml.Trim(), nodo, cert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Genericos.gravarLinhaLog(modelo, "[CANCELAMENTO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlCancelamento, "json");

        Genericos.gravarLinhaLog(modelo, "[CANCELAMENTO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string previaDocumento(string modelo, string tpConteudo, string conteudo)
    {
        string urlPrevia;
        switch (modelo)
        {
            case "55":
                {
                    urlPrevia = Endpoints.NFePrevia;
                    break;
                }
            case "65":
                {
                    urlPrevia = Endpoints.NFCePrevia;
                    break;
                }
            case "57":
                {
                    urlPrevia = Endpoints.CTePrevia;
                    break;
                }
            case "67":
                {
                    urlPrevia = Endpoints.CTeOSPrevia;
                    break;
                }
            case "58":
                {
                    urlPrevia = Endpoints.MDFePrevia;
                    break;
                }
            default:
                throw new Exception("Não definido endpoint de previa para o modelo " + modelo);
        }
        Genericos.gravarLinhaLog(modelo, "[PREVIA_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlPrevia, tpConteudo);

        Genericos.gravarLinhaLog(modelo, "[PREVIA_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        PreviaResp previaResp = JsonConvert.DeserializeObject<PreviaResp>(resposta);
        if (!previaResp.status.Equals("200"))
        {
            string motivo = previaResp.motivo;
            var erros = previaResp.erros;
            MessageBox.Show($"{motivo}, o(s) erro(s): {erros}");
        }
        return previaResp.pdf;
    }
    public static string cancelarDocumentoESalvar(string modelo, CancelarReq CancelarReq, DownloadEventoReq DownloadEventoReq, string caminho, string chave, string cnpjEmitente, bool exibeNaTela = false, bool a3 = false)
    {
        string resposta = cancelarDocumento(modelo, CancelarReq, cnpjEmitente, a3);
        CancelarResp CancelarResp = new CancelarResp();
        string status;
        string cStat;

        CancelarResp = JsonConvert.DeserializeObject<CancelarResp>(resposta);
        status = CancelarResp.status;

        if (status.Equals("200") || status.Equals("135"))
        {
            cStat = CancelarResp.retEvento.cStat;
            if (cStat.Equals("135")) downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chave, "1", exibeNaTela);
        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao cancelar, veja o retorno da API para mais informações");
        }

        return resposta;
    }

    public static string corrigirDocumento(string modelo, CorrigirReq CorrigirReq, string cnpjEmitente, bool a3)
    {
        string urlCCe;
        string nodo = "infEvento";

        switch (modelo)
        {
            case "57":
            case "67":
                {
                    urlCCe = Endpoints.CTeCCe;
                    break;
                }

            case "55":
                {
                    urlCCe = Endpoints.NFeCCe;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de carta de correção para o modelo " + modelo);
                }
        }

        string conteudo = JsonConvert.SerializeObject(CorrigirReq);

        if (a3)
        {
            string xml;
            try
            {
                string respostaJSON = gerarXMLCorrecao(modelo, conteudo, "json");
                dynamic nodoJSON = JsonConvert.DeserializeObject(respostaJSON);
                xml = nodoJSON.xml;

                X509Certificate2 cert = Genericos.buscaCertificado(cnpjEmitente.Trim());
                if (cert == null)
                {
                    MessageBox.Show("Certificado Digital não encontrado");
                    return null;
                }

                conteudo = Genericos.assinaXML(xml.Trim(), nodo, cert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Genericos.gravarLinhaLog(modelo, "[CCE_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlCCe, "json");

        Genericos.gravarLinhaLog(modelo, "[CCE_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string corrigirDocumentoESalvar(string modelo, CorrigirReq CorrigirReq, DownloadEventoReq DownloadEventoReq, string caminho, string chave, string nSeqEvento, string cnpjEmitente, bool exibeNaTela = false, bool a3 = false)
    {
        string resposta = corrigirDocumento(modelo, CorrigirReq, cnpjEmitente, a3);
        CorrigirResp CorrigirResp = new CorrigirResp();
        string status;

        CorrigirResp = JsonConvert.DeserializeObject<CorrigirResp>(resposta);
        status = CorrigirResp.status;

        if (status.Equals("200"))
        {
            downloadEventoESalvar(modelo, DownloadEventoReq, caminho, chave, nSeqEvento, exibeNaTela);
        }
        else
        {
            MessageBox.Show("Ocorreu um erro ao corrigir, veja o retorno da API para mais informações");
        }

        return resposta;
    }

    public static string inutilizarNumeracao(string modelo, InutilizarReq InutilizarReq, string cnpjEmitente, bool a3)
    {
        string urlInutilizacao;
        string nodo = "infInut";

        switch (modelo)
        {
            case "57":
            case "67":
                {
                    urlInutilizacao = Endpoints.CTeInutilizacao;
                    break;
                }

            case "65":
                {
                    urlInutilizacao = Endpoints.NFCeInutilizacao;
                    break;
                }

            case "55":
                {
                    urlInutilizacao = Endpoints.NFeInutilizacao;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de inutilização para o modelo " + modelo);
                }
        }

        string conteudo = JsonConvert.SerializeObject(InutilizarReq);

        if (a3)
        {
            string xml;
            try
            {
                string respostaJSON = gerarXMLInutilizacao(modelo, conteudo, "json");
                dynamic nodoJSON = JsonConvert.DeserializeObject(respostaJSON);
                xml = nodoJSON.xml;

                X509Certificate2 cert = Genericos.buscaCertificado(cnpjEmitente.Trim());
                if (cert == null)
                {
                    MessageBox.Show("Certificado Digital não encontrado");
                    return null;
                }

                conteudo = Genericos.assinaXML(xml.Trim(), nodo, cert);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Genericos.gravarLinhaLog(modelo, "[INUTILIZACAO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlInutilizacao, "json");

        Genericos.gravarLinhaLog(modelo, "[INUTILIZACAO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string inutilizarNumeracaoESalvar(string modelo, InutilizarReq InutilizarReq, string caminho, string cnpjEmitente, bool a3 = false)
    {
        string resposta = inutilizarNumeracao(modelo, InutilizarReq, cnpjEmitente, a3);
        string status;
        string xml;
        string chave;

        xml = null;
        chave = null;

        switch (modelo)
        {
            case "57":
            case "67":
                {
                    InutilizarRespCTe InutilizarRespCTe = new InutilizarRespCTe();
                    InutilizarRespCTe = JsonConvert.DeserializeObject<InutilizarRespCTe>(resposta);
                    status = InutilizarRespCTe.status;
                    if (status.Equals("200"))
                    {
                        string cStat = InutilizarRespCTe.retornoInutCTe.cstat;
                        if (cStat.Equals("102"))
                        {
                            xml = InutilizarRespCTe.retornoInutCTe.xmlInut;
                            chave = InutilizarRespCTe.retornoInutCTe.chave;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao inutilizar a numeração, veja o retorno da API para mais informações");
                    }
                    break;
                }

            case "65":
                {
                    InutilizarRespNFCe InutilizarRespNFCe = new InutilizarRespNFCe();
                    InutilizarRespNFCe = JsonConvert.DeserializeObject<InutilizarRespNFCe>(resposta);
                    status = InutilizarRespNFCe.status;
                    if (status.Equals("102"))
                    {
                        string cStat = InutilizarRespNFCe.retInutNFe.cStat;
                        if (cStat.Equals("102"))
                        {
                            xml = InutilizarRespNFCe.retInutNFe.xml;
                            chave = InutilizarRespNFCe.retInutNFe.chave;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao inutilizar a numeração, veja o retorno da API para mais informações");
                    }
                    break;
                }

            case "55":
                {
                    InutilizarRespNFe InutilizarRespNFe = new InutilizarRespNFe();
                    InutilizarRespNFe = JsonConvert.DeserializeObject<InutilizarRespNFe>(resposta);
                    status = InutilizarRespNFe.status;
                    if (status.Equals("200"))
                    {
                        string cStat = InutilizarRespNFe.retornoInutNFe.cStat;
                        if (cStat.Equals("102"))
                        {
                            xml = InutilizarRespNFe.retornoInutNFe.xmlInut;
                            chave = InutilizarRespNFe.retornoInutNFe.chave;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao inutilizar a numeração, veja o retorno da API para mais informações");
                    }
                    break;
                }

            default:
                {
                    throw new Exception("Nao existe para este modelo inutilização " + modelo);
                }

        }

        if (!string.IsNullOrEmpty(xml))
        {
            if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho);
            Genericos.salvarXML(xml, caminho, chave);
        }

        return resposta;
    }

    public static string consultarCadastroContribuinte(string modelo, ConsCadReq ConsCadReq)
    {
        string urlConsCad;

        switch (modelo)
        {
            case "57":
            case "67":
                {
                    urlConsCad = Endpoints.CTeConsCad;
                    break;
                }

            case "55":
                {
                    urlConsCad = Endpoints.NFeConsCad;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de consulta de cadastro para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(ConsCadReq, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore
        });

        Genericos.gravarLinhaLog(modelo, "[CONS_CAD_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlConsCad, "json");

        Genericos.gravarLinhaLog(modelo, "[CONS_CAD_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string consultarSituacaoDocumento(string modelo, ConsSitReq ConsSitReq)
    {
        string urlConsSit;

        switch (modelo)
        {
            case "63":
                {
                    urlConsSit = Endpoints.BPeConsSit;
                    break;
                }

            case "57":
            case "67":
                {
                    urlConsSit = Endpoints.CTeConsSit;
                    break;
                }

            case "58":
                {
                    urlConsSit = Endpoints.MDFeConsSit;
                    break;
                }

            case "65":
                {
                    urlConsSit = Endpoints.NFCeConsSit;
                    break;
                }

            case "55":
                {
                    urlConsSit = Endpoints.NFeConsSit;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de consulta de situação para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(ConsSitReq);

        Genericos.gravarLinhaLog(modelo, "[CONS_SIT_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlConsSit, "json");

        Genericos.gravarLinhaLog(modelo, "[CONS_SIT_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string listarNSNRecs(string modelo, ListarNSNRecReq ListarNSNRecReq)
    {
        string urlListarNSNRecs;

        switch (modelo)
        {
            case "57":
            case "67":
                {
                    urlListarNSNRecs = Endpoints.CTeListarNSNRecs;
                    break;
                }

            case "58":
                {
                    urlListarNSNRecs = Endpoints.MDFeListarNSNRecs;
                    break;
                }

            case "55":
                {
                    urlListarNSNRecs = Endpoints.NFeListarNSNRecs;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de listagem de nsNRec para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(ListarNSNRecReq);

        Genericos.gravarLinhaLog(modelo, "[LISTAR_NSNRECS_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlListarNSNRecs, "json");

        Genericos.gravarLinhaLog(modelo, "[LISTAR_NSNRECS_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }

    public static string enviarEmailDocumento(string modelo, EnviarEmailReq EnviarEmailReq)
    {
        string urlEnviarEmail;

        switch (modelo)
        {
            case "65":
                {
                    urlEnviarEmail = Endpoints.NFCeEnvioEmail;
                    break;
                }

            case "55":
                {
                    urlEnviarEmail = Endpoints.NFeEnvioEmail;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de envio de e-mail para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(EnviarEmailReq);

        Genericos.gravarLinhaLog(modelo, "[ENVIAR_EMAIL_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlEnviarEmail, "json");

        Genericos.gravarLinhaLog(modelo, "[ENVIAR_EMAIL_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);

        return resposta;
    }
    public static string gerarPDFDeXML(string modelo, GerarPDFDeXMLReq gerarPDFReq)
    {
        string urlGerarPDF;
        switch (modelo)
        {
            case "55":
                {
                    urlGerarPDF = Endpoints.NFeGerarPDFDeXML;
                    break;
                }
            default:
                {
                    throw new Exception("Não definido endpoint de geração de PDF a partir de XML processado para o modelo " + modelo);
                }
        }

        string json = JsonConvert.SerializeObject(gerarPDFReq);

        Genericos.gravarLinhaLog(modelo, "[GERACAO_PDF_DADOS]");
        Genericos.gravarLinhaLog(modelo, json);

        string resposta = enviaConteudoParaAPI(json, urlGerarPDF, "json");

        Genericos.gravarLinhaLog(modelo, "[GERACAO_PDF_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);
        return resposta;
    }
    public static string gerarXMLEmissao(string modelo, string conteudo, string tpConteudo)
    {
        string urlGerarXML;

        switch (modelo)
        {
            case "55":
                {
                    urlGerarXML = Endpoints.NFeGerarXMLEmissao;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de geração de XML de emissão para o modelo " + modelo);
                }
        }
        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_EMISSAO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlGerarXML, tpConteudo);

        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_EMISSAO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);
        return resposta;
    }

    public static string gerarXMLCancelamento(string modelo, string conteudo, string tpConteudo)
    {
        string urlGerarXML;

        switch (modelo)
        {
            case "55":
                {
                    urlGerarXML = Endpoints.NFeGerarXMLCancelamento;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de gerar XML de cancelamento para o modelo " + modelo);
                }
        }
        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_CANCELAMENTO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlGerarXML, tpConteudo);

        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_CANCELAMENTO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);
        return resposta;
    }

    public static string gerarXMLCorrecao(string modelo, string conteudo, string tpConteudo)
    {
        string urlGerarXML;

        switch (modelo)
        {
            case "55":
                {
                    urlGerarXML = Endpoints.NFeGerarXMLCorrecao;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de gerar XML de correção para o modelo " + modelo);
                }
        }
        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_CORRECAO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlGerarXML, tpConteudo);

        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_CORRECAO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);
        return resposta;
    }

    public static string gerarXMLInutilizacao(string modelo, string conteudo, string tpConteudo)
    {
        string urlGerarXML;

        switch (modelo)
        {
            case "55":
                {
                    urlGerarXML = Endpoints.NFeGerarXMLInut;
                    break;
                }

            default:
                {
                    throw new Exception("Não definido endpoint de gerar XML de inutilização para o modelo " + modelo);
                }
        }
        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_INUTILIZACAO_DADOS]");
        Genericos.gravarLinhaLog(modelo, conteudo);

        string resposta = enviaConteudoParaAPI(conteudo, urlGerarXML, tpConteudo);

        Genericos.gravarLinhaLog(modelo, "[GERACAO_XML_INUTILIZACAO_RESPOSTA]");
        Genericos.gravarLinhaLog(modelo, resposta);
        return resposta;
    }


    public static string consultarIBPT(ConsultaAPIIBPT consApiIBPT)
    {
        string token = "52-wmOVxfB2Krw2qQNgDAJrrpcfA9dU-UkvticSNGVXoaRuZ4k3smAE-K67WGN7W";
        
        using (var httpClient = new HttpClient())
        {
            string retorno = "";
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["token"] = token;
            queryString["cnpj"] = consApiIBPT.cnpj;
            queryString["codigo"] = consApiIBPT.codigo;
            queryString["uf"] = consApiIBPT.uf;
            queryString["ex"] = consApiIBPT.ex;
            queryString["descricao"] = HttpUtility.UrlEncode(consApiIBPT.descricao);
            queryString["valor"] = consApiIBPT.valor;
            queryString["gtin"] = HttpUtility.UrlEncode(consApiIBPT.gtin);
            var requestUri = $"{Endpoints.ApiIBTP}/produtos?{queryString}";
            Genericos.gravarLinhaLog("", requestUri);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
            httpWebRequest.Method = "GET";

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    retorno = streamReader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                throw new Exception("Unexpected error occured", ex);
            }
            Genericos.gravarLinhaLog("", retorno);
            return retorno;
        }
    }
}
