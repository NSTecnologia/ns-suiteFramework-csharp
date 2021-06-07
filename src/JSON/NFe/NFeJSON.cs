using System.Collections.Generic;

namespace NSSuite_CSharp.src.JSON.NFe
{
    class NFeJSON
    {
        public Nfe NFe { get; set; }
    }

    public class Nfe
    {
        public Infnfe infNFe { get; set; }
    }

    public class Infnfe
    {
        public string versao { get; set; }
        public Ide ide { get; set; }
        public Emit emit { get; set; }
        public Dest dest { get; set; }
        public Retirada retirada { get; set; }
        public Entrega entrega { get; set; }
        public List<Autxml> autXML { get; set; }
        public List<Det> det { get; set; }
        public Total total { get; set; }
        public Transp transp { get; set; }
        public Cobr cobr { get; set; }
        public Pag pag { get; set; }
        public InfIntermed infIntermed { get; set; }
        public Infadic infAdic { get; set; }
	public InfSolicNFF infSolicNFF { get; set; }
        public Exporta exporta { get; set; }
        public Compra compra { get; set; }
        public Cana cana { get; set; }
	public InfRespTec infRespTec { get; set; }
    }

    public class Ide
    {
        public string cUF { get; set; }
        public string cNF { get; set; }
        public string natOp { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nNF { get; set; }
        public string dhEmi { get; set; }
        public string dhSaiEnt { get; set; }
        public string tpNF { get; set; }
        public string idDest { get; set; }
        public string cMunFG { get; set; }
        public string tpImp { get; set; }
        public string tpEmis { get; set; }
        public string cDV { get; set; }
        public string tpAmb { get; set; }
        public string finNFe { get; set; }
        public string indFinal { get; set; }
        public string indPres { get; set; }
        public string indIntermed { get; set; }
        public string procEmi { get; set; }
        public string verProc { get; set; }
        public string dhCont { get; set; }
        public string xJust { get; set; }
        public List<Nfref> NFref { get; set; }
    }

    public class Nfref
    {
        public string refNFe { get; set; }
        public Refnf refNF { get; set; }
        public Refnfp refNFP { get; set; }
        public Refecf refECF { get; set; }
    }

    public class Refnf
    {
        public string cUF { get; set; }
        public string AAMM { get; set; }
        public string CNPJ { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nNF { get; set; }
    }

    public class Refnfp
    {
        public string cUF { get; set; }
        public string AAMM { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string IE { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nNF { get; set; }
        public string refCTe { get; set; }
    }

    public class Refecf
    {
        public string mod { get; set; }
        public string nECF { get; set; }
        public string nCOO { get; set; }
    }

    public class Emit
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string xNome { get; set; }
        public string xFant { get; set; }
        public Enderemit enderEmit { get; set; }
        public string IE { get; set; }
        public string IEST { get; set; }
        public string IM { get; set; }
        public string CNAE { get; set; }
        public string CRT { get; set; }
    }

    public class Enderemit
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xCpl { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string cPais { get; set; }
        public string xPais { get; set; }
        public string fone { get; set; }
    }

    public class Dest
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string idEstrangeiro { get; set; }
        public string xNome { get; set; }
        public Enderdest enderDest { get; set; }
        public string indIEDest { get; set; }
        public string IE { get; set; }
        public string ISUF { get; set; }
        public string IM { get; set; }
        public string email { get; set; }
    }

    public class Enderdest
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xCpl { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string cPais { get; set; }
        public string xPais { get; set; }
        public string fone { get; set; }
    }

    public class Retirada
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xCpl { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
    }

    public class Entrega
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xCpl { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
    }

    public class Total
    {
        public Icmstot ICMSTot { get; set; }
        public Issqntot ISSQNtot { get; set; }
        public Rettrib retTrib { get; set; }
    }

    public class Icmstot
    {
        public string vBC { get; set; }
        public string vICMS { get; set; }
        public string vICMSDeson { get; set; }
        public string vFCP { get; set; }
        public string vFCPUFDest { get; set; }
        public string vICMSUFDest { get; set; }
        public string vICMSUFRemet { get; set; }
        public string vBCST { get; set; }
        public string vST { get; set; }
        public string vFCPST { get; set; }
        public string vFCPSTRet { get; set; }
        public string vProd { get; set; }
        public string vFrete { get; set; }
        public string vSeg { get; set; }
        public string vDesc { get; set; }
        public string vII { get; set; }
        public string vIPI { get; set; }
        public string vIPIDevol { get; set; }
        public string vPIS { get; set; }
        public string vCOFINS { get; set; }
        public string vOutro { get; set; }
        public string vNF { get; set; }
        public string vTotTrib { get; set; }
    }

