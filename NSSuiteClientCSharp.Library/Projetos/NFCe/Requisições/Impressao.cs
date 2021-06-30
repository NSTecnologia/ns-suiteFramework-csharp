public class Impressao
{
    //https://docsnstecnologia.wpcomstaging.com/docs/ns-nfce/emissao-de-nfce/download/

    public string tipo { get; set; } = "PDF";

    //True ou False
    //Valor padrão: False
    public bool ecologica { get; set; } = false;
    
    //1 ou 2
    //Valor padrão: 1
    public string itemLinhas { get; set; } = "1";

    //True ou False
    //Valor padrão: True
    public bool itemDesconto { get; set; } = true;

    //58mm ou 80mm
    //Valor padrão: 80mm
    public string larguraPapel { get; set; } = "80mm";

    //Obrigatório para tipo = ESCPOS
    //Possíveis valores:BEMATECH MP-4200 TH,BEMATECH MP-2500 TH,DARUMA,EPSON T20,EPSON T70,ELGIN I9
    public string modMiniImpressora { get; set; } = null;
}
