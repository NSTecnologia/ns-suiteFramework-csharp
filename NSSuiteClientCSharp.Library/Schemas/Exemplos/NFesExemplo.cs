using NSSuiteClientCSharp.Projetos.NFe.Requisições;
//using NSSuiteClientCSharp.Schema.NFe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos.NFe.Schema.Exemplos
{
    public class NFesExemplo
    {
        public LayoutNFe NotaICMS102()
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
                        mod = TMod.NFe,
                        serie = "6",
                        nNF = "150",
                        dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        tpNF = TNFeInfNFeIdeTpNF.Saida,
                        idDest = TNFeInfNFeIdeIdDest.OpInterna,
                        cMunFG = "4305108",
                        tpImp = TNFeInfNFeIdeTpImp.DANFERetrato,
                        tpEmis = TNFeInfNFeIdeTpEmis.Normal,
                        tpAmb = TAmb.Homologacao,
                        finNFe = TFinNFe.Normal,
                        indFinal = TNFeInfNFeIdeIndFinal.Nao,
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
                        CNPJ = "07364617000135",
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
                        indIEDest = TNFeInfNFeDestIndIEDest.ContribuinteICMS,
                        IE = "0170108708"
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
                                xProd = "TESTE",
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
                                IPI = new TIpi
                                {
                                    cEnq = "341",
                                    IPINT = new TIpiIPINT
                                    {
                                        CST = TIpiIPINTCST.CST02
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
        public LayoutNFe NotaICMSSN500()
        {
            return new LayoutNFe
            {
                infNFe = new TNFeInfNFe
                {
                    versao = "4.00",
                    ide = new TNFeInfNFeIde
                    {
                        cUF = TCodUfIBGE.RS,
                        cNF = "12088",
                        natOp = "VENDA DE MERCADORIA ADQUIRIDA DE TERCEIRO",
                        mod = TMod.NFe,
                        serie = "0",
                        nNF = "1",
                        dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        tpNF = TNFeInfNFeIdeTpNF.Saida,
                        idDest = TNFeInfNFeIdeIdDest.OpInterna,
                        cMunFG = "4303509",
                        tpImp = TNFeInfNFeIdeTpImp.DANFERetrato,
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
                        CNPJ = "11111111111111",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderEmit = new TEnderEmi
                        {
                            xLgr = "AV ANTONIO DURO",
                            nro = "9",
                            xBairro = "CENTRO",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUfEmi.RS,
                            CEP = "96180000",
                            cPais = TEnderEmiCPais.BRASIL,
                            xPais = TEnderEmiXPais.BRASIL
                        },
                        IE = "1111111111",
                        CRT = TNFeInfNFeEmitCRT.SimplesNacional
                    },
                    dest = new TNFeInfNFeDest
                    {
                        CNPJ = "11111111111111",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderDest = new TEndereco
                        {
                            xLgr = "AV ANTONIO DURO",
                            nro = "9",
                            xBairro = "CENTRO",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf.RS,
                            CEP = "96180000",
                            cPais = "1058",
                            xPais = "BRASIL",
                        },
                        IE = "1111111111"
                    },
                    det = new List<TNFeInfNFeDet>
                    {
                        //Primeiro Item
                        new TNFeInfNFeDet
                        {
                            nItem = "1",
                            prod = new TNFeInfNFeDetProd
                            {
                                cProd = "3058",
                                xProd = "MATERIAL DE ILUMINACAO",
                                NCM = "30049059",
                                CEST = "1002500",
                                CFOP = "5405",
                                uCom = "UN",
                                qCom = "1",
                                vUnCom = "1500",
                                vProd = "1500.00",
                                uTrib = "UN",
                                qTrib = "1",
                                vUnTrib = "1500",
                                indTot = TNFeInfNFeDetProdIndTot.CompoeTotal,
                                nItemPed = "1",
                                indEscala = TNFeInfNFeDetProdIndEscala.S
                            },
                            imposto = new TNFeInfNFeDetImposto
                            {
                                ICMS = new TNFeInfNFeDetImpostoICMS
                                {
                                    ICMSSN500 = new TNFeInfNFeDetImpostoICMSICMSSN500
                                    {
                                        orig = Torig.Nacional,
                                        CSOSN = TNFeInfNFeDetImpostoICMSICMSSN500CSOSN.CSOSN500,
                                        vBCSTRet = "0.00",
                                        vICMSSTRet = "0.00",
                                        pST = "20.00",
                                        vBCFCPSTRet = "0.00",
                                        pFCPSTRet = "2.00",
                                        vFCPSTRet = "0.00",
                                    }

                                },
                                IPI = new TIpi
                                {
                                    cEnq = "104",
                                    IPINT = new TIpiIPINT
                                    {
                                        CST = TIpiIPINTCST.CST55
                                    }
                                },
                                COFINS = new TNFeInfNFeDetImpostoCOFINS
                                {
                                    COFINSNT = new TNFeInfNFeDetImpostoCOFINSCOFINSNT
                                    {
                                        CST = TNFeInfNFeDetImpostoCOFINSCOFINSNTCST.CST07
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
                            vBCST = "0.00",
                            vST = "0.00",
                            vProd = "3000.00",
                            vFrete = "0.00",
                            vSeg = "0.00",
                            vDesc = "0.00",
                            vII = "0.00",
                            vIPI = "0.00",
                            vPIS = "0.00",
                            vCOFINS = "0.00",
                            vOutro = "0.00",
                            vNF = "3000.00",
                            vFCP = "0.00",
                            vFCPST = "0.00",
                            vFCPSTRet = "0.00",
                            vIPIDevol = "0.00",
                        }
                    },
                    pag = new TNFeInfNFePag
                    {
                        vTroco = "0.00",
                        detPag = new List<TNFeInfNFePagDetPag>
                        {
                            new TNFeInfNFePagDetPag
                            {
                                tPag = TNFeInfNFePagDetPagTPag.Dinheiro,
                                vPag = "3000.00"
                            }
                        }
                    },
                    transp = new TNFeInfNFeTransp
                    {
                        modFrete = TNFeInfNFeTranspModFrete.SemTransporte
                    }
                }
            };
        }
        public LayoutNFe MaisDeUmItem()
        {
            return new LayoutNFe
            {
                infNFe = new TNFeInfNFe
                {
                    versao = "4.00",
                    ide = new TNFeInfNFeIde
                    {
                        cUF = TCodUfIBGE.RS,
                        cNF = "12088",
                        natOp = "VENDA DE MERCADORIA ADQUIRIDA DE TERCEIRO",
                        mod = TMod.NFe,
                        serie = "0",
                        nNF = "1",
                        dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        tpNF = TNFeInfNFeIdeTpNF.Saida,
                        idDest = TNFeInfNFeIdeIdDest.OpInterna,
                        cMunFG = "4303509",
                        tpImp = TNFeInfNFeIdeTpImp.DANFERetrato,
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
                        CNPJ = "11111111111111",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderEmit = new TEnderEmi
                        {
                            xLgr = "AV ANTONIO DURO",
                            nro = "9",
                            xBairro = "CENTRO",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUfEmi.RS,
                            CEP = "96180000",
                            cPais = TEnderEmiCPais.BRASIL,
                            xPais = TEnderEmiXPais.BRASIL
                        },
                        IE = "1111111111",
                        CRT = TNFeInfNFeEmitCRT.SimplesNacional
                    },
                    dest = new TNFeInfNFeDest
                    {
                        CNPJ = "11111111111111",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderDest = new TEndereco
                        {
                            xLgr = "AV ANTONIO DURO",
                            nro = "9",
                            xBairro = "CENTRO",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf.RS,
                            CEP = "96180000",
                            cPais = "1058",
                            xPais = "BRASIL",
                        },
                        IE = "1111111111"
                    },
                    det = new List<TNFeInfNFeDet>
                    {
                        //Primeiro Item
                        new TNFeInfNFeDet
                        {
                            nItem = "1",
                            prod = new TNFeInfNFeDetProd
                            {
                                cProd = "3058",
                                xProd = "MATERIAL DE ILUMINACAO",
                                NCM = "30049059",
                                CEST = "1002500",
                                CFOP = "5405",
                                uCom = "UN",
                                qCom = "1",
                                vUnCom = "1500",
                                vProd = "1500.00",
                                uTrib = "UN",
                                qTrib = "1",
                                vUnTrib = "1500",
                                indTot = TNFeInfNFeDetProdIndTot.CompoeTotal,
                                nItemPed = "1",
                                indEscala = TNFeInfNFeDetProdIndEscala.S
                            },
                            imposto = new TNFeInfNFeDetImposto
                            {
                                ICMS = new TNFeInfNFeDetImpostoICMS
                                {
                                    ICMSSN500 = new TNFeInfNFeDetImpostoICMSICMSSN500
                                    {
                                        orig = Torig.Nacional,
                                        CSOSN = TNFeInfNFeDetImpostoICMSICMSSN500CSOSN.CSOSN500,
                                        vBCSTRet = "0.00",
                                        vICMSSTRet = "0.00",
                                        pST = "20.00",
                                        vBCFCPSTRet = "0.00",
                                        pFCPSTRet = "2.00",
                                        vFCPSTRet = "0.00",
                                    }
                                },
                                IPI = new TIpi
                                {
                                    cEnq = "104",
                                    IPINT = new TIpiIPINT
                                    {
                                        CST = TIpiIPINTCST.CST55
                                    }
                                },
                                COFINS = new TNFeInfNFeDetImpostoCOFINS
                                {
                                    COFINSNT = new TNFeInfNFeDetImpostoCOFINSCOFINSNT
                                    {
                                        CST = TNFeInfNFeDetImpostoCOFINSCOFINSNTCST.CST07
                                    }
                                }
                            }
                        },
                        //Segundo Item
                        new TNFeInfNFeDet
                        {
                            nItem = "2",
                            prod = new TNFeInfNFeDetProd
                            {
                                cProd = "3058",
                                xProd = "MATERIAL DE ILUMINACAO",
                                NCM = "30049059",
                                CEST = "1002500",
                                CFOP = "5405",
                                uCom = "UN",
                                qCom = "1",
                                vUnCom = "1500",
                                vProd = "1500.00",
                                uTrib = "UN",
                                qTrib = "1",
                                vUnTrib = "1500",
                                indTot = TNFeInfNFeDetProdIndTot.CompoeTotal,
                                nItemPed = "1",
                                indEscala = TNFeInfNFeDetProdIndEscala.S
                            },
                            imposto = new TNFeInfNFeDetImposto
                            {
                                ICMS = new TNFeInfNFeDetImpostoICMS
                                {
                                    ICMSSN500 = new TNFeInfNFeDetImpostoICMSICMSSN500
                                    {
                                        orig = Torig.Nacional,
                                        CSOSN = TNFeInfNFeDetImpostoICMSICMSSN500CSOSN.CSOSN500,
                                        vBCSTRet = "0.00",
                                        vICMSSTRet = "0.00",
                                        pST = "20.00",
                                        vBCFCPSTRet = "0.00",
                                        pFCPSTRet = "2.00",
                                        vFCPSTRet = "0.00",
                                    }
                                },
                                IPI = new TIpi
                                {
                                    cEnq = "104",
                                    IPINT = new TIpiIPINT
                                    {
                                        CST = TIpiIPINTCST.CST55
                                    }
                                },
                                COFINS = new TNFeInfNFeDetImpostoCOFINS
                                {
                                    COFINSNT = new TNFeInfNFeDetImpostoCOFINSCOFINSNT
                                    {
                                        CST = TNFeInfNFeDetImpostoCOFINSCOFINSNTCST.CST07
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
                            vBCST = "0.00",
                            vST = "0.00",
                            vProd = "3000.00",
                            vFrete = "0.00",
                            vSeg = "0.00",
                            vDesc = "0.00",
                            vII = "0.00",
                            vIPI = "0.00",
                            vPIS = "0.00",
                            vCOFINS = "0.00",
                            vOutro = "0.00",
                            vNF = "3000.00",
                            vFCP = "0.00",
                            vFCPST = "0.00",
                            vFCPSTRet = "0.00",
                            vIPIDevol = "0.00",
                        }
                    },
                    pag = new TNFeInfNFePag
                    {
                        vTroco = "0.00",
                        detPag = new List<TNFeInfNFePagDetPag>
                        {
                            new TNFeInfNFePagDetPag
                            {
                                tPag = TNFeInfNFePagDetPagTPag.Dinheiro,
                                vPag = "3000.00"
                            }
                        }
                    },
                    transp = new TNFeInfNFeTransp
                    {
                        modFrete = TNFeInfNFeTranspModFrete.SemTransporte
                    }
                }
            };
        }
    }
}

