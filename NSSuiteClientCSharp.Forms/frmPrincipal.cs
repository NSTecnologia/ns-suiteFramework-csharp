using NSSuiteClientCSharp.Projetos;
using NSSuiteClientCSharp.Projetos.NFCe.Schema.Exemplos;
using NSSuiteClientCSharp.Projetos.NFe;
using NSSuiteClientCSharp.Projetos.NFe.Requisições;
using NSSuiteClientCSharp.Projetos.NFe.Schema.Exemplos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSSuiteClientCSharp.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEmitirNFe_Click(object sender, EventArgs e)
        {
            if (cmbTipoICMS.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Preencha um tipo de ICMS para emitir a NFe!");
            }
            else
            {
                NFesExemplo nfesexemplos = new NFesExemplo();
                NFeAPI nfeapi = new NFeAPI();
                var tipoicms = cmbTipoICMS.SelectedItem.ToString();
                var objetoNFe = "";
                switch (tipoicms)
                {
                    case "NotaICMS102":
                        LayoutNFe nfe102 = nfesexemplos.NotaICMS102();
                        objetoNFe = nfe102.ToJSONString();

                        break;
                    case "NotaICMSSN500":
                        LayoutNFe nfe500 = nfesexemplos.NotaICMSSN500();
                        objetoNFe = nfe500.ToJSONString();
                        break;
                    default:
                        break;
                }
                var resposta = nfeapi.EmitirNFeSincrono(objetoNFe, "json", "2", "07364617000135", "P", ".\\Notas\\", true);
                txtRetornoAPI.Text = resposta;
            }
        }

        private void btnEmitirNFCe_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Opção ainda esta sendo implementada!");
            if (cmbTipoICMSNFCe.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Preencha um tipo de ICMS para emitir a NFCe!");
            }
            else
            {
                NFCesExemplo nfceexemplos = new NFCesExemplo();
                NFCeAPI nfceapi = new NFCeAPI();
                var tipoicms = cmbTipoICMSNFCe.SelectedItem.ToString();
                var objetoNFCe = "";
                switch (tipoicms)
                {
                    case "NotaNFCeICMS102":
                        LayoutNFe nfce102 = nfceexemplos.NotaNFCeICMS102();
                        objetoNFCe = nfce102.ToJSONString();
                        break;
                    default:
                        break;
                }
                //string chNFe = "43210607364617000135650000000023051004621862";
                //string tpAmb = "2";
                //string caminho = ".\\Notas\\";
                //bool exibirPDF = true;
                //string tipoImpresao = "PDF";

                //var resposta = nfceapi.DownloadNFCeESalvar(chNFe, tpAmb, caminho, exibirPDF, tipoImpresao);

                var resposta = nfceapi.EmitirNFCeSincrono(objetoNFCe, "json", "2", "07364617000135", "P", ".\\Notas\\", "", true);
                txtRetornoAPI.Text = resposta;
            }
        }

        private void btnEmitirNFSe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção ainda esta sendo implementada!");
        }

        private void btnEmitirMDFe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção ainda esta sendo implementada!");
        }

        private void btnEmitirCTe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção ainda esta sendo implementada!");
        }

        private void btnEmitirBPe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção ainda esta sendo implementada!");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
