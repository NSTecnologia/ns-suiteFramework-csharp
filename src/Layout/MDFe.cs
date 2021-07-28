using System;
using System.IO;
using System.Xml.Serialization;
using NSSuiteClientCSharp.src.Classes.MDFe;

namespace NSSuiteClientCSharp.src.Layout.MDFe
{
    class LayoutMDFe
    {
        public static string gerarLayoutMDFeXML()
        {
            TMDFe MDFe = new TMDFe
            {
                infMDFe = new TMDFeInfMDFe
                {
                    versao = "3.00",
                    Id = "MDFe",
                    ide = new TMDFeInfMDFeIde
                    {
                        cUF = TCodUfIBGE.Item43,
                        tpAmb = TAmb.Item2,
                        tpEmit = TEmit.Item2,
				        tpTransp = TTransp.TAC,
				        mod = TModMD.Item58,
				        serie = "1",
				        nMDF = "11676",
				        cMDF = "",
				        cDV = "",
				        modal = TModalMD.Item1,
				        dhEmi = DateTime.Now.ToString("s") + "-03:00",
                        tpEmis = TMDFeInfMDFeIdeTpEmis.Item1,
				        procEmi = TMDFeInfMDFeIdeProcEmi.Item0,
				        verProc = "5.7",
				        UFIni = TUf.RS,
				        UFFim = TUf.RS,
                        infMunCarrega = new TMDFeInfMDFeIdeInfMunCarrega[1]
                        {
                            new TMDFeInfMDFeIdeInfMunCarrega 
                            {
                                cMunCarrega = "4303509",
                                xMunCarrega = "CAMAQUA"
                            }
                        },
                        dhIniViagem = DateTime.Now.ToString("s") + "-03:00",
                    },
                    emit = new TMDFeInfMDFeEmit
                    {
                        ItemElementName = ItemChoiceType.CNPJ,
                        Item = "07364617000135",
                        xNome = "EMISSAO TESTE MDFE",
                        xFant = "NSTECNOLOGIA TESTE EMISSAO",
                        enderEmit = new TEndeEmi
                        {
                            xLgr = "AV ANTONIO DURO",
					        nro = "777",
					        xCpl = "CASA FRENTE",
					        xBairro = "OLARIA",
					        cMun = "4303509",
					        xMun = "Camaqua",
					        CEP = "96180000",
					        UF = TUf.RS,
					        fone = "5136921123",
                        },
                    },
                    infDoc = new TMDFeInfMDFeInfMunDescarga[1]
                    {
                        new TMDFeInfMDFeInfMunDescarga
                        {
                            cMunDescarga = "4303509",
                            xMunDescarga = "CAMAQUA",
                            infNFe = new TMDFeInfMDFeInfMunDescargaInfNFe[1]
                            {
                                new TMDFeInfMDFeInfMunDescargaInfNFe
                                {
                                    chNFe = "43210707364617000135550000000228161415472576",
                                }
                            }
                        }
                    },
                    tot = new TMDFeInfMDFeTot
                    {
                        qCTe = "0",
                        qNFe = "1",
                        qMDFe = "0",
                        vCarga = "3.00",
                        cUnid = TMDFeInfMDFeTotCUnid.Item01,
                        qCarga = "10.0000",
                    },
                    prodPred = new TMDFeInfMDFeProdPred
                    {
                        tpCarga = TMDFeInfMDFeProdPredTpCarga.Item05,

                    }
                }
            };

            string MDFeXML = mdfeToXML(MDFe);

            return MDFeXML;

        }
        private static string mdfeToXML(TMDFe MDFe)
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(MDFe.GetType());
                serializer.Serialize(stringwriter, MDFe);
                return stringwriter.ToString();
            }
        }
    }
}
