namespace NSSuite_CSharp.src.Classes.NF3e
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    [System.Xml.Serialization.XmlRootAttribute("NF3e", Namespace = "http://www.portalfiscal.inf.br/nf3e", IsNullable = false)]
    public partial class TNF3e
    {

        private TNF3eInfNF3e infNF3eField;

        private TNF3eInfNF3eSupl infNF3eSuplField;

        private SignatureType signatureField;

        /// <remarks/>
        public TNF3eInfNF3e infNF3e
        {
            get
            {
                return this.infNF3eField;
            }
            set
            {
                this.infNF3eField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eSupl infNF3eSupl
        {
            get
            {
                return this.infNF3eSuplField;
            }
            set
            {
                this.infNF3eSuplField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3e
    {

        private TNF3eInfNF3eIde ideField;

        private TNF3eInfNF3eEmit emitField;

        private TNF3eInfNF3eDest destField;

        private TNF3eInfNF3eAcessante acessanteField;

        private TNF3eInfNF3eGSub gSubField;

        private TNF3eInfNF3eGJudic gJudicField;

        private TNF3eInfNF3eGGrContrat[] gGrContratField;

        private TNF3eInfNF3eGMed[] gMedField;

        private TNF3eInfNF3eGSCEE gSCEEField;

        private TNF3eInfNF3eNFdet[] nFdetField;

        private TNF3eInfNF3eTotal totalField;

        private TNF3eInfNF3eGFat gFatField;

        private TANEELGHistFat[] gANEELField;

        private TNF3eInfNF3eAutXML[] autXMLField;

        private TNF3eInfNF3eInfAdic infAdicField;

        private TRespTec gRespTecField;

        private string versaoField;

        private string idField;

        /// <remarks/>
        public TNF3eInfNF3eIde ide
        {
            get
            {
                return this.ideField;
            }
            set
            {
                this.ideField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eEmit emit
        {
            get
            {
                return this.emitField;
            }
            set
            {
                this.emitField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eDest dest
        {
            get
            {
                return this.destField;
            }
            set
            {
                this.destField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eAcessante acessante
        {
            get
            {
                return this.acessanteField;
            }
            set
            {
                this.acessanteField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eGSub gSub
        {
            get
            {
                return this.gSubField;
            }
            set
            {
                this.gSubField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eGJudic gJudic
        {
            get
            {
                return this.gJudicField;
            }
            set
            {
                this.gJudicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gGrContrat")]
        public TNF3eInfNF3eGGrContrat[] gGrContrat
        {
            get
            {
                return this.gGrContratField;
            }
            set
            {
                this.gGrContratField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gMed")]
        public TNF3eInfNF3eGMed[] gMed
        {
            get
            {
                return this.gMedField;
            }
            set
            {
                this.gMedField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eGSCEE gSCEE
        {
            get
            {
                return this.gSCEEField;
            }
            set
            {
                this.gSCEEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NFdet")]
        public TNF3eInfNF3eNFdet[] NFdet
        {
            get
            {
                return this.nFdetField;
            }
            set
            {
                this.nFdetField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eTotal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eGFat gFat
        {
            get
            {
                return this.gFatField;
            }
            set
            {
                this.gFatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("gHistFat", IsNullable = false)]
        public TANEELGHistFat[] gANEEL
        {
            get
            {
                return this.gANEELField;
            }
            set
            {
                this.gANEELField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TNF3eInfNF3eAutXML[] autXML
        {
            get
            {
                return this.autXMLField;
            }
            set
            {
                this.autXMLField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eInfAdic infAdic
        {
            get
            {
                return this.infAdicField;
            }
            set
            {
                this.infAdicField = value;
            }
        }

        /// <remarks/>
        public TRespTec gRespTec
        {
            get
            {
                return this.gRespTecField;
            }
            set
            {
                this.gRespTecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eIde
    {

        private TCodUfIBGE cUFField;

        private TAmb tpAmbField;

        private TModNF3e modField;

        private string serieField;

        private string nNFField;

        private string cNFField;

        private string cDVField;

        private string dhEmiField;

        private TtpEmis tpEmisField;

        private string cMunFGField;

        private TFinNF3e finNF3eField;

        private string verProcField;

        private string dhContField;

        private string xJustField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public TModNF3e mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        /// <remarks/>
        public string cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        /// <remarks/>
        public string cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        /// <remarks/>
        public string dhEmi
        {
            get
            {
                return this.dhEmiField;
            }
            set
            {
                this.dhEmiField = value;
            }
        }

        /// <remarks/>
        public TtpEmis tpEmis
        {
            get
            {
                return this.tpEmisField;
            }
            set
            {
                this.tpEmisField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        /// <remarks/>
        public TFinNF3e finNF3e
        {
            get
            {
                return this.finNF3eField;
            }
            set
            {
                this.finNF3eField = value;
            }
        }

        /// <remarks/>
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }

        /// <remarks/>
        public string dhCont
        {
            get
            {
                return this.dhContField;
            }
            set
            {
                this.dhContField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TCodUfIBGE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TAmb
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TModNF3e
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TtpEmis
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TFinNF3e
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eEmit
    {

        private string cNPJField;

        private string ieField;

        private string xNomeField;

        private string xFantField;

        private TEndeEmi enderEmitField;

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        /// <remarks/>
        public TEndeEmi enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TEndeEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private string cEPField;

        private TUf_sem_EX ufField;

        private string foneField;

        private string emailField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        /// <remarks/>
        public TUf_sem_EX UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TUf_sem_EX
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eDest
    {

        private string xNomeField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private TIndIEDest indIEDestField;

        private string ieField;

        private string imField;

        private string item1Field;

        private Item1ChoiceType item1ElementNameField;

        private string xNomeAdicionalField;

        private TEndeEmi enderDestField;

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("idOutros", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public TIndIEDest indIEDest
        {
            get
            {
                return this.indIEDestField;
            }
            set
            {
                this.indIEDestField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NB", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("cNIS", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public string Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName
        {
            get
            {
                return this.item1ElementNameField;
            }
            set
            {
                this.item1ElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNomeAdicional
        {
            get
            {
                return this.xNomeAdicionalField;
            }
            set
            {
                this.xNomeAdicionalField = value;
            }
        }

        /// <remarks/>
        public TEndeEmi enderDest
        {
            get
            {
                return this.enderDestField;
            }
            set
            {
                this.enderDestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        idOutros,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TIndIEDest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e", IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        NB,

        /// <remarks/>
        cNIS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eAcessante
    {

        private string idAcessoField;

        private string idCodClienteField;

        private TAcessante tpAcessoField;

        private string xNomeUCField;

        private TClasse tpClasseField;

        private bool tpClasseFieldSpecified;

        private TSubClasse tpSubClasseField;

        private bool tpSubClasseFieldSpecified;

        private TFase tpFaseField;

        private TGrpTensao tpGrpTensaoField;

        private TModTar tpModTarField;

        private string latGPSField;

        private string longGPSField;

        private string codRoteiroLeituraField;

        /// <remarks/>
        public string idAcesso
        {
            get
            {
                return this.idAcessoField;
            }
            set
            {
                this.idAcessoField = value;
            }
        }

        /// <remarks/>
        public string idCodCliente
        {
            get
            {
                return this.idCodClienteField;
            }
            set
            {
                this.idCodClienteField = value;
            }
        }

        /// <remarks/>
        public TAcessante tpAcesso
        {
            get
            {
                return this.tpAcessoField;
            }
            set
            {
                this.tpAcessoField = value;
            }
        }

        /// <remarks/>
        public string xNomeUC
        {
            get
            {
                return this.xNomeUCField;
            }
            set
            {
                this.xNomeUCField = value;
            }
        }

        /// <remarks/>
        public TClasse tpClasse
        {
            get
            {
                return this.tpClasseField;
            }
            set
            {
                this.tpClasseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpClasseSpecified
        {
            get
            {
                return this.tpClasseFieldSpecified;
            }
            set
            {
                this.tpClasseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TSubClasse tpSubClasse
        {
            get
            {
                return this.tpSubClasseField;
            }
            set
            {
                this.tpSubClasseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpSubClasseSpecified
        {
            get
            {
                return this.tpSubClasseFieldSpecified;
            }
            set
            {
                this.tpSubClasseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TFase tpFase
        {
            get
            {
                return this.tpFaseField;
            }
            set
            {
                this.tpFaseField = value;
            }
        }

        /// <remarks/>
        public TGrpTensao tpGrpTensao
        {
            get
            {
                return this.tpGrpTensaoField;
            }
            set
            {
                this.tpGrpTensaoField = value;
            }
        }

        /// <remarks/>
        public TModTar tpModTar
        {
            get
            {
                return this.tpModTarField;
            }
            set
            {
                this.tpModTarField = value;
            }
        }

        /// <remarks/>
        public string latGPS
        {
            get
            {
                return this.latGPSField;
            }
            set
            {
                this.latGPSField = value;
            }
        }

        /// <remarks/>
        public string longGPS
        {
            get
            {
                return this.longGPSField;
            }
            set
            {
                this.longGPSField = value;
            }
        }

        /// <remarks/>
        public string codRoteiroLeitura
        {
            get
            {
                return this.codRoteiroLeituraField;
            }
            set
            {
                this.codRoteiroLeituraField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TAcessante
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TClasse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TSubClasse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TFase
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TGrpTensao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TModTar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGSub
    {

        private object itemField;

        private TMotSub motSubField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("chNF3e", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("gNF", typeof(TNF3eInfNF3eGSubGNF))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public TMotSub motSub
        {
            get
            {
                return this.motSubField;
            }
            set
            {
                this.motSubField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGSubGNF
    {

        private string cNPJField;

        private string serieField;

        private string nNFField;

        private string competEmisField;

        private string competApurField;

        private byte[] hash115Field;

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        /// <remarks/>
        public string CompetEmis
        {
            get
            {
                return this.competEmisField;
            }
            set
            {
                this.competEmisField = value;
            }
        }

        /// <remarks/>
        public string CompetApur
        {
            get
            {
                return this.competApurField;
            }
            set
            {
                this.competApurField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] hash115
        {
            get
            {
                return this.hash115Field;
            }
            set
            {
                this.hash115Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TMotSub
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGJudic
    {

        private string chNF3eField;

        /// <remarks/>
        public string chNF3e
        {
            get
            {
                return this.chNF3eField;
            }
            set
            {
                this.chNF3eField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGGrContrat
    {

        private TGrContrat tpGrContratField;

        private TPosTarSimples tpPosTarField;

        private string qUnidContratField;

        private string nContratField;

        /// <remarks/>
        public TGrContrat tpGrContrat
        {
            get
            {
                return this.tpGrContratField;
            }
            set
            {
                this.tpGrContratField = value;
            }
        }

        /// <remarks/>
        public TPosTarSimples tpPosTar
        {
            get
            {
                return this.tpPosTarField;
            }
            set
            {
                this.tpPosTarField = value;
            }
        }

        /// <remarks/>
        public string qUnidContrat
        {
            get
            {
                return this.qUnidContratField;
            }
            set
            {
                this.qUnidContratField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nContrat
        {
            get
            {
                return this.nContratField;
            }
            set
            {
                this.nContratField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TGrContrat
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TPosTarSimples
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGMed
    {

        private string idMedidorField;

        private string dMedAntField;

        private string dMedAtuField;

        private string nMedField;

        /// <remarks/>
        public string idMedidor
        {
            get
            {
                return this.idMedidorField;
            }
            set
            {
                this.idMedidorField = value;
            }
        }

        /// <remarks/>
        public string dMedAnt
        {
            get
            {
                return this.dMedAntField;
            }
            set
            {
                this.dMedAntField = value;
            }
        }

        /// <remarks/>
        public string dMedAtu
        {
            get
            {
                return this.dMedAtuField;
            }
            set
            {
                this.dMedAtuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nMed
        {
            get
            {
                return this.nMedField;
            }
            set
            {
                this.nMedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGSCEE
    {

        private TPartComp tpPartCompField;

        private TNF3eInfNF3eGSCEEGConsumidor[] gConsumidorField;

        private TNF3eInfNF3eGSCEEGSaldoCred[] gSaldoCredField;

        /// <remarks/>
        public TPartComp tpPartComp
        {
            get
            {
                return this.tpPartCompField;
            }
            set
            {
                this.tpPartCompField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gConsumidor")]
        public TNF3eInfNF3eGSCEEGConsumidor[] gConsumidor
        {
            get
            {
                return this.gConsumidorField;
            }
            set
            {
                this.gConsumidorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gSaldoCred")]
        public TNF3eInfNF3eGSCEEGSaldoCred[] gSaldoCred
        {
            get
            {
                return this.gSaldoCredField;
            }
            set
            {
                this.gSaldoCredField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TPartComp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGSCEEGConsumidor
    {

        private string idAcessGerField;

        private string vPotInstField;

        private TFonteEnergia tpFonteEnergiaField;

        private string[] enerAlocField;

        private TPosTarSimples[] tpPosTarField;

        /// <remarks/>
        public string idAcessGer
        {
            get
            {
                return this.idAcessGerField;
            }
            set
            {
                this.idAcessGerField = value;
            }
        }

        /// <remarks/>
        public string vPotInst
        {
            get
            {
                return this.vPotInstField;
            }
            set
            {
                this.vPotInstField = value;
            }
        }

        /// <remarks/>
        public TFonteEnergia tpFonteEnergia
        {
            get
            {
                return this.tpFonteEnergiaField;
            }
            set
            {
                this.tpFonteEnergiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("enerAloc")]
        public string[] enerAloc
        {
            get
            {
                return this.enerAlocField;
            }
            set
            {
                this.enerAlocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tpPosTar")]
        public TPosTarSimples[] tpPosTar
        {
            get
            {
                return this.tpPosTarField;
            }
            set
            {
                this.tpPosTarField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TFonteEnergia
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGSCEEGSaldoCred
    {

        private TPosTarSimples tpPosTarField;

        private string vSaldAntField;

        private string vCredExpiradoField;

        private string vSaldAtualField;

        private string vCredExpirarField;

        private string competExpirarField;

        /// <remarks/>
        public TPosTarSimples tpPosTar
        {
            get
            {
                return this.tpPosTarField;
            }
            set
            {
                this.tpPosTarField = value;
            }
        }

        /// <remarks/>
        public string vSaldAnt
        {
            get
            {
                return this.vSaldAntField;
            }
            set
            {
                this.vSaldAntField = value;
            }
        }

        /// <remarks/>
        public string vCredExpirado
        {
            get
            {
                return this.vCredExpiradoField;
            }
            set
            {
                this.vCredExpiradoField = value;
            }
        }

        /// <remarks/>
        public string vSaldAtual
        {
            get
            {
                return this.vSaldAtualField;
            }
            set
            {
                this.vSaldAtualField = value;
            }
        }

        /// <remarks/>
        public string vCredExpirar
        {
            get
            {
                return this.vCredExpirarField;
            }
            set
            {
                this.vCredExpirarField = value;
            }
        }

        /// <remarks/>
        public string CompetExpirar
        {
            get
            {
                return this.competExpirarField;
            }
            set
            {
                this.competExpirarField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdet
    {

        private TNF3eInfNF3eNFdetDet[] detField;

        private string chNF3eAntField;

        private byte[] mod6HashAntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("det")]
        public TNF3eInfNF3eNFdetDet[] det
        {
            get
            {
                return this.detField;
            }
            set
            {
                this.detField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string chNF3eAnt
        {
            get
            {
                return this.chNF3eAntField;
            }
            set
            {
                this.chNF3eAntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] mod6HashAnt
        {
            get
            {
                return this.mod6HashAntField;
            }
            set
            {
                this.mod6HashAntField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDet
    {

        private TNF3eInfNF3eNFdetDetGAjusteNF3eAnt gAjusteNF3eAntField;

        private object itemField;

        private string nItemField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetGAjusteNF3eAnt gAjusteNF3eAnt
        {
            get
            {
                return this.gAjusteNF3eAntField;
            }
            set
            {
                this.gAjusteNF3eAntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detItem", typeof(TNF3eInfNF3eNFdetDetDetItem))]
        [System.Xml.Serialization.XmlElementAttribute("detItemAnt", typeof(TNF3eInfNF3eNFdetDetDetItemAnt))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItem
        {
            get
            {
                return this.nItemField;
            }
            set
            {
                this.nItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetGAjusteNF3eAnt
    {

        private TAjusteNF3eAnt tpAjusteField;

        private TMotAjuste motAjusteField;

        /// <remarks/>
        public TAjusteNF3eAnt tpAjuste
        {
            get
            {
                return this.tpAjusteField;
            }
            set
            {
                this.tpAjusteField = value;
            }
        }

        /// <remarks/>
        public TMotAjuste motAjuste
        {
            get
            {
                return this.motAjusteField;
            }
            set
            {
                this.motAjusteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TAjusteNF3eAnt
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TMotAjuste
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItem
    {

        private TNF3eInfNF3eNFdetDetDetItemGTarif[] gTarifField;

        private TNF3eInfNF3eNFdetDetDetItemGAdBand[] gAdBandField;

        private TNF3eInfNF3eNFdetDetDetItemProd prodField;

        private TNF3eInfNF3eNFdetDetDetItemImposto impostoField;

        private TNF3eInfNF3eNFdetDetDetItemGProcRef gProcRefField;

        private TNF3eInfNF3eNFdetDetDetItemGContab[] gContabField;

        private string infAdProdField;

        private string nItemAntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gTarif")]
        public TNF3eInfNF3eNFdetDetDetItemGTarif[] gTarif
        {
            get
            {
                return this.gTarifField;
            }
            set
            {
                this.gTarifField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gAdBand")]
        public TNF3eInfNF3eNFdetDetDetItemGAdBand[] gAdBand
        {
            get
            {
                return this.gAdBandField;
            }
            set
            {
                this.gAdBandField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemProd prod
        {
            get
            {
                return this.prodField;
            }
            set
            {
                this.prodField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImposto imposto
        {
            get
            {
                return this.impostoField;
            }
            set
            {
                this.impostoField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemGProcRef gProcRef
        {
            get
            {
                return this.gProcRefField;
            }
            set
            {
                this.gProcRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gContab")]
        public TNF3eInfNF3eNFdetDetDetItemGContab[] gContab
        {
            get
            {
                return this.gContabField;
            }
            set
            {
                this.gContabField = value;
            }
        }

        /// <remarks/>
        public string infAdProd
        {
            get
            {
                return this.infAdProdField;
            }
            set
            {
                this.infAdProdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItemAnt
        {
            get
            {
                return this.nItemAntField;
            }
            set
            {
                this.nItemAntField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemGTarif
    {

        private string dIniTarifField;

        private string dFimTarifField;

        private TAtoANEEL tpAtoField;

        private string nAtoField;

        private string anoAtoField;

        private TTarifa tpTarifField;

        private TPosTarifCompleto cPosTarifField;

        private TNF3eInfNF3eNFdetDetDetItemGTarifUMed uMedField;

        private string vTarifHomField;

        private string vTarifAplicField;

        private TNF3eInfNF3eNFdetDetDetItemGTarifMotDifTarif motDifTarifField;

        /// <remarks/>
        public string dIniTarif
        {
            get
            {
                return this.dIniTarifField;
            }
            set
            {
                this.dIniTarifField = value;
            }
        }

        /// <remarks/>
        public string dFimTarif
        {
            get
            {
                return this.dFimTarifField;
            }
            set
            {
                this.dFimTarifField = value;
            }
        }

        /// <remarks/>
        public TAtoANEEL tpAto
        {
            get
            {
                return this.tpAtoField;
            }
            set
            {
                this.tpAtoField = value;
            }
        }

        /// <remarks/>
        public string nAto
        {
            get
            {
                return this.nAtoField;
            }
            set
            {
                this.nAtoField = value;
            }
        }

        /// <remarks/>
        public string anoAto
        {
            get
            {
                return this.anoAtoField;
            }
            set
            {
                this.anoAtoField = value;
            }
        }

        /// <remarks/>
        public TTarifa tpTarif
        {
            get
            {
                return this.tpTarifField;
            }
            set
            {
                this.tpTarifField = value;
            }
        }

        /// <remarks/>
        public TPosTarifCompleto cPosTarif
        {
            get
            {
                return this.cPosTarifField;
            }
            set
            {
                this.cPosTarifField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemGTarifUMed uMed
        {
            get
            {
                return this.uMedField;
            }
            set
            {
                this.uMedField = value;
            }
        }

        /// <remarks/>
        public string vTarifHom
        {
            get
            {
                return this.vTarifHomField;
            }
            set
            {
                this.vTarifHomField = value;
            }
        }

        /// <remarks/>
        public string vTarifAplic
        {
            get
            {
                return this.vTarifAplicField;
            }
            set
            {
                this.vTarifAplicField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemGTarifMotDifTarif motDifTarif
        {
            get
            {
                return this.motDifTarifField;
            }
            set
            {
                this.motDifTarifField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TAtoANEEL
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TTarifa
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TPosTarifCompleto
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemGTarifUMed
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemGTarifMotDifTarif
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemGAdBand
    {

        private string dIniAdBandField;

        private string dFimAdBandField;

        private TBand tpBandField;

        private string vAdBandField;

        private string vAdBandAplicField;

        private TNF3eInfNF3eNFdetDetDetItemGAdBandMotDifBand motDifBandField;

        /// <remarks/>
        public string dIniAdBand
        {
            get
            {
                return this.dIniAdBandField;
            }
            set
            {
                this.dIniAdBandField = value;
            }
        }

        /// <remarks/>
        public string dFimAdBand
        {
            get
            {
                return this.dFimAdBandField;
            }
            set
            {
                this.dFimAdBandField = value;
            }
        }

        /// <remarks/>
        public TBand tpBand
        {
            get
            {
                return this.tpBandField;
            }
            set
            {
                this.tpBandField = value;
            }
        }

        /// <remarks/>
        public string vAdBand
        {
            get
            {
                return this.vAdBandField;
            }
            set
            {
                this.vAdBandField = value;
            }
        }

        /// <remarks/>
        public string vAdBandAplic
        {
            get
            {
                return this.vAdBandAplicField;
            }
            set
            {
                this.vAdBandAplicField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemGAdBandMotDifBand motDifBand
        {
            get
            {
                return this.motDifBandField;
            }
            set
            {
                this.motDifBandField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TBand
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemGAdBandMotDifBand
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemProd
    {

        private TOrigemQtd indOrigemQtdField;

        private TNF3eInfNF3eNFdetDetDetItemProdGMedicao gMedicaoField;

        private string cProdField;

        private string xProdField;

        private string cClassField;

        private string cFOPField;

        private TUMedItem uMedField;

        private string qFaturadaField;

        private string vItemField;

        private string vProdField;

        private TNF3eInfNF3eNFdetDetDetItemProdIndDevolucao indDevolucaoField;

        private bool indDevolucaoFieldSpecified;

        private TNF3eInfNF3eNFdetDetDetItemProdIndPrecoACL indPrecoACLField;

        private bool indPrecoACLFieldSpecified;

        /// <remarks/>
        public TOrigemQtd indOrigemQtd
        {
            get
            {
                return this.indOrigemQtdField;
            }
            set
            {
                this.indOrigemQtdField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemProdGMedicao gMedicao
        {
            get
            {
                return this.gMedicaoField;
            }
            set
            {
                this.gMedicaoField = value;
            }
        }

        /// <remarks/>
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        /// <remarks/>
        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        /// <remarks/>
        public string cClass
        {
            get
            {
                return this.cClassField;
            }
            set
            {
                this.cClassField = value;
            }
        }

        /// <remarks/>
        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        /// <remarks/>
        public TUMedItem uMed
        {
            get
            {
                return this.uMedField;
            }
            set
            {
                this.uMedField = value;
            }
        }

        /// <remarks/>
        public string qFaturada
        {
            get
            {
                return this.qFaturadaField;
            }
            set
            {
                this.qFaturadaField = value;
            }
        }

        /// <remarks/>
        public string vItem
        {
            get
            {
                return this.vItemField;
            }
            set
            {
                this.vItemField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemProdIndDevolucao indDevolucao
        {
            get
            {
                return this.indDevolucaoField;
            }
            set
            {
                this.indDevolucaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indDevolucaoSpecified
        {
            get
            {
                return this.indDevolucaoFieldSpecified;
            }
            set
            {
                this.indDevolucaoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemProdIndPrecoACL indPrecoACL
        {
            get
            {
                return this.indPrecoACLField;
            }
            set
            {
                this.indPrecoACLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indPrecoACLSpecified
        {
            get
            {
                return this.indPrecoACLFieldSpecified;
            }
            set
            {
                this.indPrecoACLFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TOrigemQtd
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemProdGMedicao
    {

        private string nMedField;

        private string nContratField;

        private object itemField;

        /// <remarks/>
        public string nMed
        {
            get
            {
                return this.nMedField;
            }
            set
            {
                this.nMedField = value;
            }
        }

        /// <remarks/>
        public string nContrat
        {
            get
            {
                return this.nContratField;
            }
            set
            {
                this.nContratField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gMedida", typeof(TMedida))]
        [System.Xml.Serialization.XmlElementAttribute("tpMotNaoLeitura", typeof(TMotNaoLeitura))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TMedida
    {

        private TGrMed tpGrMedField;

        private TPosTarifCompleto cPosTarifField;

        private TUMed uMedField;

        private string vMedAntField;

        private string vMedAtuField;

        private string vConstField;

        private string vMedField;

        private string pPerdaTranField;

        private string vMedPerdaTranField;

        private string vMedPerdaTecField;

        /// <remarks/>
        public TGrMed tpGrMed
        {
            get
            {
                return this.tpGrMedField;
            }
            set
            {
                this.tpGrMedField = value;
            }
        }

        /// <remarks/>
        public TPosTarifCompleto cPosTarif
        {
            get
            {
                return this.cPosTarifField;
            }
            set
            {
                this.cPosTarifField = value;
            }
        }

        /// <remarks/>
        public TUMed uMed
        {
            get
            {
                return this.uMedField;
            }
            set
            {
                this.uMedField = value;
            }
        }

        /// <remarks/>
        public string vMedAnt
        {
            get
            {
                return this.vMedAntField;
            }
            set
            {
                this.vMedAntField = value;
            }
        }

        /// <remarks/>
        public string vMedAtu
        {
            get
            {
                return this.vMedAtuField;
            }
            set
            {
                this.vMedAtuField = value;
            }
        }

        /// <remarks/>
        public string vConst
        {
            get
            {
                return this.vConstField;
            }
            set
            {
                this.vConstField = value;
            }
        }

        /// <remarks/>
        public string vMed
        {
            get
            {
                return this.vMedField;
            }
            set
            {
                this.vMedField = value;
            }
        }

        /// <remarks/>
        public string pPerdaTran
        {
            get
            {
                return this.pPerdaTranField;
            }
            set
            {
                this.pPerdaTranField = value;
            }
        }

        /// <remarks/>
        public string vMedPerdaTran
        {
            get
            {
                return this.vMedPerdaTranField;
            }
            set
            {
                this.vMedPerdaTranField = value;
            }
        }

        /// <remarks/>
        public string vMedPerdaTec
        {
            get
            {
                return this.vMedPerdaTecField;
            }
            set
            {
                this.vMedPerdaTecField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TGrMed
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TUMed
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TMotNaoLeitura
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TUMedItem
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemProdIndDevolucao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemProdIndPrecoACL
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImposto : TImp
    {

        private object itemField;

        private TNF3eInfNF3eNFdetDetDetItemImpostoPIS pISField;

        private TNF3eInfNF3eNFdetDetDetItemImpostoPISEfet pISEfetField;

        private TNF3eInfNF3eNFdetDetDetItemImpostoCOFINS cOFINSField;

        private TNF3eInfNF3eNFdetDetDetItemImpostoCOFINSEfet cOFINSEfetField;

        private TNF3eInfNF3eNFdetDetDetItemImpostoRetTrib retTribField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNF3eInfNF3eNFdetDetDetItemImpostoICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNF3eInfNF3eNFdetDetDetItemImpostoICMS10))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNF3eInfNF3eNFdetDetDetItemImpostoICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNF3eInfNF3eNFdetDetDetItemImpostoICMS40))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNF3eInfNF3eNFdetDetDetItemImpostoICMS51))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNF3eInfNF3eNFdetDetDetItemImpostoICMS90))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoPIS PIS
        {
            get
            {
                return this.pISField;
            }
            set
            {
                this.pISField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoPISEfet PISEfet
        {
            get
            {
                return this.pISEfetField;
            }
            set
            {
                this.pISEfetField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoCOFINS COFINS
        {
            get
            {
                return this.cOFINSField;
            }
            set
            {
                this.cOFINSField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoCOFINSEfet COFINSEfet
        {
            get
            {
                return this.cOFINSEfetField;
            }
            set
            {
                this.cOFINSEfetField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoRetTrib retTrib
        {
            get
            {
                return this.retTribField;
            }
            set
            {
                this.retTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoICMS00
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoICMS00CST cSTField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string pFCPField;

        private string vFCPField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoICMS00CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        /// <remarks/>
        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoICMS00CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoICMS10
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoICMS10CST cSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pFCPSTField;

        private string vFCPSTField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoICMS10CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pFCPST
        {
            get
            {
                return this.pFCPSTField;
            }
            set
            {
                this.pFCPSTField = value;
            }
        }

        /// <remarks/>
        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoICMS10CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoICMS20
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoICMS20CST cSTField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string vICMSDesonField;

        private string cBenefField;

        private string pFCPField;

        private string vFCPField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoICMS20CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public string cBenef
        {
            get
            {
                return this.cBenefField;
            }
            set
            {
                this.cBenefField = value;
            }
        }

        /// <remarks/>
        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        /// <remarks/>
        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoICMS20CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoICMS40
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoICMS40CST cSTField;

        private string vICMSDesonField;

        private string cBenefField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoICMS40CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public string cBenef
        {
            get
            {
                return this.cBenefField;
            }
            set
            {
                this.cBenefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoICMS40CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoICMS51
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoICMS51CST cSTField;

        private string vICMSDesonField;

        private string cBenefField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoICMS51CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public string cBenef
        {
            get
            {
                return this.cBenefField;
            }
            set
            {
                this.cBenefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoICMS51CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoICMS90
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoICMS90CST cSTField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoICMS90CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoICMS90CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoPIS
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoPISCST cSTField;

        private string vBCField;

        private string pPISField;

        private string vPISField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoPISCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoPISCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoPISEfet
    {

        private string vBCPISEfetField;

        private string pPISEfetField;

        private string vPISEfetField;

        /// <remarks/>
        public string vBCPISEfet
        {
            get
            {
                return this.vBCPISEfetField;
            }
            set
            {
                this.vBCPISEfetField = value;
            }
        }

        /// <remarks/>
        public string pPISEfet
        {
            get
            {
                return this.pPISEfetField;
            }
            set
            {
                this.pPISEfetField = value;
            }
        }

        /// <remarks/>
        public string vPISEfet
        {
            get
            {
                return this.vPISEfetField;
            }
            set
            {
                this.vPISEfetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoCOFINS
    {

        private TNF3eInfNF3eNFdetDetDetItemImpostoCOFINSCST cSTField;

        private string vBCField;

        private string pCOFINSField;

        private string vCOFINSField;

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemImpostoCOFINSCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pCOFINS
        {
            get
            {
                return this.pCOFINSField;
            }
            set
            {
                this.pCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemImpostoCOFINSCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoCOFINSEfet
    {

        private string vBCCOFINSEfetField;

        private string pCOFINSEfetField;

        private string vCOFINSEfetField;

        /// <remarks/>
        public string vBCCOFINSEfet
        {
            get
            {
                return this.vBCCOFINSEfetField;
            }
            set
            {
                this.vBCCOFINSEfetField = value;
            }
        }

        /// <remarks/>
        public string pCOFINSEfet
        {
            get
            {
                return this.pCOFINSEfetField;
            }
            set
            {
                this.pCOFINSEfetField = value;
            }
        }

        /// <remarks/>
        public string vCOFINSEfet
        {
            get
            {
                return this.vCOFINSEfetField;
            }
            set
            {
                this.vCOFINSEfetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemImpostoRetTrib
    {

        private string vRetPISField;

        private string vRetCofinsField;

        private string vRetCSLLField;

        private string vBCIRRFField;

        private string vIRRFField;

        /// <remarks/>
        public string vRetPIS
        {
            get
            {
                return this.vRetPISField;
            }
            set
            {
                this.vRetPISField = value;
            }
        }

        /// <remarks/>
        public string vRetCofins
        {
            get
            {
                return this.vRetCofinsField;
            }
            set
            {
                this.vRetCofinsField = value;
            }
        }

        /// <remarks/>
        public string vRetCSLL
        {
            get
            {
                return this.vRetCSLLField;
            }
            set
            {
                this.vRetCSLLField = value;
            }
        }

        /// <remarks/>
        public string vBCIRRF
        {
            get
            {
                return this.vBCIRRFField;
            }
            set
            {
                this.vBCIRRFField = value;
            }
        }

        /// <remarks/>
        public string vIRRF
        {
            get
            {
                return this.vIRRFField;
            }
            set
            {
                this.vIRRFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TImp
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemGProcRef
    {

        private string vItemField;

        private string qFaturadaField;

        private string vProdField;

        private TNF3eInfNF3eNFdetDetDetItemGProcRefIndDevolucao indDevolucaoField;

        private bool indDevolucaoFieldSpecified;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string vPISField;

        private string vCOFINSField;

        private TNF3eInfNF3eNFdetDetDetItemGProcRefGProc[] gProcField;

        /// <remarks/>
        public string vItem
        {
            get
            {
                return this.vItemField;
            }
            set
            {
                this.vItemField = value;
            }
        }

        /// <remarks/>
        public string qFaturada
        {
            get
            {
                return this.qFaturadaField;
            }
            set
            {
                this.qFaturadaField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemGProcRefIndDevolucao indDevolucao
        {
            get
            {
                return this.indDevolucaoField;
            }
            set
            {
                this.indDevolucaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indDevolucaoSpecified
        {
            get
            {
                return this.indDevolucaoFieldSpecified;
            }
            set
            {
                this.indDevolucaoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gProc")]
        public TNF3eInfNF3eNFdetDetDetItemGProcRefGProc[] gProc
        {
            get
            {
                return this.gProcField;
            }
            set
            {
                this.gProcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemGProcRefIndDevolucao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemGProcRefGProc
    {

        private TProcesso tpProcField;

        private string nProcessoField;

        /// <remarks/>
        public TProcesso tpProc
        {
            get
            {
                return this.tpProcField;
            }
            set
            {
                this.tpProcField = value;
            }
        }

        /// <remarks/>
        public string nProcesso
        {
            get
            {
                return this.nProcessoField;
            }
            set
            {
                this.nProcessoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TProcesso
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemGContab
    {

        private string cContabField;

        private string xContabField;

        private string vContabField;

        private TNF3eInfNF3eNFdetDetDetItemGContabTpLanc tpLancField;

        /// <remarks/>
        public string cContab
        {
            get
            {
                return this.cContabField;
            }
            set
            {
                this.cContabField = value;
            }
        }

        /// <remarks/>
        public string xContab
        {
            get
            {
                return this.xContabField;
            }
            set
            {
                this.xContabField = value;
            }
        }

        /// <remarks/>
        public string vContab
        {
            get
            {
                return this.vContabField;
            }
            set
            {
                this.vContabField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemGContabTpLanc tpLanc
        {
            get
            {
                return this.tpLancField;
            }
            set
            {
                this.tpLancField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public enum TNF3eInfNF3eNFdetDetDetItemGContabTpLanc
    {

        /// <remarks/>
        D,

        /// <remarks/>
        C,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemAnt
    {

        private string vItemField;

        private string qFaturadaField;

        private string vProdField;

        private string cClassField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string vPISField;

        private string vCOFINSField;

        private TNF3eInfNF3eNFdetDetDetItemAntRetTrib retTribField;

        private string nItemAntField;

        /// <remarks/>
        public string vItem
        {
            get
            {
                return this.vItemField;
            }
            set
            {
                this.vItemField = value;
            }
        }

        /// <remarks/>
        public string qFaturada
        {
            get
            {
                return this.qFaturadaField;
            }
            set
            {
                this.qFaturadaField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public string cClass
        {
            get
            {
                return this.cClassField;
            }
            set
            {
                this.cClassField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eNFdetDetDetItemAntRetTrib retTrib
        {
            get
            {
                return this.retTribField;
            }
            set
            {
                this.retTribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItemAnt
        {
            get
            {
                return this.nItemAntField;
            }
            set
            {
                this.nItemAntField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eNFdetDetDetItemAntRetTrib
    {

        private string vRetPISField;

        private string vRetCofinsField;

        private string vRetCSLLField;

        private string vBCIRRFField;

        private string vIRRFField;

        /// <remarks/>
        public string vRetPIS
        {
            get
            {
                return this.vRetPISField;
            }
            set
            {
                this.vRetPISField = value;
            }
        }

        /// <remarks/>
        public string vRetCofins
        {
            get
            {
                return this.vRetCofinsField;
            }
            set
            {
                this.vRetCofinsField = value;
            }
        }

        /// <remarks/>
        public string vRetCSLL
        {
            get
            {
                return this.vRetCSLLField;
            }
            set
            {
                this.vRetCSLLField = value;
            }
        }

        /// <remarks/>
        public string vBCIRRF
        {
            get
            {
                return this.vBCIRRFField;
            }
            set
            {
                this.vBCIRRFField = value;
            }
        }

        /// <remarks/>
        public string vIRRF
        {
            get
            {
                return this.vIRRFField;
            }
            set
            {
                this.vIRRFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eTotal
    {

        private string vProdField;

        private TNF3eInfNF3eTotalICMSTot iCMSTotField;

        private TNF3eInfNF3eTotalVRetTribTot vRetTribTotField;

        private string vCOFINSField;

        private string vCOFINSEfetField;

        private string vPISField;

        private string vPISEfetField;

        private string vNFField;

        /// <remarks/>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eTotalICMSTot ICMSTot
        {
            get
            {
                return this.iCMSTotField;
            }
            set
            {
                this.iCMSTotField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eTotalVRetTribTot vRetTribTot
        {
            get
            {
                return this.vRetTribTotField;
            }
            set
            {
                this.vRetTribTotField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vCOFINSEfet
        {
            get
            {
                return this.vCOFINSEfetField;
            }
            set
            {
                this.vCOFINSEfetField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public string vPISEfet
        {
            get
            {
                return this.vPISEfetField;
            }
            set
            {
                this.vPISEfetField = value;
            }
        }

        /// <remarks/>
        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eTotalICMSTot
    {

        private string vBCField;

        private string vICMSField;

        private string vICMSDesonField;

        private string vFCPField;

        private string vBCSTField;

        private string vSTField;

        private string vFCPSTField;

        /// <remarks/>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <remarks/>
        public string vST
        {
            get
            {
                return this.vSTField;
            }
            set
            {
                this.vSTField = value;
            }
        }

        /// <remarks/>
        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eTotalVRetTribTot
    {

        private string vRetPISField;

        private string vRetCofinsField;

        private string vRetCSLLField;

        private string vIRRFField;

        /// <remarks/>
        public string vRetPIS
        {
            get
            {
                return this.vRetPISField;
            }
            set
            {
                this.vRetPISField = value;
            }
        }

        /// <remarks/>
        public string vRetCofins
        {
            get
            {
                return this.vRetCofinsField;
            }
            set
            {
                this.vRetCofinsField = value;
            }
        }

        /// <remarks/>
        public string vRetCSLL
        {
            get
            {
                return this.vRetCSLLField;
            }
            set
            {
                this.vRetCSLLField = value;
            }
        }

        /// <remarks/>
        public string vIRRF
        {
            get
            {
                return this.vIRRFField;
            }
            set
            {
                this.vIRRFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGFat
    {

        private string competFatField;

        private string dVencFatField;

        private string dApresFatField;

        private string dProxLeituraField;

        private string nFatField;

        private string codBarrasField;

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private TEndeEmi enderCorrespField;

        private TNF3eInfNF3eGFatGPIX gPIXField;

        /// <remarks/>
        public string CompetFat
        {
            get
            {
                return this.competFatField;
            }
            set
            {
                this.competFatField = value;
            }
        }

        /// <remarks/>
        public string dVencFat
        {
            get
            {
                return this.dVencFatField;
            }
            set
            {
                this.dVencFatField = value;
            }
        }

        /// <remarks/>
        public string dApresFat
        {
            get
            {
                return this.dApresFatField;
            }
            set
            {
                this.dApresFatField = value;
            }
        }

        /// <remarks/>
        public string dProxLeitura
        {
            get
            {
                return this.dProxLeituraField;
            }
            set
            {
                this.dProxLeituraField = value;
            }
        }

        /// <remarks/>
        public string nFat
        {
            get
            {
                return this.nFatField;
            }
            set
            {
                this.nFatField = value;
            }
        }

        /// <remarks/>
        public string codBarras
        {
            get
            {
                return this.codBarrasField;
            }
            set
            {
                this.codBarrasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codAgencia", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("codBanco", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("codDebAuto", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public TEndeEmi enderCorresp
        {
            get
            {
                return this.enderCorrespField;
            }
            set
            {
                this.enderCorrespField = value;
            }
        }

        /// <remarks/>
        public TNF3eInfNF3eGFatGPIX gPIX
        {
            get
            {
                return this.gPIXField;
            }
            set
            {
                this.gPIXField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        codAgencia,

        /// <remarks/>
        codBanco,

        /// <remarks/>
        codDebAuto,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eGFatGPIX
    {

        private string urlQRCodePIXField;

        /// <remarks/>
        public string urlQRCodePIX
        {
            get
            {
                return this.urlQRCodePIXField;
            }
            set
            {
                this.urlQRCodePIXField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TANEELGHistFat
    {

        private string xGrandFatField;

        private TANEELGHistFatGGrandFat[] gGrandFatField;

        /// <remarks/>
        public string xGrandFat
        {
            get
            {
                return this.xGrandFatField;
            }
            set
            {
                this.xGrandFatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gGrandFat")]
        public TANEELGHistFatGGrandFat[] gGrandFat
        {
            get
            {
                return this.gGrandFatField;
            }
            set
            {
                this.gGrandFatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TANEELGHistFatGGrandFat
    {

        private string competFatField;

        private string vFatField;

        private TUMed uMedField;

        private string qtdDiasField;

        /// <remarks/>
        public string CompetFat
        {
            get
            {
                return this.competFatField;
            }
            set
            {
                this.competFatField = value;
            }
        }

        /// <remarks/>
        public string vFat
        {
            get
            {
                return this.vFatField;
            }
            set
            {
                this.vFatField = value;
            }
        }

        /// <remarks/>
        public TUMed uMed
        {
            get
            {
                return this.uMedField;
            }
            set
            {
                this.uMedField = value;
            }
        }

        /// <remarks/>
        public string qtdDias
        {
            get
            {
                return this.qtdDiasField;
            }
            set
            {
                this.qtdDiasField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eAutXML
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eInfAdic
    {

        private string infAdFiscoField;

        private string[] infCplField;

        /// <remarks/>
        public string infAdFisco
        {
            get
            {
                return this.infAdFiscoField;
            }
            set
            {
                this.infAdFiscoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infCpl")]
        public string[] infCpl
        {
            get
            {
                return this.infCplField;
            }
            set
            {
                this.infCplField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TRespTec
    {

        private string cNPJField;

        private string xContatoField;

        private string emailField;

        private string foneField;

        private string idCSRTField;

        private byte[] hashCSRTField;

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string xContato
        {
            get
            {
                return this.xContatoField;
            }
            set
            {
                this.xContatoField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        /// <remarks/>
        public string idCSRT
        {
            get
            {
                return this.idCSRTField;
            }
            set
            {
                this.idCSRTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] hashCSRT
        {
            get
            {
                return this.hashCSRTField;
            }
            set
            {
                this.hashCSRTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nf3e")]
    public partial class TNF3eInfNF3eSupl
    {

        private string qrCodNF3eField;

        /// <remarks/>
        public string qrCodNF3e
        {
            get
            {
                return this.qrCodNF3eField;
            }
            set
            {
                this.qrCodNF3eField = value;
            }
        }
    }
}