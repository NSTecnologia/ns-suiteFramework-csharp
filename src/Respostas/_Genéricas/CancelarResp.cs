using System.Collections.Generic;
public class CancelarResp
{
    public string status { get; set; }
    public string motivo { get; set; }
    public RetEvento retEvento { get; set; }
    public IList<string> erros { get; set; }
    public Erro erro { get; set; }
}
