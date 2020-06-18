
using System.Collections.Generic;

namespace NSSuite_CSharp.src.JSON.BPe
{
    public class Ide
    {
        public string cUF { get; set; }
        public string tpAmb { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nBP { get; set; }
        public string cBP { get; set; }
        public string cDV { get; set; }
        public string modal { get; set; }
        public string dhEmi { get; set; }
        public string tpEmis { get; set; }
        public string verProc { get; set; }
        public string tpBPe { get; set; }
        public string indPres { get; set; }
        public string UFIni { get; set; }
        public string cMunIni { get; set; }
        public string UFFim { get; set; }
        public string cMunFim { get; set; }
        public string chCont { get; set; }
        public string xJust { get; set; }
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
        public string email { get; set; }
    }

    public class Emit
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string IEST { get; set; }
        public string xNome { get; set; }
        public string xFant { get; set; }
        public string IM { get; set; }
        public string CNAE { get; set; }
        public string CRT { get; set; }
        public EnderEmit enderEmit { get; set; }
        public string TAR { get; set; }
    }

    public class EnderComp
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
        public string fone { get; set; }
        public string email { get; set; }
    }

    public class Comp
    {
        public string tpComp { get; set; }
        public string vComp { get; set; }
        public string xNome { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string idEstrangeiro { get; set; }
        public string IE { get; set; }
        public EnderComp enderComp { get; set; }
    }

    public class EnderAgencia
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
        public string email { get; set; }
    }

    public class Agencia
    {
        public string xNome { get; set; }
        public string CNPJ { get; set; }
        public EnderAgencia enderAgencia { get; set; }
    }

    public class InfBPeSub
    {
        public string chBPe { get; set; }
        public string tpSub { get; set; }
    }

    public class InfPassageiro
    {
        public string xNome { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string tpDoc { get; set; }
        public string nDoc { get; set; }
        public string dNasc { get; set; }
        public string fone { get; set; }
        public string email { get; set; }
    }

    public class InfPassagem
    {
        public string cLocOrig { get; set; }
        public string xLocOrig { get; set; }
        public string cLocDest { get; set; }
        public string xLocDest { get; set; }
        public string dhEmb { get; set; }
        public string dhValidade { get; set; }
        public InfPassageiro infPassageiro { get; set; }
    }

    public class IdfTravessia
    {
        public string tpVeiculo { get; set; }
        public string sitVeiculo { get; set; }
    }

    public class InfViagem
    {
        public string cPercurso { get; set; }
        public string xPercurso { get; set; }
        public string tpViagem { get; set; }
        public string tpServ { get; set; }
        public string tpAcomodacao { get; set; }
        public string tpTrecho { get; set; }
        public string dhViagem { get; set; }
        public string dhConexao { get; set; }
        public string prefixo { get; set; }
        public string poltrona { get; set; }
        public string plataforma { get; set; }
        public IdfTravessia idfTravessia { get; set; }
    }

    public class InfValorBPe
    {
        public string vBP { get; set; }
        public string vDesconto { get; set; }
        public string vPgto { get; set; }
        public string vTroco { get; set; }
        public string tpDesconto { get; set; }
        public string xDesconto { get; set; }
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
        public string qRedBCOutraUF { get; set; }
        public string vBCOutraUF { get; set; }
        public string pICMSOutraUF { get; set; }
        public string vICMSOutraUF { get; set; }
    }

    public class ICMSSN
    {
        public string CST { get; set; }
        public string indSN { get; set; }
        public string vTotTrib { get; set; }
        public string infAdFisco { get; set; }
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

    public class ICMS
    {
        public ICMS00 ICMS00 { get; set; }
        public ICMS20 ICMS20 { get; set; }
        public ICMS45 ICMS45 { get; set; }
        public ICMS90 ICMS90 { get; set; }
        public ICMSOutraUF ICMSOutraUF { get; set; }
        public ICMSSN ICMSSN { get; set; }
        public ICMSUFFim ICMSUFFim { get; set; }
    }

    public class Imp
    {
        public ICMS ICMS { get; set; }
    }

    public class Card
    {
        public string tpIntegra { get; set; }
        public string CNPJ { get; set; }
        public string tBand { get; set; }
        public string cAut { get; set; }
    }

    public class Pag
    {
        public string tPag { get; set; }
        public string vPag { get; set; }
        public Card card { get; set; }
    }

    public class AutXML
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
    }

    public class InfAdic
    {
        public string infAdFisco { get; set; }
        public string infCpl { get; set; }
    }

    public class InfBPe
    {
        public string versao { get; set; }
        public Ide ide { get; set; }
        public Emit emit { get; set; }
        public Comp comp { get; set; }
        public Agencia agencia { get; set; }
        public InfBPeSub infBPeSub { get; set; }
        public InfPassagem infPassagem { get; set; }
        public IList<InfViagem> infViagem { get; set; }
        public InfValorBPe infValorBPe { get; set; }
        public Imp imp { get; set; }
        public IList<Pag> pag { get; set; }
        public IList<AutXML> autXML { get; set; }
        public InfAdic infAdic { get; set; }
    }

    public class BPe
    {
        public InfBPe infBPe { get; set; }
    }

    public class BPeJSON
    {
        public BPe BPe { get; set; }
    }


}
