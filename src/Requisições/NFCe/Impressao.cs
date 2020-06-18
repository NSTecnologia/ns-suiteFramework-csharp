public class Impressao
{
    public string tipo { get; set; } = "PDF";
    public bool ecologica { get; set; } = false;
    public string itemLinhas { get; set; } = "1";
    public bool itemDesconto { get; set; } = true;
    public string larguraPapel { get; set; } = "80mm";
    public string modMiniImpressora { get; set; } = null;
}
