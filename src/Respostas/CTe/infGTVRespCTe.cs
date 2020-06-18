public class InfGTVRespCTe
{
    public string status { get; set; }
    public string motivo { get; set; }
    public RetEventoCTe retEvento { get; set; }
    public Erros erros { get; set; }
}

public class Erros
{
    public string codigo { get; set; }
    public string descricao { get; set; }
}
