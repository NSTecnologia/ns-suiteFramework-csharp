using NSSuiteClientCSharp.Projetos.NFe.Requisições;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NFCe.Schema.Exemplos
{
    public class NFCesExemplo
    {
        public LayoutNFe NotaNFCeICMS102()
        {
            return new LayoutNFe
            {
                infNFe = new TNFeInfNFe
                {
                    versao = "4.00",
                    ide = new TNFeInfNFeIde
                    {
                        cUF = TCodUfIBGE.RS,
                        cNF = "00462186",
                        natOp = "VENDA A PRAZO - S",
                        mod = TMod.NFCe,
                        serie = "0",
                        nNF = "14842",
                        //dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        dhEmi = "2021-06-28T10:22:04-03:00",
                        tpNF = TNFeInfNFeIdeTpNF.Saida,
                        idDest = TNFeInfNFeIdeIdDest.OpInterna,
                        cMunFG = "4305108",
                        tpImp = TNFeInfNFeIdeTpImp.DANFENFCe,
                        tpEmis = TNFeInfNFeIdeTpEmis.Normal,
                        tpAmb = TAmb.Homologacao,
                        finNFe = TFinNFe.Normal,
                        indFinal = TNFeInfNFeIdeIndFinal.ConsumidorFinal,
                        indPres = TNFeInfNFeIdeIndPres.Presencial,
                        procEmi = TProcEmi.AplicativoContribuinte,
                        verProc = "4.00"
                    },
                    emit = new TNFeInfNFeEmit
                    {
                        CNPJ = "07364617000135",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderEmit = new TEnderEmi
                        {
                            xLgr = "Rua Bento Osvaldo Trisch,777",
                            nro = ".",
                            xCpl = "CX POSTAL 91",
                            xBairro = "Pendancino",
                            cMun = "4303509",
                            xMun = "Caxias do Sul",
                            UF = TUfEmi.RS,
                            CEP = "95046600",
                            fone = "005432200200"
                        },
                        IE = "0170108708",
                        CRT = TNFeInfNFeEmitCRT.SimplesNacional
                    },
                    dest = new TNFeInfNFeDest
                    {
                        CPF = "01229452044",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderDest = new TEndereco
                        {
                            xLgr = "AV ANTONIO DURO",
                            nro = "0",
                            xBairro = "OLARIA",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf.RS,
                            CEP = "96180000",
                            cPais = "1058",
                            xPais = "BRASIL"
                        },
                        indIEDest = TNFeInfNFeDestIndIEDest.NaoContribuinte
                    },
                    det = new List<TNFeInfNFeDet>
                    {
                        new TNFeInfNFeDet
                        {
                            nItem = "1",
                            prod = new TNFeInfNFeDetProd
                            {
                                cProd = "1440859X1_",
                                cEAN = "SEM GTIN",
                                xProd = "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                                NCM = "87089990",
                                CEST = "0107500",
                                CFOP = "5101",
                                uCom = "UN",
                                qCom = "1.0000",
                                vUnCom = "13.50",
                                vProd = "13.50",
                                cEANTrib = "SEM GTIN",
                                uTrib = "UN",
                                qTrib = "1.0000",
                                vUnTrib = "13.50",
                                indTot = TNFeInfNFeDetProdIndTot.CompoeTotal,
                                nItemPed = "0",
                                cBenef ="SEM CBENEF"
                            },
                            imposto = new TNFeInfNFeDetImposto
                            {
                                vTotTrib = "0.00",
                                ICMS = new TNFeInfNFeDetImpostoICMS
                                {
                                    ICMSSN102 = new TNFeInfNFeDetImpostoICMSICMSSN102
                                    {
                                        orig = Torig.Nacional,
                                        CSOSN = TNFeInfNFeDetImpostoICMSICMSSN102CSOSN.CSOSN102
                                    }
                                },
                                PIS = new TNFeInfNFeDetImpostoPIS
                                {
                                    PISAliq = new TNFeInfNFeDetImpostoPISPISAliq
                                    {
                                        CST = TNFeInfNFeDetImpostoPISPISAliqCST.CST01,
                                        vBC = "0.00",
                                        pPIS = "0.00",
                                        vPIS = "0.00"
                                    }
                                },
                                COFINS = new TNFeInfNFeDetImpostoCOFINS
                                {
                                    COFINSAliq = new TNFeInfNFeDetImpostoCOFINSCOFINSAliq
                                    {
                                        CST = TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.CST01,
                                        vBC = "0.00",
                                        pCOFINS = "0.00",
                                        vCOFINS = "0.00"
                                    }
                                }
                            }
                        }
                    },
                    total = new TNFeInfNFeTotal
                    {
                        ICMSTot = new TNFeInfNFeTotalICMSTot
                        {
                            vBC = "0.00",
                            vICMS = "0.00",
                            vICMSDeson = "0.00",
                            vFCPUFDest = "0.00",
                            vICMSUFDest = "0.00",
                            vICMSUFRemet = "0.00",
                            vFCP = "0.00",
                            vBCST = "0.00",
                            vST = "0.00",
                            vFCPST = "0.00",
                            vFCPSTRet = "0.00",
                            vProd = "13.50",
                            vFrete = "0.00",
                            vSeg = "0.00",
                            vDesc = "0.00",
                            vII = "0.00",
                            vIPI = "0.00",
                            vIPIDevol = "0.00",
                            vPIS = "0.00",
                            vCOFINS = "0.00",
                            vOutro = "0.00",
                            vNF = "13.50",
                            vTotTrib = "0.00"
                        }
                    },
                    transp = new TNFeInfNFeTransp
                    {
                        modFrete = TNFeInfNFeTranspModFrete.SemTransporte
                    },
                    pag = new TNFeInfNFePag
                    {
                        detPag = new List<TNFeInfNFePagDetPag>
                        {
                            new TNFeInfNFePagDetPag
                            {
                                indPag = TNFeInfNFePagDetPagIndPag.PagamanetoAVista,
                                tPag = TNFeInfNFePagDetPagTPag.Dinheiro,
                                vPag = "13.50"
                            }
                        },
                        vTroco = "0.00"
                    },
                    infAdic = new TNFeInfNFeInfAdic
                    {
                        infCpl = "DESCONTO PIS 0,01 COFINS 0,06 LEI 11.196 DE 21/11/2005"
                    }
                }
            };
        }
    }
}
