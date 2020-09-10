public class Endpoints
{
    // BP-e
    public string BPeEnvio { get; set; } = "https://bpe.ns.eti.br/v1/bpe/issue";
    public string BPeConsStatusProcessamento { get; set; } = "https://bpe.ns.eti.br/v1/bpe/issue/status";
    public string BPeDownload { get; set; } = "https://bpe.ns.eti.br/v1/bpe/get";
    public string BPeDownloadEvento { get; set; } = "https://bpe.ns.eti.br/v1/bpe/get/event";
    public string BPeCancelamento { get; set; } = "https://bpe.ns.eti.br/v1/bpe/cancel";
    public string BPeNaoEmb { get; set; } = "https://bpe.ns.eti.br/v1/bpe/naoemb";
    public string BPeConsSit { get; set; } = "https://bpe.ns.eti.br/v1/bpe/status";

    // CT-e
    public string CTeEnvio { get; set; } = "https://cte.ns.eti.br/cte/issue";
    public string CTeOSEnvio { get; set; } = "https://cte.ns.eti.br/cte/issueos";
    public string CTeConsStatusProcessamento { get; set; } = "https://cte.ns.eti.br/cte/issueStatus/300";
    public string CTeDownload { get; set; } = "https://cte.ns.eti.br/cte/get/300";
    public string CTeDownloadEvento { get; set; } = "https://cte.ns.eti.br/cte/get/event/300";
    public string CTeCancelamento { get; set; } = "https://cte.ns.eti.br/cte/cancel/300";
    public string CTeCCe { get; set; } = "https://cte.ns.eti.br/cte/cce/300";
    public string CTeConsCad { get; set; } = "https://cte.ns.eti.br/util/conscad";
    public string CTeConsSit { get; set; } = "https://cte.ns.eti.br/cte/stats/300";
    public string CTeInfGTV { get; set; } = "https://cte.ns.eti.br/cte/gtv";
    public string CTeInutilizacao { get; set; } = "https://cte.ns.eti.br/cte/inut";
    public string CTeListarNSNRecs { get; set; } = "https://cte.ns.eti.br/util/list/nsnrecs";
    public string CTePrevia { get; set; } = "https://cte.ns.eti.br/util/previa/cte";
    public string CTeOSPrevia { get; set; } = "https://cte.ns.eti.br/util/previa/cteos";
    // MDF-e
    public string MDFeEnvio { get; set; } = "https://mdfe.ns.eti.br/mdfe/issue";
    public string MDFeConsStatusProcessamento { get; set; } = "https://mdfe.ns.eti.br/mdfe/issue/status";
    public string MDFeDownload { get; set; } = "https://mdfe.ns.eti.br/mdfe/get";
    public string MDFeDownloadEvento { get; set; } = "https://mdfe.ns.eti.br/mdfe/get/event";
    public string MDFeCancelamento { get; set; } = "https://mdfe.ns.eti.br/mdfe/cancel";
    public string MDFeEncerramento { get; set; } = "https://mdfe.ns.eti.br/mdfe/closure";
    public string MDFeIncCondutor { get; set; } = "https://mdfe.ns.eti.br/mdfe/adddriver";
    public string MDFeConsNaoEncerrados { get; set; } = "https://mdfe.ns.eti.br/util/consnotclosed";
    public string MDFeConsSit { get; set; } = "https://mdfe.ns.eti.br/mdfe/stats";
    public string MDFePrevia { get; set; } = "https://mdfe.ns.eti.br/util/preview/mdfe";
    public string MDFeListarNSNRecs { get; set; } = "https://mdfe.ns.eti.br/util/list/nsnrecs";

    // NFC-e
    public string NFCeEnvio { get; set; } = "https://nfce.ns.eti.br/v1/nfce/issue";
    public string NFCeDownload { get; set; } = "https://nfce.ns.eti.br/v1/nfce/get";
    public string NFCeCancelamento { get; set; } = "https://nfce.ns.eti.br/v1/nfce/cancel";
    public string NFCeConsSit { get; set; } = "https://nfce.ns.eti.br/v1/nfce/status";
    public string NFCeEnvioEmail { get; set; } = "https://nfce.ns.eti.br/v1/util/resendemail";
    public string NFCeInutilizacao { get; set; } = "https://nfce.ns.eti.br/v1/nfce/inut";
    public string NFCePrevia { get; set; } = "https://nfce.ns.eti.br/v1/util/preview/nfce";

    // NF-e
    public string NFeEnvio { get; set; } = "https://nfe.ns.eti.br/nfe/issue";
    public string NFeConsStatusProcessamento { get; set; } = "https://nfe.ns.eti.br/nfe/issue/status";
    public string NFeDownload { get; set; } = "https://nfe.ns.eti.br/nfe/get";
    public string NFeDownloadEvento { get; set; } = "https://nfe.ns.eti.br/nfe/get/event";
    public string NFeCancelamento { get; set; } = "https://nfe.ns.eti.br/nfe/cancel";
    public string NFeCCe { get; set; } = "https://nfe.ns.eti.br/nfe/cce";
    public string NFeConsStatusSefaz { get; set; } = "https://nfe.ns.eti.br/util/wssefazstatus";
    public string NFeConsCad { get; set; } = "https://nfe.ns.eti.br/util/conscad";
    public string NFeConsSit { get; set; } = "https://nfe.ns.eti.br/nfe/stats";
    public string NFeEnvioEmail { get; set; } = "https://nfe.ns.eti.br/util/resendemail";
    public string NFeInutilizacao { get; set; } = "https://nfe.ns.eti.br/nfe/inut";
    public string NFeListarNSNRecs { get; set; } = "https://nfe.ns.eti.br/util/list/nsnrecs";
    public string NFePrevia { get; set; } = "https://nfe.ns.eti.br/util/preview/nfe";
    public string NFeGerarPDFDeXML { get; set; } = "https://nfe.ns.eti.br/util/generatepdf";
    public string NFeGerarXMLEmissao { get; set; } = "https://nfe.ns.eti.br/util/generatexml";
    public string NFeGerarXMLCancelamento { get; set; } = "https://nfe.ns.eti.br/util/generatecancel";
    public string NFeGerarXMLCorrecao { get; set; } = "https://nfe.ns.eti.br/util/generatecce";
    public string NFeGerarXMLInut { get; set; } = "https://nfe.ns.eti.br/util/generateinut";


}
