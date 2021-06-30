using System.Collections.Generic;
public class ConsNaoEncerradosResp
{
    public string status { get; set; }
    public string motivo { get; set; }
    public IList<string> erros { get; set; }
    public Erro erro { get; set; }
}
