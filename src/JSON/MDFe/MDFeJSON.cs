using System.Collections.Generic;

namespace NSSuite_CSharp.src.JSON.MDFe
{
    public class InfMunCarrega
    {
        public string cMunCarrega { get; set; }
        public string xMunCarrega { get; set; }
    }

    public class InfPercurso
    {
        public string UFPer { get; set; }
    }

    public class Ide
    {
        public string cUF { get; set; }
        public string tpAmb { get; set; }
        public string tpEmit { get; set; }
        public string tpTransp { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nMDF { get; set; }
        public string cMDF { get; set; }
        public string cDV { get; set; }
        public string modal { get; set; }
        public string dhEmi { get; set; }
        public string tpEmis { get; set; }
        public string procEmi { get; set; }
        public string verProc { get; set; }
        public string UFIni { get; set; }
        public string UFFim { get; set; }
        public IList<InfMunCarrega> infMunCarrega { get; set; }
        public IList<InfPercurso> infPercurso { get; set; }
        public string dhIniViagem { get; set; }
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
        public string xNome { get; set; }
        public string xFant { get; set; }
        public EnderEmit enderEmit { get; set; }
    }

    public class InfCTe
    {
        public string chCTe { get; set; }
        public string SegCodBarra { get; set; }
        public string indReentrega { get; set; }
        public IList<InfUnidTransp> infUnidTransp { get; set; }
        public IList<Peri> peri { get; set; }
    }

    public class LacUnidCarga
    {
        public string nLacre { get; set; }
    }

    public class Peri
    {
        public string nONU { get; set; }
        public string xNomeAE { get; set; }
        public string xClaRisco { get; set; }
        public string grEmb { get; set; }
        public string qTotProd { get; set; }
        public string qVolTipo { get; set; }
    }

    public class InfNFe
    {
        public string chNFe { get; set; }
        public string SegCodBarra { get; set; }
        public string indReentrega { get; set; }
        public IList<InfUnidTransp> infUnidTransp { get; set; }
        public IList<Peri> peri { get; set; }
    }

    public class LacUnidTransp
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

    public class InfMDFeTransp
    {
        public string chMDFe { get; set; }
        public string indReentrega { get; set; }
        public IList<InfUnidTransp> infUnidTransp { get; set; }
        public IList<Peri> peri { get; set; }
    }

    public class InfMunDescarga
    {
        public string cMunDescarga { get; set; }
        public string xMunDescarga { get; set; }
        public IList<InfCTe> infCTe { get; set; }
        public IList<InfNFe> infNFe { get; set; }
        public IList<InfMDFeTransp> infMDFeTransp { get; set; }
    }

    public class InfDoc
    {
        public IList<InfMunDescarga> infMunDescarga { get; set; }
    }

    public class InfResp
    {
        public string respSeg { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
    }

    public class InfSeg
    {
        public string xSeg { get; set; }
        public string CNPJ { get; set; }
    }

    public class Seg
    {
        public InfResp infResp { get; set; }
        public InfSeg infSeg { get; set; }
        public string nApol { get; set; }
        public IList<string> nAver { get; set; }
    }

    public class Tot
    {
        public string qCTe { get; set; }
        public string qNFe { get; set; }
        public string qMDFe { get; set; }
        public string vCarga { get; set; }
        public string cUnid { get; set; }
        public string qCarga { get; set; }
    }

    public class Lacre
    {
        public string nLacre { get; set; }
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

    public class InfCIOT
    {
        public string CIOT { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
    }

    public class Disp
    {
        public string CNPJForn { get; set; }
        public string CNPJPg { get; set; }
        public string CPFPg { get; set; }
        public string nCompra { get; set; }
        public string vValePed { get; set; }
    }

    public class ValePed
    {
        public IList<Disp> disp { get; set; }
    }

    public class InfContratante
    {
        public string CPF { get; set; }
        public string CNPJ { get; set; }
    }

    public class InfANTT
    {
        public string RNTRC { get; set; }
        public IList<InfCIOT> infCIOT { get; set; }
        public ValePed valePed { get; set; }
        public IList<InfContratante> infContratante { get; set; }
    }

    public class Prop
    {
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string RNTRC { get; set; }
        public string xNome { get; set; }
        public string IE { get; set; }
        public string UF { get; set; }
        public string tpProp { get; set; }
    }