    public class Issqntot
    {
        public string vServ { get; set; }
        public string vBC { get; set; }
        public string vISS { get; set; }
        public string vPIS { get; set; }
        public string vCOFINS { get; set; }
        public string dCompet { get; set; }
        public string vDeducao { get; set; }
        public string vOutro { get; set; }
        public string vDescIncond { get; set; }
        public string vDescCond { get; set; }
        public string vISSRet { get; set; }
        public string cRegTrib { get; set; }
    }

    public class Rettrib
    {
        public string vRetPIS { get; set; }
        public string vRetCOFINS { get; set; }
        public string vRetCSLL { get; set; }
        public string vBCIRRF { get; set; }
        public string vIRRF { get; set; }
        public string vBCRetPrev { get; set; }
        public string vRetPrev { get; set; }
    }

    public class Transp
    {
        public string modFrete { get; set; }
        public Transporta transporta { get; set; }
        public Rettransp retTransp { get; set; }
        public Veictransp veicTransp { get; set; }
        public List<Reboque> reboque { get; set; }
        public string vagao { get; set; }
        public string balsa { get; set; }
        public List<Vol> vol { get; set; }
    }

    public class Transporta
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string xNome { get; set; }
        public string IE { get; set; }
        public string xEnder { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
    }

    public class Rettransp
    {
        public string vServ { get; set; }
        public string vBCRet { get; set; }
        public string pICMSRet { get; set; }
        public string vICMSRet { get; set; }
        public string CFOP { get; set; }
        public string cMunFG { get; set; }
    }

    public class Veictransp
    {
        public string placa { get; set; }
        public string UF { get; set; }
        public string RNTC { get; set; }
    }

    public class Reboque
    {
        public string placa { get; set; }
        public string UF { get; set; }
        public string RNTC { get; set; }
    }

    public class Vol
    {
        public string qVol { get; set; }
        public string esp { get; set; }
        public string marca { get; set; }
        public string nVol { get; set; }
        public string pesoL { get; set; }
        public string pesoB { get; set; }
        public List<Lacre> lacres { get; set; }
    }

    public class Lacre
    {
        public string nLacre { get; set; }
    }

    public class Cobr
    {
        public Fat fat { get; set; }
        public List<Dup> dup { get; set; }
    }

    public class Fat
    {
        public string nFat { get; set; }
        public string vOrig { get; set; }
        public string vDesc { get; set; }
        public string vLiq { get; set; }
    }

    public class Dup
    {
        public string nDup { get; set; }
        public string dVenc { get; set; }
        public string vDup { get; set; }
    }

    public class Pag
    {
        public List<Detpag> detPag { get; set; }
        public string vTroco { get; set; }
    }

    public class Detpag
    {
        public string tPag { get; set; }
        public string vPag { get; set; }
        public Card card { get; set; }
	public string indPag { get; set; }
	public string xPag { get; set; }
    }

    public class Card
    {
        public string CNPJ { get; set; }
        public string tBand { get; set; }
        public string cAut { get; set; }
        public string tpIntegra { get; set; }
    }
    
    public class InfIntermed
    {
        public string CNPJ { get; set; }
        public string idCadIntTran { get; set; }
    }

    public class Infadic
    {
        public string infAdFisco { get; set; }
        public string infCpl { get; set; }
        public List<Obscont> obsCont { get; set; }
        public List<Obsfisco> obsFisco { get; set; }
        public List<Procref> procRef { get; set; }
    }

    public class InfRespTec
    {
	public string CNPJ { get; set; }
	public string xContato { get; set; }
	public string email { get; set; }
	public string fone { get; set; }
	public string idCSRT { get; set; }
	public string hashCSRT { get; set; }
    }

    public class InfSolicNFF
    {
    	public string xSolic { get; set; }
    }

    public class Obscont
    {
        public string xCampo { get; set; }
        public string xTexto { get; set; }
    }

    public class Obsfisco
    {
        public string xCampo { get; set; }
        public string xTexto { get; set; }
    }

    public class Procref
    {
        public string nProc { get; set; }
        public string indProc { get; set; }
    }

    public class Exporta
    {
        public string UFSaidaPais { get; set; }
        public string xLocExporta { get; set; }
        public string xLocDespacho { get; set; }
    }

    public class Compra
    {
        public string xNEmp { get; set; }
        public string xPed { get; set; }
        public string xCont { get; set; }
    }

    public class Cana
    {
        public string safra { get; set; }
        public string @ref { get; set; }
        public List<Fordia> forDia { get; set; }
        public List<Deduc> deduc { get; set; }
    }

