using Newtonsoft.Json;
using NSSuiteClientCSharp.Projetos.NSPainel.Requisições;
using NSSuiteClientCSharp.Projetos.NSPainel.Respostas;
using NSSuiteClientCSharp.Schema.Requisições.PainelNS;
using NSSuiteClientCSharp.Schema.Respostas.PainelNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSSuiteClientCSharp.Projetos
{
    public class NSPainelAPI : NSSuite
    {
        private void TratarSalvarLicenca(string respostaAPI)
        {
            var registrarLicencaResposta = JsonConvert.DeserializeObject<RegistarLicencaResp>(respostaAPI);
            string mensagemResposta = registrarLicencaResposta.msg;
            string statusResposta = registrarLicencaResposta.status;
            if (!statusResposta.Equals("200"))
            {
                string erro = registrarLicencaResposta.erro;
                string validacao = "";
                if (statusResposta.Equals("-2"))
                    validacao = string.Format("({0})", registrarLicencaResposta.validacao);
                MessageBox.Show($"Erro:{erro}{validacao}", mensagemResposta, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(mensagemResposta, "Cadastro de Licença");
        }
        public string SalvarLicenca(RegistrarLicencaReq json)
        {
            string requisicao = json.ToJSONString();
            string url = "http://painelapi.ns.eti.br/licenca/salvarDados";
            string respostaAPI = RequisitarNaAPI("CADASTRO_LICENCA", requisicao, url);
            TratarSalvarLicenca(respostaAPI);
            return respostaAPI;
        }

        private void TratarCriarChaveAtivacaoNFCeCloud()
        {

        }
        public List<string> CriarChaveAtivacaoNFCeCloud(ChaveAtivacaoNFCeReq json)
        {
            string requisicao = json.ToJSONString();
            string url = "https://painelapi.ns.eti.br/nfce/createActivationKey";
            string respostaAPI = RequisitarNaAPI("CRIAR_CHAVES_ATIVACAO", requisicao, url);
            var chavesAtivacaoResp = JsonConvert.DeserializeObject<ChaveAtivacaoNFCeResp>(respostaAPI);
            string statusResposta = chavesAtivacaoResp.status;
            if (statusResposta.Equals("200"))
            {

            }
            TratarCriarChaveAtivacaoNFCeCloud();
            return chavesAtivacaoResp.chaves;
        }

    }
}
