using System.Collections.Generic;

public class InfGTVReqCTe
{
    public string chCTe { get; set; }
    public string tpAmb { get; set; }
    public string dhEvento { get; set; }
    public string nSeqEvento { get; set; }
    public IList<InfGTV> infGTV { get; set; }
}

public class InfGTV
{
    public string nDoc { get; set; }
    public string id { get; set; }
    public string serie { get; set; }
    public string subserie { get; set; }
    public string dEmi { get; set; }
    public string nDV { get; set; }
    public string qCarga { get; set; }
    public string placa { get; set; }
    public string UF { get; set; }
    public string RNTRC { get; set; }
    public IList<InfEspecie> infEspecie { get; set; }
    public Rem rem { get; set; }
    public Dest dest { get; set; }
}

public class InfEspecie
{
    public string tpEspecie { get; set; }
    public string vEspecie { get; set; }
}

public class Rem
{
    public string CNPJ { get; set; }
    public string CPF { get; set; }
    public string IE { get; set; }
    public string UF { get; set; }
    public string xNome { get; set; }
}

public class Dest
{
    public string CNPJ { get; set; }
    public string CPF { get; set; }
    public string IE { get; set; }
    public string UF { get; set; }
    public string xNome { get; set; }
}