    public class Fordia
    {
        public string dia { get; set; }
        public string qtde { get; set; }
        public string qTotMes { get; set; }
        public string qTotAnt { get; set; }
        public string qTotGer { get; set; }
    }

    public class Deduc
    {
        public string xDed { get; set; }
        public string vDed { get; set; }
        public string vFor { get; set; }
        public string vTotDed { get; set; }
        public string vLiqFor { get; set; }
    }

    public class Autxml
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
    }

    public class Det
    {
        public Prod prod { get; set; }
        public Imposto imposto { get; set; }
        public Impostodevol impostoDevol { get; set; }
        public string infAdProd { get; set; }
        public string nItem { get; set; }
    }

    public class Prod
    {
        public string cProd { get; set; }
        public string cEAN { get; set; }
        public string xProd { get; set; }
        public string NCM { get; set; }
        public string NVE { get; set; }
        public string CEST { get; set; }
        public string indEscala { get; set; }
        public string CNPJFab { get; set; }
        public string cBenef { get; set; }
        public string EXTIPI { get; set; }
        public string CFOP { get; set; }
        public string uCom { get; set; }
        public string qCom { get; set; }
        public string vUnCom { get; set; }
        public string vProd { get; set; }
        public string cEANTrib { get; set; }
        public string uTrib { get; set; }
        public string qTrib { get; set; }
        public string vUnTrib { get; set; }
        public string vFrete { get; set; }
        public string vSeg { get; set; }
        public string vDesc { get; set; }
        public string vOutro { get; set; }
        public string indTot { get; set; }
        public List<Rastro> rastro { get; set; }
        public List<DI> DI { get; set; }
        public List<Detexport> detExport { get; set; }
        public string xPed { get; set; }
        public string nItemPed { get; set; }
        public string nFCI { get; set; }
        public Veicprod veicProd { get; set; }
        public Med med { get; set; }
        public List<Arma> arma { get; set; }
        public Comb comb { get; set; }
        public string nRECOPI { get; set; }
	public InfProdNFF infProdNFF { get; set; }
	public InfProdEmb infProdEmb { get; set; }
    }

    public class Veicprod
    {
        public string tpOp { get; set; }
        public string chassi { get; set; }
        public string cCor { get; set; }
        public string xCor { get; set; }
        public string pot { get; set; }
        public string cilin { get; set; }
        public string pesoL { get; set; }
        public string pesoB { get; set; }
        public string nSerie { get; set; }
        public string tpComb { get; set; }
        public string nMotor { get; set; }
        public string CMT { get; set; }
        public string dist { get; set; }
        public string anoMod { get; set; }
        public string anoFab { get; set; }
        public string tpPint { get; set; }
        public string tpVeic { get; set; }
        public string espVeic { get; set; }
        public string VIN { get; set; }
        public string condVeic { get; set; }
        public string cMod { get; set; }
        public string cCorDENATRAN { get; set; }
        public string lota { get; set; }
        public string tpRest { get; set; }
    }

    public class Med
    {
        public string cProdANVISA { get; set; }
        public string vPMC { get; set; }
    }

    public class Comb
    {
        public string cProdANP { get; set; }
        public string descANP { get; set; }
        public string pGLP { get; set; }
        public string pGNn { get; set; }
        public string pGNi { get; set; }
        public string vPart { get; set; }
        public string CODIF { get; set; }
        public string qTemp { get; set; }
        public string UFCons { get; set; }
        public CIDE CIDE { get; set; }
        public Encerrante encerrante { get; set; }
    }

    public class InfProdNFF
    {
    	public string cProdFisco { get; set; }
	public string cOperNFF { get; set; }
    }

    public class InfProdEmb
    {
    	public string xEmb { get; set; }
	public string qVolEmb { get; set; }
	public string uEmb { get; set; }
    }

    public class CIDE
    {
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vCIDE { get; set; }
    }

    public class Encerrante
    {
        public string nBico { get; set; }
        public string nBomba { get; set; }
        public string nTanque { get; set; }
        public string vEncIni { get; set; }
        public string vEncFin { get; set; }
    }

    public class Rastro
    {
        public string nLote { get; set; }
        public string qLote { get; set; }
        public string dFab { get; set; }
        public string dVal { get; set; }
        public string cAgreg { get; set; }
    }

    public class DI
    {
        public string nDI { get; set; }
        public string dDI { get; set; }
        public string xLocDesemb { get; set; }
        public string UFDesemb { get; set; }
        public string dDesemb { get; set; }
        public string tpViaTransp { get; set; }
        public string vAFRMM { get; set; }
        public string tpIntermedio { get; set; }
        public string CNPJ { get; set; }
        public string UFTerceiro { get; set; }
        public string cExportador { get; set; }
        public Adi adi { get; set; }
    }

