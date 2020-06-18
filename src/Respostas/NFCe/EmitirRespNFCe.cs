using System.Collections.Generic;
public class EmitirRespNFCe
{
    public string status { get; set; }
    public string motivo { get; set; }
    public IList<string> erros { get; set; }
    public Erro erro { get; set; }
    public NfeProc nfeProc { get; set; }
}