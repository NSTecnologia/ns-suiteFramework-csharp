using System.Collections;
using System.Collections.Generic;

public class PreviaResp
{
    public string status { get; set; }
    public string motivo { get; set; }
    public string pdf { get; set; }
    public IList<string> erros { get; set; }
}