    public class Adi
    {
        public string nAdicao { get; set; }
        public string nSeqAdic { get; set; }
        public string cFabricante { get; set; }
        public string vDescDI { get; set; }
        public string nDraw { get; set; }
    }

    public class Detexport
    {
        public string nDraw { get; set; }
        public Exportind exportInd { get; set; }
    }

    public class Exportind
    {
        public string nRE { get; set; }
        public string chNFe { get; set; }
        public string qExport { get; set; }
    }

    public class Arma
    {
        public string tpArma { get; set; }
        public string nSerie { get; set; }
        public string nCano { get; set; }
        public string descr { get; set; }
    }

    public class Imposto
    {
        public string vTotTrib { get; set; }
        public ICMS ICMS { get; set; }
        public IPI IPI { get; set; }
        public II II { get; set; }
        public PIS PIS { get; set; }
        public PISST PISST { get; set; }
        public COFINS COFINS { get; set; }
        public COFINSST COFINSST { get; set; }
        public ISSQN ISSQN { get; set; }
    }

    public class ICMS
    {
        public ICMS00 ICMS00 { get; set; }
        public ICMS10 ICMS10 { get; set; }
        public ICMS20 ICMS20 { get; set; }
        public ICMS30 ICMS30 { get; set; }
        public ICMS40 ICMS40 { get; set; }
        public ICMS51 ICMS51 { get; set; }
        public ICMS60 ICMS60 { get; set; }
        public ICMS70 ICMS70 { get; set; }
        public ICMS90 ICMS90 { get; set; }
        public Icmspart ICMSPart { get; set; }
        public ICMSST ICMSST { get; set; }
        public ICMSSN101 ICMSSN101 { get; set; }
        public ICMSSN102 ICMSSN102 { get; set; }
        public ICMSSN201 ICMSSN201 { get; set; }
        public ICMSSN202 ICMSSN202 { get; set; }
        public ICMSSN500 ICMSSN500 { get; set; }
        public ICMSSN900 ICMSSN900 { get; set; }
        //public Icmsufdest ICMSUFDest { get; set; }
    }

    public class ICMS00
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string pFCP { get; set; }
        public string vFCP { get; set; }
    }

    public class ICMS10
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string vBCFCP { get; set; }
        public string pFCP { get; set; }
        public string vFCP { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
    }

    public class ICMS20
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string pRedBC { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string vBCFCP { get; set; }
        public string pFCP { get; set; }
        public string vFCP { get; set; }
        public string vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS30
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
        public string vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS40
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS51
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string pRedBC { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMSOp { get; set; }
        public string pDif { get; set; }
        public string vICMSDif { get; set; }
        public string vICMS { get; set; }
        public string vBCFCP { get; set; }
        public string pFCP { get; set; }
        public string vFCP { get; set; }
    }

    public class ICMS60
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string vBCSTRet { get; set; }
        public string pST { get; set; }
        public string vICMSSTRet { get; set; }
        public string vBCFCPSTRet { get; set; }
        public string pFCPSTRet { get; set; }
        public string vFCPSTRet { get; set; }
    }

    public class ICMS70
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string pRedBC { get; set; }
        public string vBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string vBCFCP { get; set; }
        public string pFCP { get; set; }
        public string vFCP { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
        public string vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS90
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string vBC { get; set; }
        public string pRedBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string vBCFCP { get; set; }
        public string pFCP { get; set; }
        public string vFCP { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
        public string vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class Icmspart
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public string vBC { get; set; }
        public string pRedBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string pBCOp { get; set; }
        public string UFST { get; set; }
    }

    public class ICMSST
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string vBCSTRet { get; set; }
        public string vICMSSTRet { get; set; }
        public string vBCSTDest { get; set; }
        public string vICMSSTDest { get; set; }
    }

