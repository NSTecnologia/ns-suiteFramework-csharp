using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.CTe;

namespace NSSuiteClientCSharp.src.Layout.CTe
{
    class LayoutCTe
    {
        public static string gerarLayoutCTeXML()
        {

            TCTe CTe = new TCTe
            {
                infCte = new TCTeInfCte
                {
                    versao = "3.00",
                    ide = new TCTeInfCteIde
                    {
                        cUF = TCodUfIBGE.Item43,
                        cCT = "00000330",
                        CFOP = "5353",
                        natOp = "PRESTACAO TRANSPORTE A ESTABELECIMENTO COMERCIAL",
                        mod = TModCT.Item57,
                        serie = "0",
                        nCT = "2229",
                        dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        tpImp = TCTeInfCteIdeTpImp.Item2,
                        tpEmis = TCTeInfCteIdeTpEmis.Item1,
                        cDV = "",
                        tpAmb = TAmb.Item2,
                        tpCTe = TFinCTe.Item0,
                        procEmi = TProcEmi.Item0,
                        verProc = "1.02",
                        cMunEnv = "4303509",
                        xMunEnv = "CAMAQUA",
                        UFEnv = TUf.RS,
                        modal = TModTransp.Item01,
                        tpServ = TCTeInfCteIdeTpServ.Item0,
                        cMunIni = "4303509",
                        xMunIni = "CAMAQUA",
                        UFIni = TUf.RS,
                        cMunFim = "4303509",
                        xMunFim = "CAMAQUA",
                        UFFim = TUf.RS,
                        retira = TCTeInfCteIdeRetira.Item1,
                        indIEToma = TCTeInfCteIdeIndIEToma.Item9,
                        Item = new TCTeInfCteIdeToma3
                        {
                            toma = TCTeInfCteIdeToma3Toma.Item3
                        }
                    },
                    emit = new TCTeInfCteEmit
                    {
                        ItemElementName =  ItemChoiceType1.CNPJ,
                        Item = "07364617000135",
                        IE = "0170108708",
                        xNome = "NEWS SYSTEMS LTDA",
                        xFant = "TESTE DE EMISSÃO",
                        enderEmit = new TEndeEmi
                        {
                            xLgr = "ROD RST 470 KM 221 BLOCO A",
                            nro = "221",
                            xBairro = "CAMAQUA",
                            cMun = "4303509",
                            xMun = "GARIBALDI",
                            CEP = "96180000",
                            UF = TUF_sem_EX.RS,
                            fone = "5434638266",
                        }
                    },
                    rem = new TCTeInfCteRem
                    {
                        ItemElementName = ItemChoiceType2.CNPJ,
                        Item = "07364617000135",
                        IE = "0170108708",
                        xNome = "CT-E EMITIDO EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderReme = new TEndereco
                        {
                            xLgr = "FAZENDA",
                            nro = "S/N",
                            xBairro = "ZONA RURAL",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf.RS,
                            cPais = "1058",
                            xPais = "BRASIL",
                        }
                    },
                    dest = new TCTeInfCteDest
                    {
                        ItemElementName = ItemChoiceType5.CNPJ,
                        Item = "07364617000135",
                        xNome = "CT-E EMITIDO EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                        enderDest = new TEndereco
                        {
                            xLgr = "FAZENDA",
                            nro = "S/N",
                            xBairro = "ZONA RURAL",
                            cMun = "4303509",
                            xMun = "CAMAQUA",
                            UF = TUf.RS,
                            cPais = "1058",
                            xPais = "BRASIL",
                        }
                    },
                    vPrest = new TCTeInfCteVPrest
                    {
                        vTPrest = "300.00",
                        vRec = "300.00",
                    },
                    imp = new TCTeInfCteImp
                    {
                        infAdFisco = "TESTE DE EMISSAO XSD",
                        vTotTrib = "546.00",
                        ICMS = new TImp
                        {
                            Item = new TImpICMS60
                            {
                                CST = TImpICMS60CST.Item60,
                                vBCSTRet = "4550.00",
                                vICMSSTRet = "546.00",
						        pICMSSTRet = "12.00"
                            }
                        }
                    },
                    Item = new TCTeInfCteInfCTeNorm
                    {
                        infCarga = new TCTeInfCteInfCTeNormInfCarga
                        {
                            vCarga = "39000.00",
					        proPred = "CENOURA",
                            xOutCat = "CX",
                            vCargaAverb = "39000.00",
                            infQ = new TCTeInfCteInfCTeNormInfCargaInfQ[2]
                            {
                                new TCTeInfCteInfCTeNormInfCargaInfQ
                                {
                                    cUnid = TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item03,
                                    tpMed = "CX",
                                    qCarga = "650.0000"

                                },
                                new TCTeInfCteInfCTeNormInfCargaInfQ
                                {
                                    cUnid = TCTeInfCteInfCTeNormInfCargaInfQCUnid.Item01,
                                    tpMed = "KILOS",
                                    qCarga = "13000.0000"
                                }
                            }
                        },
                        infDoc = new TCTeInfCteInfCTeNormInfDoc
                        {
                            Items = new TCTeInfCteInfCTeNormInfDocInfNF[1]
                            {
                                new TCTeInfCteInfCTeNormInfDocInfNF
                                {
                                    mod = TModNF.Item04,
							        serie = "0",
							        nDoc = "2",
							        dEmi = DateTime.Now.ToString("yyyy-MM-dd"),
							        vBC = "39000.00",
							        vICMS = "0.00",
							        vBCST = "0.00",
							        vST = "0.00",
							        vProd = "39000.00",
							        vNF = "39000.00",
							        nCFOP = "6101",
							        nPeso = "650.000",
                                }
                            }
                        },
                        infModal = new TCTeInfCteInfCTeNormInfModal
                        {
                            versaoModal = "3.00",
                            rodo = new TCTeRodo
                            {
                                RNTRC = "09549369"
                            }
                        }
                    },
                }
            };

            string CTeXML = cteToXML(CTe);
            return CTeXML;
        }

        private static string cteToXML(TCTe CTe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(CTe.GetType());
                serializer.Serialize(stringwriter, CTe);
                return stringwriter.ToString();
            }
        }
    }
}