    public class Condutor
    {
        public string xNome { get; set; }
        public string CPF { get; set; }
    }

    public class VeicTracao
    {
        public string cInt { get; set; }
        public string placa { get; set; }
        public string RENAVAM { get; set; }
        public string tara { get; set; }
        public string capKG { get; set; }
        public string capM3 { get; set; }
        public Prop prop { get; set; }
        public IList<Condutor> condutor { get; set; }
        public string tpRod { get; set; }
        public string tpCar { get; set; }
        public string UF { get; set; }
    }

    public class VeicReboque
    {
        public string cInt { get; set; }
        public string placa { get; set; }
        public string RENAVAM { get; set; }
        public string tara { get; set; }
        public string capKG { get; set; }
        public string capM3 { get; set; }
        public Prop prop { get; set; }
        public string tpCar { get; set; }
        public string UF { get; set; }
    }

public class LacRodo
{
    public string nLacre { get; set; }
}

public class Rodo
{
    public InfANTT infANTT { get; set; }
    public VeicTracao veicTracao { get; set; }
    public IList<VeicReboque> veicReboque { get; set; }
    public string codAgPorto { get; set; }
    public IList<LacRodo> lacRodo { get; set; }
}

public class Aereo
{
    public string nac { get; set; }
    public string matr { get; set; }
    public string nVoo { get; set; }
    public string cAerEmb { get; set; }
    public string cAerDes { get; set; }
    public string dVoo { get; set; }
}

public class InfTermCarreg
{
    public string cTermCarreg { get; set; }
    public string xTermCarreg { get; set; }
}

public class InfTermDescarreg
{
    public string cTermDescarreg { get; set; }
    public string xTermDescarreg { get; set; }
}

public class InfEmbComb
{
    public string cEmbComb { get; set; }
    public string xBalsa { get; set; }
}

public class InfUnidCargaVazia
{
    public string idUnidCargaVazia { get; set; }
    public string tpUnidCargaVazia { get; set; }
}

public class InfUnidTranspVazia
{
    public string idUnidTranspVazia { get; set; }
    public string tpUnidTranspVazia { get; set; }
}

public class Aquav
{
    public string irin { get; set; }
    public string tpEmb { get; set; }
    public string cEmbar { get; set; }
    public string xEmbar { get; set; }
    public string nViag { get; set; }
    public string cPrtEmb { get; set; }
    public string cPrtDest { get; set; }
    public string prtTrans { get; set; }
    public string tpNav { get; set; }
    public IList<InfTermCarreg> infTermCarreg { get; set; }
    public IList<InfTermDescarreg> infTermDescarreg { get; set; }
    public IList<InfEmbComb> infEmbComb { get; set; }
    public IList<InfUnidCargaVazia> infUnidCargaVazia { get; set; }
    public IList<InfUnidTranspVazia> infUnidTranspVazia { get; set; }
}

public class Trem
{
    public string xPref { get; set; }
    public string dhTrem { get; set; }
    public string xOri { get; set; }
    public string xDest { get; set; }
    public string qVag { get; set; }
}

public class Vag
{
    public string pesoBC { get; set; }
    public string pesoR { get; set; }
    public string tpVag { get; set; }
    public string serie { get; set; }
    public string nVag { get; set; }
    public string nSeq { get; set; }
    public string TU { get; set; }
}

public class Ferrov
{
    public Trem trem { get; set; }
    public IList<Vag> vag { get; set; }
}

public class InfModal
{
    public Rodo rodo { get; set; }
    public Aereo aereo { get; set; }
    public Aquav aquav { get; set; }
    public Ferrov ferrov { get; set; }
    public string versaoModal { get; set; }
}

public class InfMDFe
{
    public string versao { get; set; }
    public string Id { get; set; }
    public Ide ide { get; set; }
    public Emit emit { get; set; }
    public InfDoc infDoc { get; set; }
    public IList<Seg> seg { get; set; }
    public Tot tot { get; set; }
    public IList<Lacre> lacres { get; set; }
    public IList<AutXML> autXML { get; set; }
    public InfAdic infAdic { get; set; }
    public InfModal infModal { get; set; }
}

public class MDFe
{
    public InfMDFe infMDFe { get; set; }
}

public class MDFeJSON
{
    public MDFe MDFe { get; set; }
}


}
