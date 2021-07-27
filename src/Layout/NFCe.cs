using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.NFCe;

namespace NSSuiteClientCSharp.src.Layout.NFCe
{
    class LayoutNFCe
    {
        public static string gerarLayoutNFCeXML()
        {
            TNFCe NFCe = new TNFCe
            {
                infNFe = new TNFeInfNFe
                {
                    versao = "4.00",
                    ide = new TNFeInfNFeIde
                    {
                        cUF = TCodUfIBGE.Item43,
                        natOp = "VENDA A PRAZO - SEM VALOR FISCAL",
                        mod = TMod.Item65,
                        serie = "0",
                        nNF = "",
                        dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        tpNF = TNFeInfNFeIdeTpNF.Item1,
                        idDest = TNFeInfNFeIdeIdDest.Item1,
                        cMunFG = "4305108",
                        tpImp = TNFeInfNFeIdeTpImp.Item4,
                        tpEmis = TNFeInfNFeIdeTpEmis.Item1,
                        tpAmb = TAmb.Item2,
                        finNFe = TFinNFe.Item1,
                        indFinal = TNFeInfNFeIdeIndFinal.Item1,
                        indPres = TNFeInfNFeIdeIndPres.Item1,
                        procEmi = TProcEmi.Item0,
                        verProc = "4.00"
                    },
                    emit = new TNFeInfNFeEmit
                    {
                        ItemElementName = ItemChoiceType2.CNPJ,
                        Item = "07364617000135",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        IE = "0170108708",
                        CRT = TNFeInfNFeEmitCRT.Item1,
                        enderEmit = new TEnderEmi
                        {
                            xLgr = "Rua Bento Osvaldo Trisch",
                            nro = "777",
                            xCpl = "CX POSTAL 91",
                            xBairro = "Pendancino",
                            cMun = "4303509",
                            xMun = "Caxias do Sul",
                            UF = TUfEmi.RS,
                            CEP = "95046600",
                            fone = "005432200200"
                        }
                    },
                    dest = new TNFeInfNFeDest
                    {
                        ItemElementName = ItemChoiceType3.CPF,
                        Item = "16313945093",
                        xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        indIEDest = TNFeInfNFeDestIndIEDest.Item9,
                        enderDest = new TEndereco
                        {
                            xLgr = "Rua 1",
                            nro = "0",
                            xBairro = "Setor Sul",
                            cMun = "5208707",
                            xMun = "Goiânia",
                            UF = TUf.GO,
                            CEP = "74650000",
                            cPais = "1058",
                            xPais = "Brasil"
                        }
                    },
                    det = new TNFeInfNFeDet[1]
                                {
                    new TNFeInfNFeDet
                    {
                        nItem = "1",
                        prod = new TNFeInfNFeDetProd
                        {
                            cEAN = "SEM GTIN",
                            cEANTrib = "SEM GTIN",
                            cProd = "123456789",
                            xProd = "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                            NCM = "22021000",
                            CEST = "0301100",
                            CFOP = "5101",
                            uCom = "UN",
                            qCom = "1.0000",
                            vUnCom = "3.00",
                            vProd = "3.00",
                            uTrib = "UN",
                            qTrib = "1.0000",
                            vUnTrib = "3.00",
                            indTot = TNFeInfNFeDetProdIndTot.Item1,
                            nItemPed = "0"
                        },
                        imposto = new TNFeInfNFeDetImposto
                        {
                            Items = new TNFeInfNFeDetImpostoICMS[1]
                            {
                                new TNFeInfNFeDetImpostoICMS
                                {
                                    Item = new TNFeInfNFeDetImpostoICMSICMSSN102
                                    {
                                        CSOSN = TNFeInfNFeDetImpostoICMSICMSSN102CSOSN.Item102,
                                        orig = Torig.Item0
                                    }
                                }
                            },
                            PIS = new TNFeInfNFeDetImpostoPIS
                            {
                                Item = new TNFeInfNFeDetImpostoPISPISAliq
                                {
                                    CST = TNFeInfNFeDetImpostoPISPISAliqCST.Item01,
                                    vBC = "3.00",
                                    pPIS = "1.65",
                                    vPIS = "0.05"
                                }
                            },

                            COFINS = new TNFeInfNFeDetImpostoCOFINS
                            {
                                Item = new TNFeInfNFeDetImpostoCOFINSCOFINSAliq
                                {
                                    CST = TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.Item01,
                                    vBC = "3.00",
                                    pCOFINS = "7.00",
                                    vCOFINS = "0.21"
                                }
                            },

                        }
                    }
                                },
                    total = new TNFeInfNFeTotal
                    {
                        ICMSTot = new TNFeInfNFeTotalICMSTot
                        {
                            vBC = "0",
                            vICMS = "0",
                            vICMSDeson = "0.00",
                            vFCPUFDest = "0.00",
                            vICMSUFDest = "0.00",
                            vICMSUFRemet = "0.00",
                            vFCP = "0",
                            vBCST = "0",
                            vST = "0",
                            vFCPST = "0",
                            vFCPSTRet = "0.00",
                            vProd = "3.00",
                            vFrete = "0.00",
                            vSeg = "0.00",
                            vDesc = "0.00",
                            vII = "0.00",
                            vIPI = "0.00",
                            vIPIDevol = "0.00",
                            vPIS = "0.05",
                            vCOFINS = "0.21",
                            vOutro = "0.00",
                            vNF = "3.00",
                            vTotTrib = "0.00"
                        }
                    },
                    transp = new TNFeInfNFeTransp
                    {
                        modFrete = TNFeInfNFeTranspModFrete.Item9
                    },
                    pag = new TNFeInfNFePag
                    {
                        detPag = new TNFeInfNFePagDetPag[1]
                                    {
                        new TNFeInfNFePagDetPag
                        {
                            tPag = TNFeInfNFePagDetPagTPag.Item01,
                            vPag = "5.00"
                        }
                                    },
                        vTroco = "2.00"
                    },
                    infAdic = new TNFeInfNFeInfAdic
                    {
                        infCpl = "TESTE DE EMISSAO EM CONTINGENCIA"
                    }
                }
            };

            string NFCeXML = nfceToXML(NFCe);
            return NFCeXML;
        }

        private static string nfceToXML(TNFCe NFCe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(NFCe.GetType());
                serializer.Serialize(stringwriter, NFCe);
                return stringwriter.ToString();
            }
        }
    }
}