    public class ICMSSN101
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
        public string pCredSN { get; set; }
        public string vCredICMSSN { get; set; }
    }

    public class ICMSSN102
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
    }

    public class ICMSSN201
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
        public string pCredSN { get; set; }
        public string vCredICMSSN { get; set; }
    }

    public class ICMSSN202
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
    }

    public class ICMSSN500
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
        public string vBCSTRet { get; set; }
        public string pST { get; set; }
        public string vICMSSTRet { get; set; }
        public string vBCFCPSTRet { get; set; }
        public string pFCPSTRet { get; set; }
        public string vFCPSTRet { get; set; }
    }

    public class ICMSSN900
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
        public string modBC { get; set; }
        public string vBC { get; set; }
        public string pRedBC { get; set; }
        public string pICMS { get; set; }
        public string vICMS { get; set; }
        public string modBCST { get; set; }
        public string pMVAST { get; set; }
        public string pRedBCST { get; set; }
        public string vBCST { get; set; }
        public string pICMSST { get; set; }
        public string vICMSST { get; set; }
        public string vBCFCPST { get; set; }
        public string pFCPST { get; set; }
        public string vFCPST { get; set; }
        public string pCredSN { get; set; }
        public string vCredICMSSN { get; set; }
    }

    /* 

    public class Icmsufdest
     {
         public string vBCUFDest { get; set; }
         public string vBCFCPUFDest { get; set; }
         public string pFCPUFDest { get; set; }
         public string pICMSUFDest { get; set; }
         public string pICMSInter { get; set; }
         public string pICMSInterPart { get; set; }
         public string vFCPUFDest { get; set; }
         public string vICMSUFDest { get; set; }
         public string vICMSUFRemet { get; set; }
     }

     */

    public class IPI
    {
        //public string clEnq { get; set; }
        public string CNPJProd { get; set; }
        public string cSelo { get; set; }
        public string qSelo { get; set; }
        public string cEnq { get; set; }
        public Ipitrib IPITrib { get; set; }
        public IPINT IPINT { get; set; }
    }

    public class Ipitrib
    {
        public string CST { get; set; }
        public string vBC { get; set; }
        public string pIPI { get; set; }
        public string qUnid { get; set; }
        public string vUnid { get; set; }
        public string vIPI { get; set; }
    }

    public class IPINT
    {
        public string CST { get; set; }
    }

    public class II
    {
        public string vBC { get; set; }
        public string vDespAdu { get; set; }
        public string vII { get; set; }
        public string vIOF { get; set; }
    }

    public class PIS
    {
        public Pisaliq PISAliq { get; set; }
        public Pisqtde PISQtde { get; set; }
        public PISNT PISNT { get; set; }
        public Pisoutr PISOutr { get; set; }
    }

    public class Pisaliq
    {
        public string CST { get; set; }
        public string vBC { get; set; }
        public string pPIS { get; set; }
        public string vPIS { get; set; }
    }

    public class Pisqtde
    {
        public string CST { get; set; }
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vPIS { get; set; }
    }

    public class PISNT
    {
        public string CST { get; set; }
    }

    public class Pisoutr
    {
        public string CST { get; set; }
        public string vBC { get; set; }
        public string pPIS { get; set; }
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vPIS { get; set; }
    }

    public class PISST
    {
        public string vBC { get; set; }
        public string pPIS { get; set; }
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vPIS { get; set; }
    }

    public class COFINS
    {
        public Cofinsaliq COFINSAliq { get; set; }
        public Cofinsqtde COFINSQtde { get; set; }
        public COFINSNT COFINSNT { get; set; }
        public Cofinsoutr COFINSOutr { get; set; }
    }

    public class Cofinsaliq
    {
        public string CST { get; set; }
        public string vBC { get; set; }
        public string pCOFINS { get; set; }
        public string vCOFINS { get; set; }
    }

    public class Cofinsqtde
    {
        public string CST { get; set; }
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vCOFINS { get; set; }
    }

    public class COFINSNT
    {
        public string CST { get; set; }
    }

    public class Cofinsoutr
    {
        public string CST { get; set; }
        public string vBC { get; set; }
        public string pCOFINS { get; set; }
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vCOFINS { get; set; }
    }

    public class COFINSST
    {
        public string vBC { get; set; }
        public string pCOFINS { get; set; }
        public string qBCProd { get; set; }
        public string vAliqProd { get; set; }
        public string vCOFINS { get; set; }
    }

    public class ISSQN
    {
        public string vBC { get; set; }
        public string vAliq { get; set; }
        public string vISSQN { get; set; }
        public string cMunFG { get; set; }
        public string cListServ { get; set; }
        public string vDeducao { get; set; }
        public string vOutro { get; set; }
        public string vDescIncond { get; set; }
        public string vDescCond { get; set; }
        public string vISSRet { get; set; }
        public string indISS { get; set; }
        public string cServico { get; set; }
        public string cMun { get; set; }
        public string cPais { get; set; }
        public string nProcesso { get; set; }
        public string indIncentivo { get; set; }
    }

    public class Impostodevol
    {
        public string pDevol { get; set; }
        public IPI1 IPI { get; set; }
    }

    public class IPI1
    {
        public string vIPIDevol { get; set; }
    }
    
}
