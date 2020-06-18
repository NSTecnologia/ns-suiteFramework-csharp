using System.Collections.Generic;
public class InfMDFe
{
    public string chMDFe { get; set; }
    public string nProt { get; set; }
}

public class RetConsMDFeNaoEnc
{
    public string tpAmb { get; set; }
    public string cStat { get; set; }
    public string xMotivo { get; set; }
    public string cUF { get; set; }
    public IList<InfMDFe> infMDFe { get; set; }
}

public class ConsNaoEncerradosRespMDFe : ConsNaoEncerradosResp
{
    public RetConsMDFeNaoEnc retConsMDFeNaoEnc { get; set; }
}
