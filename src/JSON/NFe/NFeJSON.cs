using System.Collections.Generic;

namespace NSSuite_CSharp.src.JSON.NFe
{
	public class NFeJSON
	{
		public NFe NFe { get; set; }
	}

	// --- Classes de Referência ---

	public class RefNF
	{
		public string cUF { get; set; }
		public string AAMM { get; set; }
		public string CNPJ { get; set; }
		public string mod { get; set; }
		public string serie { get; set; }
		public string nNF { get; set; }
	}

	public class RefNFP
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

	public class RefECF
	{
		public string mod { get; set; }
		public string nECF { get; set; }
		public string nCOO { get; set; }
	}

	public class NFref
	{
		public string refNFe { get; set; }
		public RefNF refNF { get; set; }
		public string refNFeSig { get; set; }
		public RefNFP refNFP { get; set; }
		public RefECF refECF { get; set; }
	}

	// --- Identificação ---

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
		public List<NFref> NFref { get; set; }
		// Campos novos
		public string cMunFGIBS { get; set; }
		public string tpNFDebito { get; set; }
		public string tpNFCredito { get; set; }
		public string dPrevEntrega { get; set; }
		public gCompraGov gCompraGov { get; set; }
		public gPagAntecipado gPagAntecipado { get; set; }
	}

	// --- Emitente e Destinatário ---

	public class EnderEmit
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

	public class Emit
	{
		public string CNPJ { get; set; }
		public string CPF { get; set; }
		public string xNome { get; set; }
		public string xFant { get; set; }
		public EnderEmit enderEmit { get; set; }
		public string IE { get; set; }
		public string IEST { get; set; }
		public string IM { get; set; }
		public string CNAE { get; set; }
		public string CRT { get; set; }
	}

	public class EnderDest
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
		public EnderDest enderDest { get; set; }
		public string indIEDest { get; set; }
		public string IE { get; set; }
		public string ISUF { get; set; }
		public string IM { get; set; }
		public string email { get; set; }
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
		public string CEP { get; set; }
		public string cPais { get; set; }
		public string xPais { get; set; }
		public string fone { get; set; }
		public string email { get; set; }
		public string xNome { get; set; }
		public string IE { get; set; }
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
		public string CEP { get; set; }
		public string cPais { get; set; }
		public string xPais { get; set; }
		public string fone { get; set; }
		public string email { get; set; }
		public string xNome { get; set; }
		public string IE { get; set; }
	}

	public class AutXML
	{
		public string CNPJ { get; set; }
		public string CPF { get; set; }
	}

	// --- Detalhes do Produto ---

	public class Rastro
	{
		public string nLote { get; set; }
		public string qLote { get; set; }
		public string dFab { get; set; }
		public string dVal { get; set; }
		public string cAgreg { get; set; }
	}

	public class Adi
	{
		public string nAdicao { get; set; }
		public string nSeqAdic { get; set; }
		public string cFabricante { get; set; }
		public string vDescDI { get; set; }
		public string nDraw { get; set; }
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
		public List<Adi> adi { get; set; }
	}

	public class ExportInd
	{
		public string nRE { get; set; }
		public string chNFe { get; set; }
		public string qExport { get; set; }
	}

	public class DetExport
	{
		public string nDraw { get; set; }
		public ExportInd exportInd { get; set; }
	}

	public class VeicProd
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
		public string xMotivoIsencao { get; set; }
	}

	public class Arma
	{
		public string tpArma { get; set; }
		public string nSerie { get; set; }
		public string nCano { get; set; }
		public string descr { get; set; }
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
		public string pBio { get; set; }
		public Encerrante encerrante { get; set; }
	}

	public class InfProdEmb
	{
		public string xEmb { get; set; }
		public string qVolEmb { get; set; }
		public string uEmb { get; set; }
	}

	public class infProdNFF
	{
		public string cProdFisco { get; set; }
		public string cOperNFF { get; set; }
	}

	public class gCred
	{
		public string cCredPresumido { get; set; }
		public string pCredPresumido { get; set; }
		public string vCredPresumido { get; set; }
	}

	public class Prod
	{
		public string cProd { get; set; }
		public string cEAN { get; set; }
		public string xProd { get; set; }
		public string NCM { get; set; }
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
		public string xPed { get; set; }
		public string nItemPed { get; set; }
		public string nFCI { get; set; }
		public string NVE { get; set; }
		public string CEST { get; set; }
		public string indEscala { get; set; }
		public string CNPJFab { get; set; }
		public string cBenef { get; set; }
		public string cBarra { get; set; }
		public string cBarraTrib { get; set; }
		public string indBemMovelUsado { get; set; }
		public string tpCredPresIBSZFM { get; set; }
		public gCred gCred { get; set; }
		public List<Rastro> rastro { get; set; }
		public List<DI> DI { get; set; }
		public List<DetExport> detExport { get; set; }
		public VeicProd veicProd { get; set; }
		public Med med { get; set; }
		public List<Arma> arma { get; set; }
		public Comb comb { get; set; }
		public string nRECOPI { get; set; }
		public infProdNFF infProdNFF { get; set; }
		public InfProdEmb infProdEmb { get; set; }
	}

	// --- ICMS ---

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

	public class ICMS02
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string qBCMono { get; set; }
		public string adRemICMS { get; set; }
		public string vICMSMono { get; set; }
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
		public string vICMSSTDeson { get; set; }
		public string motDesICMSST { get; set; }
	}

	public class ICMS15
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string qBCMon { get; set; }
		public string adRemICMS { get; set; }
		public string vICMSMono { get; set; }
		public string qBCMonoReten { get; set; }
		public string adRemICMSReten { get; set; }
		public string vICMSMonoReten { get; set; }
		public string pRedAdRem { get; set; }
		public string motRedAdRem { get; set; }
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
		public string indDeduzDeson { get; set; }
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
		public string indDeduzDeson { get; set; }
	}

	public class ICMS40
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string vICMSDeson { get; set; }
		public string motDesICMS { get; set; }
		public string indDeduzDeson { get; set; }
	}

	public class ICMS41
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string vICMSDeson { get; set; }
		public string motDesICMS { get; set; }
		public string indDeduzDeson { get; set; }
	}

	public class ICMS50
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string vICMSDeson { get; set; }
		public string motDesICMS { get; set; }
		public string indDeduzDeson { get; set; }
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
		public string pFCPDif { get; set; }
		public string vFCPDif { get; set; }
		public string vFCPEfet { get; set; }
	}

	public class ICMS53
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string qBCMono { get; set; }
		public string adRemICMS { get; set; }
		public string vICMSMonoOp { get; set; }
		public string pDif { get; set; }
		public string vICMSMonoDif { get; set; }
		public string vICMSMono { get; set; }
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
		public string pRedBCEfet { get; set; }
		public string vBCEfet { get; set; }
		public string pICMSEfet { get; set; }
		public string vICMSEfet { get; set; }
		public string vICMSSubstituto { get; set; }
	}

	public class ICMS61
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string qBCMonoRet { get; set; }
		public string adRemICMSRet { get; set; }
		public string vICMSMonoRet { get; set; }
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
		public string vICMSSTDeson { get; set; }
		public string motDesICMSST { get; set; }
		public string indDeduzDeson { get; set; }
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
		public string vICMSSTDeson { get; set; }
		public string motDesICMSST { get; set; }
		public string indDeduzDeson { get; set; }
	}

	public class ICMSPart
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
		public string vBCFCPST { get; set; }
		public string pFCPST { get; set; }
		public string vFCPST { get; set; }
	}

	public class ICMSST
	{
		public string orig { get; set; }
		public string CST { get; set; }
		public string vBCSTRet { get; set; }
		public string vICMSSTRet { get; set; }
		public string vBCSTDest { get; set; }
		public string vICMSSTDest { get; set; }
		public string vBCFCPSTRet { get; set; }
		public string pFCPSTRet { get; set; }
		public string vFCPSTRet { get; set; }
		public string pST { get; set; }
		public string vICMSSubstituto { get; set; }
		public string pRedBCEfet { get; set; }
		public string vBCEfet { get; set; }
		public string pICMSEfet { get; set; }
		public string vICMSEfet { get; set; }
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
		public string pRedBCEfet { get; set; }
		public string vBCEfet { get; set; }
		public string pICMSEfet { get; set; }
		public string vICMSEfet { get; set; }
		public string vICMSSubstituto { get; set; }
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

	public class ICMSUFDest
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

	public class ICMS
	{
		public ICMS00 ICMS00 { get; set; }
		public ICMS02 ICMS02 { get; set; }
		public ICMS10 ICMS10 { get; set; }
		public ICMS15 ICMS15 { get; set; }
		public ICMS20 ICMS20 { get; set; }
		public ICMS30 ICMS30 { get; set; }
		public ICMS40 ICMS40 { get; set; }
		public ICMS41 ICMS41 { get; set; }
		public ICMS50 ICMS50 { get; set; }
		public ICMS51 ICMS51 { get; set; }
		public ICMS53 ICMS53 { get; set; }
		public ICMS60 ICMS60 { get; set; }
		public ICMS61 ICMS61 { get; set; }
		public ICMS70 ICMS70 { get; set; }
		public ICMS90 ICMS90 { get; set; }
		public ICMSPart ICMSPart { get; set; }
		public ICMSST ICMSST { get; set; }
		public ICMSSN101 ICMSSN101 { get; set; }
		public ICMSSN102 ICMSSN102 { get; set; }
		public ICMSSN201 ICMSSN201 { get; set; }
		public ICMSSN202 ICMSSN202 { get; set; }
		public ICMSSN500 ICMSSN500 { get; set; }
		public ICMSSN900 ICMSSN900 { get; set; }
	}

	// --- IPI, PIS, COFINS, ISSQN ---

	public class IPITrib
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

	public class IPI
	{
		public string CNPJProd { get; set; }
		public string cSelo { get; set; }
		public string qSelo { get; set; }
		public string cEnq { get; set; }
		public IPITrib IPITrib { get; set; }
		public IPINT IPINT { get; set; }
	}

	public class II
	{
		public string vBC { get; set; }
		public string vDespAdu { get; set; }
		public string vII { get; set; }
		public string vIOF { get; set; }
	}

	public class PISAliq
	{
		public string CST { get; set; }
		public string vBC { get; set; }
		public string pPIS { get; set; }
		public string vPIS { get; set; }
	}

	public class PISQtde
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

	public class PISOutr
	{
		public string CST { get; set; }
		public string vBC { get; set; }
		public string pPIS { get; set; }
		public string qBCProd { get; set; }
		public string vAliqProd { get; set; }
		public string vPIS { get; set; }
	}

	public class PIS
	{
		public PISAliq PISAliq { get; set; }
		public PISQtde PISQtde { get; set; }
		public PISNT PISNT { get; set; }
		public PISOutr PISOutr { get; set; }
	}

	public class PISST
	{
		public string vBC { get; set; }
		public string pPIS { get; set; }
		public string qBCProd { get; set; }
		public string vAliqProd { get; set; }
		public string vPIS { get; set; }
		public string indSomaPISST { get; set; }
	}

	public class COFINSAliq
	{
		public string CST { get; set; }
		public string vBC { get; set; }
		public string pCOFINS { get; set; }
		public string vCOFINS { get; set; }
	}

	public class COFINSQtde
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

	public class COFINSOutr
	{
		public string CST { get; set; }
		public string vBC { get; set; }
		public string pCOFINS { get; set; }
		public string qBCProd { get; set; }
		public string vAliqProd { get; set; }
		public string vCOFINS { get; set; }
	}

	public class COFINS
	{
		public COFINSAliq COFINSAliq { get; set; }
		public COFINSQtde COFINSQtde { get; set; }
		public COFINSNT COFINSNT { get; set; }
		public COFINSOutr COFINSOutr { get; set; }
	}

	public class COFINSST
	{
		public string vBC { get; set; }
		public string pCOFINS { get; set; }
		public string qBCProd { get; set; }
		public string vAliqProd { get; set; }
		public string vCOFINS { get; set; }
		public string indSomaCOFINSST { get; set; }
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

	// --- Imposto e Reforma Tributária (Item) ---

	public class IS
	{
		public string CSTIS { get; set; }
		public string cClassTribIS { get; set; }
		public string vBCIS { get; set; }
		public string pIS { get; set; }
		public string pISEspec { get; set; }
		public string uTrib { get; set; }
		public string qTrib { get; set; }
		public string vIS { get; set; }
	}

	public class gDif
	{
		public string pDif { get; set; }
		public string vDif { get; set; }
	}

	public class gDevTrib
	{
		public string vDevTrib { get; set; }
	}

	public class gRed
	{
		public string pRedAliq { get; set; }
		public string pAliqEfet { get; set; }
	}

	public class gIBSUF
	{
		public string pIBSUF { get; set; }
		public string vIBSUF { get; set; }
		public gDif gDif { get; set; }
		public gDevTrib gDevTrib { get; set; }
		public gRed gRed { get; set; }
	}

	public class gIBSMun
	{
		public string pIBSMun { get; set; }
		public string vIBSMun { get; set; }
		public gDif gDif { get; set; }
		public gDevTrib gDevTrib { get; set; }
		public gRed gRed { get; set; }
	}

	public class gCBS
	{
		public string pCBS { get; set; }
		public string vCBS { get; set; }
		public gDif gDif { get; set; }
		public gDevTrib gDevTrib { get; set; }
		public gRed gRed { get; set; }
	}

	public class gTribRegular
	{
		public string CSTReg { get; set; }
		public string cClassTribReg { get; set; }
		public string pAliqEfetRegIBSUF { get; set; }
		public string vTribRegIBSUF { get; set; }
		public string pAliqEfetRegIBSMun { get; set; }
		public string vTribRegIBSMun { get; set; }
		public string pAliqEfetRegCBS { get; set; }
		public string vTribRegCBS { get; set; }
	}

	public class gTribCompraGov
	{
		public string pAliqIBSUF { get; set; }
		public string vTribIBSUF { get; set; }
		public string pAliqIBSMun { get; set; }
		public string vTribIBSMun { get; set; }
		public string pAliqCBS { get; set; }
		public string vTribCBS { get; set; }
	}

	public class gIBSCredPres
	{
		public string cCredPres { get; set; }
		public string pCredPres { get; set; }
		public string vCredPres { get; set; }
		public string vCredPresCondSus { get; set; }
	}

	public class gCBSCredPres
	{
		public string cCredPres { get; set; }
		public string pCredPres { get; set; }
		public string vCredPres { get; set; }
		public string vCredPresCondSus { get; set; }
	}

	public class gIBSCBS
	{
		public string vBC { get; set; }
		public string vIBS { get; set; }
		public gIBSUF gIBSUF { get; set; }
		public gIBSMun gIBSMun { get; set; }
		public gCBS gCBS { get; set; }
		public gTribRegular gTribRegular { get; set; }
		public gIBSCredPres gIBSCredPress { get; set; }
		public gCBSCredPres gCBSCredPres { get; set; }
		public gTribCompraGov gTribCompraGov { get; set; }
	}

	public class gMonoPadrao
	{
		public string qBCMono { get; set; }
		public string adRemIBS { get; set; }
		public string adRemCBS { get; set; }
		public string vIBSMono { get; set; }
		public string vCBSMono { get; set; }
	}

	public class gMonoReten
	{
		public string qBCMonoReten { get; set; }
		public string adRemIBSReten { get; set; }
		public string adRemCBSReten { get; set; }
		public string vIBSMonoReten { get; set; }
		public string vCBSMonoReten { get; set; }
	}

	public class gMonoRet
	{
		public string qBCMonoRet { get; set; }
		public string adRemIBSReten { get; set; }
		public string adRemCBSReten { get; set; }
		public string vIBSMonoRet { get; set; }
		public string vCBSMonoRet { get; set; }
	}

	public class gMonoDif
	{
		public string pDifCBS { get; set; }
		public string pDifIBS { get; set; }
		public string vIBSMonoDif { get; set; }
		public string vCBSMonoDif { get; set; }
		public string vTotIBSMonoItem { get; set; }
		public string vTotCBSMonoItem { get; set; }
	}

	public class gIBSCBSMono
	{
		public string vTotIBSMonoItem { get; set; }
		public string vTotCBSMonoItem { get; set; }
		public gMonoPadrao gMonoPadrao { get; set; }
		public gMonoReten gMonoReten { get; set; }
		public gMonoRet gMonoRet { get; set; }
		public gMonoDif gMonoDif { get; set; }
	}

	public class gTransfCred
	{
		public string vIBS { get; set; }
		public string vCBS { get; set; }
	}

	public class gCredPresIBSZFM
	{
		public string competApur { get; set; }
		public string vCredPresIBSZFM { get; set; }
		public string tpCredPresIBSZFM { get; set; }
	}

	public class gAjusteCompet
	{
		public string competApur { get; set; }
		public string vIBS { get; set; }
		public string vCBS { get; set; }
	}

	public class gEstornoCred
	{
		public gEstornoCred vIBSEstCred { get; set; }
		public gEstornoCred vCBSEstCred { get; set; }
	}

	public class gCredPresoper
	{
		public string vBCCredPres { get; set; }
		public string cCredPres { get; set; }
		public gIBSCredPres gIBSCredPres { get; set; }
		public gCBSCredPres gCBSCredPres { get; set; }
	}

	public class IBSCBS
	{
		public string CST { get; set; }
		public string cClassTrib { get; set; }
		public string indDoacao { get; set; }
		public gIBSCBS gIBSCBS { get; set; }
		public gIBSCBSMono gIBSCBSMono { get; set; }
		public gTransfCred gTransfCred { get; set; }
		public gCredPresIBSZFM gCredPresIBSZFM { get; set; }
		public gAjusteCompet gAjusteCompet { get; set; }
		public gEstornoCred gEstornoCred { get; set; }
		public gCredPresoper gCredPresOper { get; set; }
	}

	public class Imposto
	{
		public string vTotTrib { get; set; }
		public ICMS ICMS { get; set; }
		public ICMSUFDest ICMSUFDest { get; set; }
		public IPI IPI { get; set; }
		public II II { get; set; }
		public PIS PIS { get; set; }
		public PISST PISST { get; set; }
		public COFINS COFINS { get; set; }
		public COFINSST COFINSST { get; set; }
		public ISSQN ISSQN { get; set; }
		public IS IS { get; set; }
		public IBSCBS IBSCBS { get; set; }
	}

	public class gIBSCBSCredPres
	{
		public string pCredPres { get; set; }
		public string vCredPres { get; set; }
		public string vCredPresCondSus { get; set; }
	}

	public class IPIDevol
	{
		public string vIPIDevol { get; set; }
	}
	public class ImpostoDevol
	{
		public string pDevol { get; set; }
		public IPIDevol IPI { get; set; }
	}

	public class DFeReferenciado
	{
		public string chaveAcesso { get; set; }
		public string nItem { get; set; }
	}

	public class Det
	{
		public Prod prod { get; set; }
		public Imposto imposto { get; set; }
		public ImpostoDevol impostoDevol { get; set; }
		public string infAdProd { get; set; }
		public string nItem { get; set; }
		public string vItem { get; set; }
		public DFeReferenciado DFeReferenciado { get; set; }
	}

	// --- Totais ---

	public class ICMSTot
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
		// Campos novos Totais
		public string qBCMono { get; set; }
		public string vICMSMono { get; set; }
		public string qBCMonoReten { get; set; }
		public string vICMSMonoReten { get; set; }
		public string qBCMonoRet { get; set; }
		public string vICMSMonoRet { get; set; }
	}

	public class ISSQNtot
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

	public class RetTrib
	{
		public string vRetPIS { get; set; }
		public string vRetCOFINS { get; set; }
		public string vRetCSLL { get; set; }
		public string vBCIRRF { get; set; }
		public string vIRRF { get; set; }
		public string vBCRetPrev { get; set; }
		public string vRetPrev { get; set; }
	}

	// Classes Exclusivas para o grupo de Total (Sufixo Tot) para evitar conflitos

	public class gIBSUFTot
	{
		public string vIBSUF { get; set; }
		public string vDif { get; set; }
		public string vDevTrib { get; set; }
	}

	public class gIBSMunTot
	{
		public string vIBSMun { get; set; }
		public string vDif { get; set; }
		public string vDevTrib { get; set; }
	}

	public class gIBSTot
	{
		public gIBSUFTot gIBSUF { get; set; }
		public gIBSMunTot gIBSMun { get; set; }
		public string vIBS { get; set; }
		public string vCredPres { get; set; }
		public string vCredPresCondSus { get; set; }
	}

	public class gCBSTot
	{
		public string vDif { get; set; }
		public string vDevTrib { get; set; }
		public string vCBS { get; set; }
		public string vCredPres { get; set; }
		public string vCredPresCondSus { get; set; }
	}

	public class gMono
	{
		public string vIBSMono { get; set; }
		public string vCBSMono { get; set; }
		public string vIBSMonoReten { get; set; }
		public string vCBSMonoReten { get; set; }
		public string vIBSMonoRet { get; set; }
		public string vCBSMonoRet { get; set; }
	}

	public class ISTot
	{
		public string vIS { get; set; }
	}

	public class IBSCBSTot
	{
		public string vBCIBSCBS { get; set; }
		public gIBSTot gIBS { get; set; }
		public gCBSTot gCBS { get; set; }
		public gEstornoCred gEstornoCred { get; set; }
		public gMono gMono { get; set; }
	}

	public class Total
	{
		public ICMSTot ICMSTot { get; set; }
		public ISSQNtot ISSQNtot { get; set; }
		public RetTrib retTrib { get; set; }
		public string vNFTot { get; set; }
		public ISTot ISTot { get; set; }
		public IBSCBSTot IBSCBSTot { get; set; }
	}

	// --- Transporte, Cobrança, Pagamento e Adicionais ---

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

	public class RetTransp
	{
		public string vServ { get; set; }
		public string vBCRet { get; set; }
		public string pICMSRet { get; set; }
		public string vICMSRet { get; set; }
		public string CFOP { get; set; }
		public string cMunFG { get; set; }
	}

	public class VeicTransp
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

	public class Lacre
	{
		public string nLacre { get; set; }
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

	public class Transp
	{
		public string modFrete { get; set; }
		public Transporta transporta { get; set; }
		public RetTransp retTransp { get; set; }
		public VeicTransp veicTransp { get; set; }
		public List<Reboque> reboque { get; set; }
		public string vagao { get; set; }
		public string balsa { get; set; }
		public List<Vol> vol { get; set; }
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

	public class Cobr
	{
		public Fat fat { get; set; }
		public List<Dup> dup { get; set; }
	}

	public class Card
	{
		public string CNPJ { get; set; }
		public string tBand { get; set; }
		public string cAut { get; set; }
		public string tpIntegra { get; set; }
		public string CNPJReceb { get; set; }
		public string idTermPag { get; set; }
	}

	public class DetPag
	{
		public string indPag { get; set; }
		public string tPag { get; set; }
		public string vPag { get; set; }
		public string xPag { get; set; }
		public string dPag { get; set; }
		public string CNPJPag { get; set; }
		public string UFPag { get; set; }
		public Card card { get; set; }
	}

	public class Pag
	{
		public List<DetPag> detPag { get; set; }
		public string vTroco { get; set; }
	}

	public class InfIntermed
	{
		public string CNPJ { get; set; }
		public string idCadIntTran { get; set; }
	}

	public class ObsCont
	{
		public string xCampo { get; set; }
		public string xTexto { get; set; }
	}

	public class ObsFisco
	{
		public string xCampo { get; set; }
		public string xTexto { get; set; }
	}

	public class ProcRef
	{
		public string nProc { get; set; }
		public string indProc { get; set; }
		public string tpAto { get; set; }
	}

	public class InfAdic
	{
		public string infAdFisco { get; set; }
		public string infCpl { get; set; }
		public List<ObsCont> obsCont { get; set; }
		public List<ObsFisco> obsFisco { get; set; }
		public List<ProcRef> procRef { get; set; }
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

	public class ForDia
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

	public class Cana
	{
		public string safra { get; set; }
		public string @ref { get; set; }
		public List<ForDia> forDia { get; set; }
		public List<Deduc> deduc { get; set; }
		public string qTotMes { get; set; }
		public string qTotAnt { get; set; }
		public string qTotGer { get; set; }
		public string vFor { get; set; }
		public string vTotDed { get; set; }
		public string vLiqFor { get; set; }
	}

	// --- Estrutura Principal ---

	public class InfNFe
	{
		public string versao { get; set; }
		public Ide ide { get; set; }
		public Emit emit { get; set; }
		public Dest dest { get; set; }
		public Retirada retirada { get; set; }
		public Entrega entrega { get; set; }
		public List<AutXML> autXML { get; set; }
		public List<Det> det { get; set; }
		public Total total { get; set; }
		public Transp transp { get; set; }
		public Cobr cobr { get; set; }
		public Pag pag { get; set; }
		public InfIntermed infIntermed { get; set; }
		public InfAdic infAdic { get; set; }
		public Exporta exporta { get; set; }
		public Compra compra { get; set; }
		public Cana cana { get; set; }
		public Infresptec infRespTec { get; set; }
		public agropecuario agropecuario { get; set; }
	}

	public class NFe
	{
		public InfNFe infNFe { get; set; }
	}

	public class Infresptec
	{
		public string CNPJ { get; set; }
		public string xContato { get; set; }
		public string email { get; set; }
		public string fone { get; set; }
	}

	public class agropecuario
	{
		public defensivo defensivo { get; set; }
		public string guiaTransito { get; set; }
	}

	public class guiaTransito
	{
		public string tpGuia { get; set; }
		public string UFGuia { get; set; }
		public string serieGuia { get; set; }
		public string nGuia { get; set; }
	}

	public class defensivo
	{
		public string nReceituario { get; set; }
		public string CPFRespTec { get; set; }
	}

	public class gCompraGov
	{
		public string tpEnteGov { get; set; }
		public string pRedutor { get; set; }
		public string tpOperGov { get; set; }
	}

	public class gPagAntecipado
	{
		public string refNFe { get; set; }
	}
}