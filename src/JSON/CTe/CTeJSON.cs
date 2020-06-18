using System.Collections.Generic;

namespace NSSuite_CSharp.src.JSON.CTe
{
        public class Toma3
        {
            public string toma { get; set; }
        }

        public class EnderToma
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string cPais { get; set; }
            public string xPais { get; set; }
        }

        public class Toma4
        {
            public string toma { get; set; }
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string IE { get; set; }
            public string xNome { get; set; }
            public string xFant { get; set; }
            public string fone { get; set; }
            public EnderToma enderToma { get; set; }
            public string email { get; set; }
        }

        public class Ide
        {
            public string cUF { get; set; }
            public string cCT { get; set; }
            public string CFOP { get; set; }
            public string natOp { get; set; }
            public string mod { get; set; }
            public string serie { get; set; }
            public string nCT { get; set; }
            public string dhEmi { get; set; }
            public string tpImp { get; set; }
            public string tpEmis { get; set; }
            public string cDV { get; set; }
            public string tpAmb { get; set; }
            public string tpCTe { get; set; }
            public string procEmi { get; set; }
            public string verProc { get; set; }
            public string cMunEnv { get; set; }
            public string xMunEnv { get; set; }
            public string UFEnv { get; set; }
            public string modal { get; set; }
            public string tpServ { get; set; }
            public string cMunIni { get; set; }
            public string xMunIni { get; set; }
            public string UFIni { get; set; }
            public string cMunFim { get; set; }
            public string xMunFim { get; set; }
            public string UFFim { get; set; }
            public string retira { get; set; }
            public string xDetRetira { get; set; }
            public string indIEToma { get; set; }
            public Toma3 toma3 { get; set; }
            public Toma4 toma4 { get; set; }
            public string dhCont { get; set; }
            public string xJust { get; set; }
        }

        public class Pass
        {
            public string xPass { get; set; }
        }

        public class Fluxo
        {
            public string xOrig { get; set; }
            public IList<Pass> pass { get; set; }
            public string xDest { get; set; }
            public string xRota { get; set; }
        }

        public class SemData
        {
            public string tpPer { get; set; }
        }

        public class ComData
        {
            public string tpPer { get; set; }
            public string dProg { get; set; }
        }

        public class NoPeriodo
        {
            public string tpPer { get; set; }
            public string dIni { get; set; }
            public string dFim { get; set; }
        }

        public class SemHora
        {
            public string tpHor { get; set; }
        }

        public class ComHora
        {
            public string tpHor { get; set; }
            public string hProg { get; set; }
        }

        public class NoInter
        {
            public string tpHor { get; set; }
            public string hIni { get; set; }
            public string hFim { get; set; }
        }

        public class Entrega
        {
            public SemData semData { get; set; }
            public ComData comData { get; set; }
            public NoPeriodo noPeriodo { get; set; }
            public SemHora semHora { get; set; }
            public ComHora comHora { get; set; }
            public NoInter noInter { get; set; }
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

        public class Compl
        {
            public string xCaracAd { get; set; }
            public string xCaracSer { get; set; }
            public string xEmi { get; set; }
            public Fluxo fluxo { get; set; }
            public Entrega Entrega { get; set; }
            public string origCalc { get; set; }
            public string destCalc { get; set; }
            public string xObs { get; set; }
            public IList<ObsCont> ObsCont { get; set; }
            public IList<ObsFisco> ObsFisco { get; set; }
        }

        public class EnderEmit
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string fone { get; set; }
        }

        public class Emit
        {
            public string CNPJ { get; set; }
            public string IE { get; set; }
            public string IEST { get; set; }
            public string xNome { get; set; }
            public string xFant { get; set; }
            public EnderEmit enderEmit { get; set; }
        }

        public class EnderReme
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string cPais { get; set; }
            public string xPais { get; set; }
        }

        public class Rem
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string IE { get; set; }
            public string xNome { get; set; }
            public string xFant { get; set; }
            public string fone { get; set; }
            public EnderReme enderReme { get; set; }
            public string email { get; set; }
        }

        public class EnderExped
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string cPais { get; set; }
            public string xPais { get; set; }
        }

        public class Exped
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string IE { get; set; }
            public string xNome { get; set; }
            public string fone { get; set; }
            public EnderExped enderExped { get; set; }
            public string email { get; set; }
        }

        public class EnderReceb
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string cPais { get; set; }
            public string xPais { get; set; }
        }

        public class Receb
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string IE { get; set; }
            public string xNome { get; set; }
            public string fone { get; set; }
            public EnderReceb enderReceb { get; set; }
            public string email { get; set; }
        }

        public class EnderDest
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string cPais { get; set; }
            public string xPais { get; set; }
        }

        public class Dest
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string IE { get; set; }
            public string xNome { get; set; }
            public string fone { get; set; }
            public string ISUF { get; set; }
            public EnderDest enderDest { get; set; }
            public string email { get; set; }
        }

        public class Comp
        {
            public string xNome { get; set; }
            public string vComp { get; set; }
        }

        public class VPrest
        {
            public string vTPrest { get; set; }
            public string vRec { get; set; }
            public IList<Comp> Comp { get; set; }
        }

        public class ICMS00
        {
            public string CST { get; set; }
            public string vBC { get; set; }
            public string pICMS { get; set; }
            public string vICMS { get; set; }
        }

        public class ICMS20
        {
            public string CST { get; set; }
            public string pRedBC { get; set; }
            public string vBC { get; set; }
            public string pICMS { get; set; }
            public string vICMS { get; set; }
        }

        public class ICMS45
        {
            public string CST { get; set; }
        }

        public class ICMS60
        {
            public string CST { get; set; }
            public string vBCSTRet { get; set; }
            public string vICMSSTRet { get; set; }
            public string pICMSSTRet { get; set; }
            public string vCred { get; set; }
        }

        public class ICMS90
        {
            public string CST { get; set; }
            public string pRedBC { get; set; }
            public string vBC { get; set; }
            public string pICMS { get; set; }
            public string vICMS { get; set; }
            public string vCred { get; set; }
        }

        public class ICMSOutraUF
        {
            public string CST { get; set; }
            public string pRedBCOutraUF { get; set; }
            public string vBCOutraUF { get; set; }
            public string pICMSOutraUF { get; set; }
            public string vICMSOutraUF { get; set; }
        }

        public class ICMSSN
        {
            public string CST { get; set; }
            public string indSN { get; set; }
        }

        public class ICMS
        {
            public ICMS00 ICMS00 { get; set; }
            public ICMS20 ICMS20 { get; set; }
            public ICMS45 ICMS45 { get; set; }
            public ICMS60 ICMS60 { get; set; }
            public ICMS90 ICMS90 { get; set; }
            public ICMSOutraUF ICMSOutraUF { get; set; }
            public ICMSSN ICMSSN { get; set; }
        }

        public class ICMSUFFim
        {
            public string vBCUFFim { get; set; }
            public string pFCPUFFim { get; set; }
            public string pICMSUFFim { get; set; }
            public string pICMSInter { get; set; }
            public string pICMSInterPart { get; set; }
            public string vFCPUFFim { get; set; }
            public string vICMSUFFim { get; set; }
            public string vICMSUFIni { get; set; }
        }

        public class Imp
        {
            public ICMS ICMS { get; set; }
            public string vTotTrib { get; set; }
            public string infAdFisco { get; set; }
            public ICMSUFFim ICMSUFFim { get; set; }
        }

        public class InfQ
        {
            public string cUnid { get; set; }
            public string tpMed { get; set; }
            public string qCarga { get; set; }
        }

        public class InfCarga
        {
            public string vCarga { get; set; }
            public string proPred { get; set; }
            public IList<InfQ> infQ { get; set; }
            public string vCargaAverb { get; set; }
        }

        public class LacUnidTransp
        {
            public string nLacre { get; set; }
        }

        public class InfNF
        {
            public string nRoma { get; set; }
            public string nPed { get; set; }
            public string mod { get; set; }
            public string serie { get; set; }
            public string nDoc { get; set; }
            public string dEmi { get; set; }
            public string vBC { get; set; }
            public string vICMS { get; set; }
            public string vBCST { get; set; }
            public string vST { get; set; }
            public string vProd { get; set; }
            public string vNF { get; set; }
            public string nCFOP { get; set; }
            public string nPeso { get; set; }
            public string PIN { get; set; }
            public string dPrev { get; set; }
            public IList<InfUnidCarga> infUnidCarga { get; set; }
            public IList<InfUnidTransp> infUnidTransp { get; set; }
        }

        public class InfNFe
        {
            public string chave { get; set; }
            public string PIN { get; set; }
            public string dPrev { get; set; }
            public IList<InfUnidCarga> infUnidCarga { get; set; }
            public IList<InfUnidTransp> infUnidTransp { get; set; }
        }

        public class LacUnidCarga
        {
            public string nLacre { get; set; }
        }

        public class InfUnidCarga
        {
            public string tpUnidCarga { get; set; }
            public string idUnidCarga { get; set; }
            public IList<LacUnidCarga> lacUnidCarga { get; set; }
            public string qtdRat { get; set; }
        }

        public class InfUnidTransp
        {
            public string tpUnidTransp { get; set; }
            public string idUnidTransp { get; set; }
            public IList<LacUnidTransp> lacUnidTransp { get; set; }
            public IList<InfUnidCarga> infUnidCarga { get; set; }
            public string qtdRat { get; set; }
        }

        public class InfOutro
        {
            public string tpDoc { get; set; }
            public string descOutros { get; set; }
            public string nDoc { get; set; }
            public string dEmi { get; set; }
            public string vDocFisc { get; set; }
            public string dPrev { get; set; }
            public IList<InfUnidCarga> infUnidCarga { get; set; }
            public IList<InfUnidTransp> infUnidTransp { get; set; }
        }

        public class InfDoc
        {
            public IList<InfNF> infNF { get; set; }
            public IList<InfNFe> infNFe { get; set; }
            public IList<InfOutro> infOutros { get; set; }
        }

        public class IdDocAntPap
        {
            public string tpDoc { get; set; }
            public string serie { get; set; }
            public string subser { get; set; }
            public string nDoc { get; set; }
            public string dEmi { get; set; }
        }

        public class IdDocAntEle
        {
            public string chCTe { get; set; }
        }

        public class IdDocAnt
        {
            public IList<IdDocAntPap> idDocAntPap { get; set; }
            public IList<IdDocAntEle> idDocAntEle { get; set; }
        }

        public class EmiDocAnt
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string IE { get; set; }
            public string UF { get; set; }
            public string xNome { get; set; }
            public IList<IdDocAnt> idDocAnt { get; set; }
        }

        public class DocAnt
        {
            public IList<EmiDocAnt> emiDocAnt { get; set; }
        }

        public class VeicNovo
        {
            public string chassi { get; set; }
            public string cCor { get; set; }
            public string xCor { get; set; }
            public string cMod { get; set; }
            public string vUnit { get; set; }
            public string vFrete { get; set; }
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
            public IList<Dup> dup { get; set; }
        }

        public class RefNF
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
            public string mod { get; set; }
            public string serie { get; set; }
            public string subserie { get; set; }
            public string nro { get; set; }
            public string valor { get; set; }
            public string dEmi { get; set; }
        }

        public class TomaICMS
        {
            public string refNFe { get; set; }
            public RefNF refNF { get; set; }
            public string refCte { get; set; }
        }

        public class InfCteSub
        {
            public string chCte { get; set; }
            public string refCteAnu { get; set; }
            public TomaICMS tomaICMS { get; set; }
            public string indAlteraToma { get; set; }
        }

        public class InfGlobalizado
        {
            public string xObs { get; set; }
        }

        public class InfCTeMultimodal
        {
            public string chCTeMultimodal { get; set; }
        }

        public class InfServVinc
        {
            public IList<InfCTeMultimodal> infCTeMultimodal { get; set; }
        }

        public class InfCTeNorm
        {
            public InfCarga infCarga { get; set; }
            public InfDoc infDoc { get; set; }
            public DocAnt docAnt { get; set; }
            public IList<VeicNovo> veicNovos { get; set; }
            public Cobr cobr { get; set; }
            public InfCteSub infCteSub { get; set; }
            public InfGlobalizado infGlobalizado { get; set; }
            public InfServVinc infServVinc { get; set; }
        }

        public class InfCteComp
        {
            public string chCTe { get; set; }
        }

        public class InfCteAnu
        {
            public string chCTe { get; set; }
            public string dEmi { get; set; }
        }

        public class AutXML
        {
            public string CNPJ { get; set; }
            public string CPF { get; set; }
        }

        public class InfCte
        {
            public string versao { get; set; }
            public Ide ide { get; set; }
            public Compl compl { get; set; }
            public Emit emit { get; set; }
            public Rem rem { get; set; }
            public Exped exped { get; set; }
            public Receb receb { get; set; }
            public Dest dest { get; set; }
            public VPrest vPrest { get; set; }
            public Imp imp { get; set; }
            public InfCTeNorm infCTeNorm { get; set; }
            public InfCteComp infCteComp { get; set; }
            public InfCteAnu infCteAnu { get; set; }
            public IList<AutXML> autXML { get; set; }
        }

        public class CTe
        {
            public InfCte infCte { get; set; }
        }

        public class EmiOcc
        {
            public string CNPJ { get; set; }
            public string cInt { get; set; }
            public string IE { get; set; }
            public string UF { get; set; }
            public string fone { get; set; }
        }

        public class Occ
        {
            public string serie { get; set; }
            public string nOcc { get; set; }
            public string dEmi { get; set; }
            public EmiOcc emiOcc { get; set; }
        }

        public class Rodo
        {
            public string xmlns { get; set; }
            public string RNTRC { get; set; }
            public IList<Occ> occ { get; set; }
        }

        public class NatCarga
        {
            public string xDime { get; set; }
            public string cInfManu { get; set; }
        }

        public class Tarifa
        {
            public string CL { get; set; }
            public string cTar { get; set; }
            public string vTar { get; set; }
        }

        public class InfTotAP
        {
            public string qTotProd { get; set; }
            public string uniAP { get; set; }
        }

        public class Peri
        {
            public string nONU { get; set; }
            public string qTotEmb { get; set; }
            public InfTotAP infTotAP { get; set; }
        }

        public class Aereo
        {
            public string nMinu { get; set; }
            public string nOCA { get; set; }
            public string dPrevAereo { get; set; }
            public NatCarga natCarga { get; set; }
            public Tarifa tarifa { get; set; }
            public IList<Peri> peri { get; set; }
        }

        public class Balsa
        {
            public string xBalsa { get; set; }
        }

        public class Lacre
        {
            public string nLacre { get; set; }
        }

        public class DetCont
        {
            public string nCont { get; set; }
            public IList<Lacre> lacre { get; set; }
            public InfDoc infDoc { get; set; }
        }

        public class Aquav
        {
            public string vPrest { get; set; }
            public string vAFRMM { get; set; }
            public string xNavio { get; set; }
            public IList<Balsa> balsa { get; set; }
            public string nViag { get; set; }
            public string direc { get; set; }
            public string irin { get; set; }
            public IList<DetCont> detCont { get; set; }
        }

        public class EnderFerro
        {
            public string xLgr { get; set; }
            public string nro { get; set; }
            public string xCpl { get; set; }
            public string xBairro { get; set; }
            public string cMun { get; set; }
            public string xMun { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
        }

        public class FerroEnv
        {
            public string CNPJ { get; set; }
            public string cInt { get; set; }
            public string IE { get; set; }
            public string xNome { get; set; }
            public EnderFerro enderFerro { get; set; }
        }

        public class TrafMut
        {
            public string respFat { get; set; }
            public string ferrEmi { get; set; }
            public string vFrete { get; set; }
            public string chCTeFerroOrigem { get; set; }
            public IList<FerroEnv> ferroEnv { get; set; }
        }

        public class Ferrov
        {
            public string tpTraf { get; set; }
            public TrafMut trafMut { get; set; }
            public string fluxo { get; set; }
        }

        public class Duto
        {
            public string vTar { get; set; }
            public string dIni { get; set; }
            public string dFim { get; set; }
        }

        public class InfSeg
        {
            public string xSeg { get; set; }
            public string CNPJ { get; set; }
        }

        public class Seg
        {
            public InfSeg infSeg { get; set; }
            public string nApol { get; set; }
            public string nAver { get; set; }
        }

        public class Multimodal
        {
            public string COTM { get; set; }
            public string indNegociavel { get; set; }
            public Seg seg { get; set; }
        }

        public class InfModal
        {
            public string versaoModal { get; set; }
            public Rodo rodo { get; set; }
            public Aereo aereo { get; set; }
            public Aquav aquav { get; set; }
            public Ferrov ferrov { get; set; }
            public Duto duto { get; set; }
            public Multimodal multimodal { get; set; }
        }

        public class CTeJSON
        {
            public CTe CTe { get; set; }
            public InfModal infModal { get; set; }
        }

    }
