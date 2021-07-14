using System.Collections.Generic;
public class EmitirResp
{
    public string status { get; set; }
    public string motivo { get; set; }
    public string xMotivo { get; set; }
    public IList<string> erros { get; set; }
    public Erro erro { get; set; }
    public string nsNRec { get; set; }
}