using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using NSSuiteClientCSharp.Projetos._Genéricos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Schemas.NFSe
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Rps", IsNullable = false)]
    [JsonObject("Rps")]
    public partial class LayoutABRASF: JSON
    {
        [JsonProperty("InfRps", Required = Required.Always)]
        public TRpsInfRps InfRps { get; set; }

        public override string ToJSONString()
        {
            JObject root = JObject.FromObject(new { Rps = this });
            return JsonConvert.SerializeObject(root, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRps
    {
        [JsonProperty("IdentificacaoRps", Required = Required.Always)]
        public TRpsInfRpsIdentificacaoRps IdentificacaoRps { get; set; }

        [JsonProperty("DataEmissao", Required = Required.Always)]
        public string DataEmissao { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("NaturezaOpercao", Required = Required.Always)]
        public NaturezaOperacao NaturezaOpercao { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("RegimeEspecialTributacao", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public RegimeEspecialTributacao RegimeEspecialTributacao { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("OptanteSimplesNacional", Required = Required.Always)]
        public OptanteSimplesNacional OptanteSimplesNacional { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("IncentivadorCultural", Required = Required.Always)]
        public IncentivadorCultural IncentivadorCultural { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("Status", Required = Required.Always)]
        public Status Status { get; set; }

        [JsonProperty("RpsSubstituido", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsIdentificacaoRps RpsSubstituido { get; set; }

        [JsonProperty("Servico", Required = Required.Always)]
        public TRpsInfRpsServico Servico { get; set; }

        [JsonProperty("Prestador", Required = Required.Always)]
        public TRpsInfRpsPrestador Prestador { get; set; }

        [JsonProperty("Tomador", Required = Required.Always)]
        public TRpsInfRpsTomador Tomador { get; set; }

        [JsonProperty("IntermediarioServico", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsIntermediarioServico IntermediarioServico { get; set; }

        [JsonProperty("ConstrucaoCivil", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsConstrucaoCivil ConstrucaoCivil { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum NaturezaOperacao
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        TribMunicipio,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        TribForaMunicípio,

        [EnumMember(Value = "3")]
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Isencao,

        [EnumMember(Value = "4")]
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Imune,

        [EnumMember(Value = "5")]
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        ExigibilidadeSuspensaDecisaoJudicial,

        [EnumMember(Value = "6")]
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        ExigibilidadeSuspensaProcedimentoAdministrativo
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum RegimeEspecialTributacao
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        MicroempresaMunicipal,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Estimativa,

        [EnumMember(Value = "3")]
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        SociedadeProfissionais,

        [EnumMember(Value = "4")]
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Cooperativa,

        [EnumMember(Value = "5")]
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        MEI,

        [EnumMember(Value = "6")]
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        ME_EPP
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum OptanteSimplesNacional
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Sim,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Nao
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum IncentivadorCultural
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Sim,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Nao
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum Status
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Normal,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Cancelado
    }
   
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsIdentificacaoRps
    {
        [JsonProperty("Numero", Required = Required.Always)]
        public int Numero { get; set; }
       
        [JsonProperty("Serie", Required = Required.Always)]
        [DefaultValue(1)]
        public int Serie { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("Tipo", Required = Required.Always)]
        [DefaultValue(TipoRPS.RPS)]
        public TipoRPS Tipo { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum TipoRPS
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        RPS,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        NotaFiscalConjulgada,

        [EnumMember(Value = "3")]
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Cupom
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsServico
    {
        [JsonProperty("Valores", Required = Required.Always)]
        public TRpsInfRpsServicoValores Valores { get; set; }

        [JsonProperty("ItemListaServico", Required = Required.Always)]
        public string ItemListaServico { get; set; }

        [JsonProperty("CodigoCnae", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int CodigoCnae { get; set; }

        [JsonProperty("CodigoTributacaoMunicipio", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CodigoTributacaoMunicipio { get; set; }

        [JsonProperty("ItemListaSDiscriminacaoervico", Required = Required.Always)]
        public string ItemListaSDiscriminacaoervico { get; set; }

        [JsonProperty("CodigoMunicipio", Required = Required.Always)]
        public int CodigoMunicipio { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsServicoValores
    {
        [JsonProperty("ValorServicos", Required = Required.Always)]
        public string ValorServicos { get; set; }

        [JsonProperty("ValorDeducoes", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorDeducoes { get; set; }

        [JsonProperty("ValorPis", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorPis { get; set; }

        [JsonProperty("ValorCofins", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorCofins { get; set; }

        [JsonProperty("ValorInss", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorInss { get; set; }

        [JsonProperty("ValorIr", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorIr { get; set; }

        [JsonProperty("ValorCsll", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorCsll { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("IssRetido", Required = Required.Always)]
        public Retido IssRetido { get; set; }

        [JsonProperty("ValorIss", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorIss { get; set; }

        [JsonProperty("OutrasRetencoes", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string OutrasRetencoes { get; set; }

        [JsonProperty("BaseCalculo", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BaseCalculo { get; set; }

        [JsonProperty("Aliquota", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Aliquota { get; set; }

        [JsonProperty("ValorLiquidoNfse", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorLiquidoNfse { get; set; }

        [JsonProperty("ValorIssRetido", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ValorIssRetido { get; set; }

        [JsonProperty("DescontoCondicionado", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DescontoCondicionado { get; set; }

        [JsonProperty("DescontoIncondicionado", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DescontoIncondicionado { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum Retido
    {
        [EnumMember(Value = "1")]
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Sim,

        [EnumMember(Value = "2")]
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Nao
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsPrestador
    {
        [JsonProperty("Cnpj", Required = Required.Always)]
        public string CNPJ { get; set; }

        [JsonProperty("InscricaoMunicipal", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string IM { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsTomador
    {
        [JsonProperty("IdentificacaoTomador", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsTomadorIndentificao IdTomador { get; set; }

        [JsonProperty("RazaoSocial", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string RazaoSocial { get; set; }

        [JsonProperty("Endereco", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsTomadorEndereco Endereco { get; set; }

        [JsonProperty("Contato", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsTomadorContato Contato { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsTomadorIndentificao
    {
        [JsonProperty("CpfCnpj", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsTomadorIndentificaoCPFCNPJ Id { get; set; }

        [JsonProperty("InscricaoMunicipal", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string IM { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsTomadorIndentificaoCPFCNPJ
    {
        [JsonProperty("CPF", NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        [JsonProperty("CNPJ", NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsTomadorEndereco
    {
        [JsonProperty("Endereco", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Logradouro { get; set; }

        [JsonProperty("Numero", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Numero { get; set; }

        [JsonProperty("Complemento", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Complemento { get; set; }

        [JsonProperty("Bairro", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Bairro { get; set; }

        [JsonProperty("CodigoMunicipio", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int CodigoMunicipio { get; set; }

        [JsonProperty("Uf", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UF { get; set; }

        [JsonProperty("Cep", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CEP { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsTomadorContato
    {
        [JsonProperty("Telefone", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Telefone { get; set; }

        [JsonProperty("Email", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsIntermediarioServico
    {
        [JsonProperty("RazaoSocial", NullValueHandling = NullValueHandling.Ignore)]
        public string RazaoSocial { get; set; }

        [JsonProperty("CpfCnpj", NullValueHandling = NullValueHandling.Ignore)]
        public TRpsInfRpsIntermediarioServicoCPFCNPJ Id { get; set; }

        [JsonProperty("InscricaoMunicipal", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string IM { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsIntermediarioServicoCPFCNPJ
    {
        [JsonProperty("CPF", NullValueHandling = NullValueHandling.Ignore)]
        public string CPF { get; set; }

        [JsonProperty("CNPJ", NullValueHandling = NullValueHandling.Ignore)]
        public string CNPJ { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class TRpsInfRpsConstrucaoCivil
    {
        [JsonProperty("CodigoObra", Required = Required.Always)]
        public string CodigoObra { get; set; }

        [JsonProperty("Art", Required = Required.Always)]
        public string Art { get; set; }
    }
}
