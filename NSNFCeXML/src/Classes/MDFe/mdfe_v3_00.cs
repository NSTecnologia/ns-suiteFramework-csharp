namespace NSSuite_CSharp.src.Classes.MDFe
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    [System.Xml.Serialization.XmlRootAttribute("MDFe", Namespace = "http://www.portalfiscal.inf.br/mdfe", IsNullable = false)]
    public partial class TMDFe
    {

        private TMDFeInfMDFe infMDFeField;

        private TMDFeInfMDFeSupl infMDFeSuplField;

        private SignatureType signatureField;

        /// <remarks/>
        public TMDFeInfMDFe infMDFe
        {
            get
            {
                return this.infMDFeField;
            }
            set
            {
                this.infMDFeField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeSupl infMDFeSupl
        {
            get
            {
                return this.infMDFeSuplField;
            }
            set
            {
                this.infMDFeSuplField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFe
    {

        private TMDFeInfMDFeIde ideField;

        private TMDFeInfMDFeEmit emitField;

        private TMDFeInfMDFeInfModal infModalField;

        private TMDFeInfMDFeInfMunDescarga[] infDocField;

        private TMDFeInfMDFeSeg[] segField;

        private TMDFeInfMDFeProdPred prodPredField;

        private TMDFeInfMDFeTot totField;

        private TMDFeInfMDFeLacres[] lacresField;

        private TMDFeInfMDFeAutXML[] autXMLField;

        private TMDFeInfMDFeInfAdic infAdicField;

        private TRespTec infRespTecField;

        private TMDFeInfMDFeInfSolicNFF infSolicNFFField;

        private string versaoField;

        private string idField;

        /// <remarks/>
        public TMDFeInfMDFeIde ide
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
        public TMDFeInfMDFeEmit emit
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
        public TMDFeInfMDFeInfModal infModal
        {
            get
            {
                return this.infModalField;
            }
            set
            {
                this.infModalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("infMunDescarga", IsNullable = false)]
        public TMDFeInfMDFeInfMunDescarga[] infDoc
        {
            get
            {
                return this.infDocField;
            }
            set
            {
                this.infDocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("seg")]
        public TMDFeInfMDFeSeg[] seg
        {
            get
            {
                return this.segField;
            }
            set
            {
                this.segField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeProdPred prodPred
        {
            get
            {
                return this.prodPredField;
            }
            set
            {
                this.prodPredField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeTot tot
        {
            get
            {
                return this.totField;
            }
            set
            {
                this.totField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lacres")]
        public TMDFeInfMDFeLacres[] lacres
        {
            get
            {
                return this.lacresField;
            }
            set
            {
                this.lacresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TMDFeInfMDFeAutXML[] autXML
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
        public TMDFeInfMDFeInfAdic infAdic
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
        public TRespTec infRespTec
        {
            get
            {
                return this.infRespTecField;
            }
            set
            {
                this.infRespTecField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeInfSolicNFF infSolicNFF
        {
            get
            {
                return this.infSolicNFFField;
            }
            set
            {
                this.infSolicNFFField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeIde
    {

        private TCodUfIBGE cUFField;

        private TAmb tpAmbField;

        private TEmit tpEmitField;

        private TTransp tpTranspField;

        private bool tpTranspFieldSpecified;

        private TModMD modField;

        private string serieField;

        private string nMDFField;

        private string cMDFField;

        private string cDVField;

        private TModalMD modalField;

        private string dhEmiField;

        private TMDFeInfMDFeIdeTpEmis tpEmisField;

        private TMDFeInfMDFeIdeProcEmi procEmiField;

        private string verProcField;

        private TUf uFIniField;

        private TUf uFFimField;

        private TMDFeInfMDFeIdeInfMunCarrega[] infMunCarregaField;

        private TMDFeInfMDFeIdeInfPercurso[] infPercursoField;

        private string dhIniViagemField;

        private TMDFeInfMDFeIdeIndCanalVerde indCanalVerdeField;

        private bool indCanalVerdeFieldSpecified;

        private TMDFeInfMDFeIdeIndCarregaPosterior indCarregaPosteriorField;

        private bool indCarregaPosteriorFieldSpecified;

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
        public TEmit tpEmit
        {
            get
            {
                return this.tpEmitField;
            }
            set
            {
                this.tpEmitField = value;
            }
        }

        /// <remarks/>
        public TTransp tpTransp
        {
            get
            {
                return this.tpTranspField;
            }
            set
            {
                this.tpTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpTranspSpecified
        {
            get
            {
                return this.tpTranspFieldSpecified;
            }
            set
            {
                this.tpTranspFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TModMD mod
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
        public string nMDF
        {
            get
            {
                return this.nMDFField;
            }
            set
            {
                this.nMDFField = value;
            }
        }

        /// <remarks/>
        public string cMDF
        {
            get
            {
                return this.cMDFField;
            }
            set
            {
                this.cMDFField = value;
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
        public TModalMD modal
        {
            get
            {
                return this.modalField;
            }
            set
            {
                this.modalField = value;
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
        public TMDFeInfMDFeIdeTpEmis tpEmis
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
        public TMDFeInfMDFeIdeProcEmi procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
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
        public TUf UFIni
        {
            get
            {
                return this.uFIniField;
            }
            set
            {
                this.uFIniField = value;
            }
        }

        /// <remarks/>
        public TUf UFFim
        {
            get
            {
                return this.uFFimField;
            }
            set
            {
                this.uFFimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infMunCarrega")]
        public TMDFeInfMDFeIdeInfMunCarrega[] infMunCarrega
        {
            get
            {
                return this.infMunCarregaField;
            }
            set
            {
                this.infMunCarregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infPercurso")]
        public TMDFeInfMDFeIdeInfPercurso[] infPercurso
        {
            get
            {
                return this.infPercursoField;
            }
            set
            {
                this.infPercursoField = value;
            }
        }

        /// <remarks/>
        public string dhIniViagem
        {
            get
            {
                return this.dhIniViagemField;
            }
            set
            {
                this.dhIniViagemField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeIdeIndCanalVerde indCanalVerde
        {
            get
            {
                return this.indCanalVerdeField;
            }
            set
            {
                this.indCanalVerdeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indCanalVerdeSpecified
        {
            get
            {
                return this.indCanalVerdeFieldSpecified;
            }
            set
            {
                this.indCanalVerdeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeIdeIndCarregaPosterior indCarregaPosterior
        {
            get
            {
                return this.indCarregaPosteriorField;
            }
            set
            {
                this.indCarregaPosteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indCarregaPosteriorSpecified
        {
            get
            {
                return this.indCarregaPosteriorFieldSpecified;
            }
            set
            {
                this.indCarregaPosteriorFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TEmit
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TTransp
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TModMD
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TModalMD
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeIdeTpEmis
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeIdeProcEmi
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TUf
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

        /// <remarks/>
        EX,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeIdeInfMunCarrega
    {

        private string cMunCarregaField;

        private string xMunCarregaField;

        /// <remarks/>
        public string cMunCarrega
        {
            get
            {
                return this.cMunCarregaField;
            }
            set
            {
                this.cMunCarregaField = value;
            }
        }

        /// <remarks/>
        public string xMunCarrega
        {
            get
            {
                return this.xMunCarregaField;
            }
            set
            {
                this.xMunCarregaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeIdeInfPercurso
    {

        private TUf uFPerField;

        /// <remarks/>
        public TUf UFPer
        {
            get
            {
                return this.uFPerField;
            }
            set
            {
                this.uFPerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeIdeIndCanalVerde
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeIdeIndCarregaPosterior
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeEmit
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string ieField;

        private string xNomeField;

        private string xFantField;

        private TEndeEmi enderEmitField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IncludeInSchema = false)]
    public enum ItemChoiceType
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TEndeEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private string cEPField;

        private TUf ufField;

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
        public TUf UF
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfModal
    {

        private System.Xml.XmlElement anyField;

        private string versaoModalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versaoModal
        {
            get
            {
                return this.versaoModalField;
            }
            set
            {
                this.versaoModalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescarga
    {

        private string cMunDescargaField;

        private string xMunDescargaField;

        private TMDFeInfMDFeInfMunDescargaInfCTe[] infCTeField;

        private TMDFeInfMDFeInfMunDescargaInfNFe[] infNFeField;

        private TMDFeInfMDFeInfMunDescargaInfMDFeTransp[] infMDFeTranspField;

        /// <remarks/>
        public string cMunDescarga
        {
            get
            {
                return this.cMunDescargaField;
            }
            set
            {
                this.cMunDescargaField = value;
            }
        }

        /// <remarks/>
        public string xMunDescarga
        {
            get
            {
                return this.xMunDescargaField;
            }
            set
            {
                this.xMunDescargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infCTe")]
        public TMDFeInfMDFeInfMunDescargaInfCTe[] infCTe
        {
            get
            {
                return this.infCTeField;
            }
            set
            {
                this.infCTeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infNFe")]
        public TMDFeInfMDFeInfMunDescargaInfNFe[] infNFe
        {
            get
            {
                return this.infNFeField;
            }
            set
            {
                this.infNFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infMDFeTransp")]
        public TMDFeInfMDFeInfMunDescargaInfMDFeTransp[] infMDFeTransp
        {
            get
            {
                return this.infMDFeTranspField;
            }
            set
            {
                this.infMDFeTranspField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfCTe
    {

        private string chCTeField;

        private string segCodBarraField;

        private TMDFeInfMDFeInfMunDescargaInfCTeIndReentrega indReentregaField;

        private bool indReentregaFieldSpecified;

        private TUnidadeTransp[] infUnidTranspField;

        private TMDFeInfMDFeInfMunDescargaInfCTePeri[] periField;

        private TMDFeInfMDFeInfMunDescargaInfCTeInfEntregaParcial infEntregaParcialField;

        /// <remarks/>
        public string chCTe
        {
            get
            {
                return this.chCTeField;
            }
            set
            {
                this.chCTeField = value;
            }
        }

        /// <remarks/>
        public string SegCodBarra
        {
            get
            {
                return this.segCodBarraField;
            }
            set
            {
                this.segCodBarraField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeInfMunDescargaInfCTeIndReentrega indReentrega
        {
            get
            {
                return this.indReentregaField;
            }
            set
            {
                this.indReentregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indReentregaSpecified
        {
            get
            {
                return this.indReentregaFieldSpecified;
            }
            set
            {
                this.indReentregaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp")]
        public TUnidadeTransp[] infUnidTransp
        {
            get
            {
                return this.infUnidTranspField;
            }
            set
            {
                this.infUnidTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("peri")]
        public TMDFeInfMDFeInfMunDescargaInfCTePeri[] peri
        {
            get
            {
                return this.periField;
            }
            set
            {
                this.periField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeInfMunDescargaInfCTeInfEntregaParcial infEntregaParcial
        {
            get
            {
                return this.infEntregaParcialField;
            }
            set
            {
                this.infEntregaParcialField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeInfMunDescargaInfCTeIndReentrega
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TUnidadeTransp
    {

        private TtipoUnidTransp tpUnidTranspField;

        private string idUnidTranspField;

        private TUnidadeTranspLacUnidTransp[] lacUnidTranspField;

        private TUnidCarga[] infUnidCargaField;

        private string qtdRatField;

        /// <remarks/>
        public TtipoUnidTransp tpUnidTransp
        {
            get
            {
                return this.tpUnidTranspField;
            }
            set
            {
                this.tpUnidTranspField = value;
            }
        }

        /// <remarks/>
        public string idUnidTransp
        {
            get
            {
                return this.idUnidTranspField;
            }
            set
            {
                this.idUnidTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lacUnidTransp")]
        public TUnidadeTranspLacUnidTransp[] lacUnidTransp
        {
            get
            {
                return this.lacUnidTranspField;
            }
            set
            {
                this.lacUnidTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga")]
        public TUnidCarga[] infUnidCarga
        {
            get
            {
                return this.infUnidCargaField;
            }
            set
            {
                this.infUnidCargaField = value;
            }
        }

        /// <remarks/>
        public string qtdRat
        {
            get
            {
                return this.qtdRatField;
            }
            set
            {
                this.qtdRatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TtipoUnidTransp
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TUnidadeTranspLacUnidTransp
    {

        private string nLacreField;

        /// <remarks/>
        public string nLacre
        {
            get
            {
                return this.nLacreField;
            }
            set
            {
                this.nLacreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TUnidCarga
    {

        private TtipoUnidCarga tpUnidCargaField;

        private string idUnidCargaField;

        private TUnidCargaLacUnidCarga[] lacUnidCargaField;

        private string qtdRatField;

        /// <remarks/>
        public TtipoUnidCarga tpUnidCarga
        {
            get
            {
                return this.tpUnidCargaField;
            }
            set
            {
                this.tpUnidCargaField = value;
            }
        }

        /// <remarks/>
        public string idUnidCarga
        {
            get
            {
                return this.idUnidCargaField;
            }
            set
            {
                this.idUnidCargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lacUnidCarga")]
        public TUnidCargaLacUnidCarga[] lacUnidCarga
        {
            get
            {
                return this.lacUnidCargaField;
            }
            set
            {
                this.lacUnidCargaField = value;
            }
        }

        /// <remarks/>
        public string qtdRat
        {
            get
            {
                return this.qtdRatField;
            }
            set
            {
                this.qtdRatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TtipoUnidCarga
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TUnidCargaLacUnidCarga
    {

        private string nLacreField;

        /// <remarks/>
        public string nLacre
        {
            get
            {
                return this.nLacreField;
            }
            set
            {
                this.nLacreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfCTePeri
    {

        private string nONUField;

        private string xNomeAEField;

        private string xClaRiscoField;

        private string grEmbField;

        private string qTotProdField;

        private string qVolTipoField;

        /// <remarks/>
        public string nONU
        {
            get
            {
                return this.nONUField;
            }
            set
            {
                this.nONUField = value;
            }
        }

        /// <remarks/>
        public string xNomeAE
        {
            get
            {
                return this.xNomeAEField;
            }
            set
            {
                this.xNomeAEField = value;
            }
        }

        /// <remarks/>
        public string xClaRisco
        {
            get
            {
                return this.xClaRiscoField;
            }
            set
            {
                this.xClaRiscoField = value;
            }
        }

        /// <remarks/>
        public string grEmb
        {
            get
            {
                return this.grEmbField;
            }
            set
            {
                this.grEmbField = value;
            }
        }

        /// <remarks/>
        public string qTotProd
        {
            get
            {
                return this.qTotProdField;
            }
            set
            {
                this.qTotProdField = value;
            }
        }

        /// <remarks/>
        public string qVolTipo
        {
            get
            {
                return this.qVolTipoField;
            }
            set
            {
                this.qVolTipoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfCTeInfEntregaParcial
    {

        private string qtdTotalField;

        private string qtdParcialField;

        /// <remarks/>
        public string qtdTotal
        {
            get
            {
                return this.qtdTotalField;
            }
            set
            {
                this.qtdTotalField = value;
            }
        }

        /// <remarks/>
        public string qtdParcial
        {
            get
            {
                return this.qtdParcialField;
            }
            set
            {
                this.qtdParcialField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfNFe
    {

        private string chNFeField;

        private string segCodBarraField;

        private TMDFeInfMDFeInfMunDescargaInfNFeIndReentrega indReentregaField;

        private bool indReentregaFieldSpecified;

        private TUnidadeTransp[] infUnidTranspField;

        private TMDFeInfMDFeInfMunDescargaInfNFePeri[] periField;

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        /// <remarks/>
        public string SegCodBarra
        {
            get
            {
                return this.segCodBarraField;
            }
            set
            {
                this.segCodBarraField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeInfMunDescargaInfNFeIndReentrega indReentrega
        {
            get
            {
                return this.indReentregaField;
            }
            set
            {
                this.indReentregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indReentregaSpecified
        {
            get
            {
                return this.indReentregaFieldSpecified;
            }
            set
            {
                this.indReentregaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp")]
        public TUnidadeTransp[] infUnidTransp
        {
            get
            {
                return this.infUnidTranspField;
            }
            set
            {
                this.infUnidTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("peri")]
        public TMDFeInfMDFeInfMunDescargaInfNFePeri[] peri
        {
            get
            {
                return this.periField;
            }
            set
            {
                this.periField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeInfMunDescargaInfNFeIndReentrega
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfNFePeri
    {

        private string nONUField;

        private string xNomeAEField;

        private string xClaRiscoField;

        private string grEmbField;

        private string qTotProdField;

        private string qVolTipoField;

        /// <remarks/>
        public string nONU
        {
            get
            {
                return this.nONUField;
            }
            set
            {
                this.nONUField = value;
            }
        }

        /// <remarks/>
        public string xNomeAE
        {
            get
            {
                return this.xNomeAEField;
            }
            set
            {
                this.xNomeAEField = value;
            }
        }

        /// <remarks/>
        public string xClaRisco
        {
            get
            {
                return this.xClaRiscoField;
            }
            set
            {
                this.xClaRiscoField = value;
            }
        }

        /// <remarks/>
        public string grEmb
        {
            get
            {
                return this.grEmbField;
            }
            set
            {
                this.grEmbField = value;
            }
        }

        /// <remarks/>
        public string qTotProd
        {
            get
            {
                return this.qTotProdField;
            }
            set
            {
                this.qTotProdField = value;
            }
        }

        /// <remarks/>
        public string qVolTipo
        {
            get
            {
                return this.qVolTipoField;
            }
            set
            {
                this.qVolTipoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfMDFeTransp
    {

        private string chMDFeField;

        private TMDFeInfMDFeInfMunDescargaInfMDFeTranspIndReentrega indReentregaField;

        private bool indReentregaFieldSpecified;

        private TUnidadeTransp[] infUnidTranspField;

        private TMDFeInfMDFeInfMunDescargaInfMDFeTranspPeri[] periField;

        /// <remarks/>
        public string chMDFe
        {
            get
            {
                return this.chMDFeField;
            }
            set
            {
                this.chMDFeField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeInfMunDescargaInfMDFeTranspIndReentrega indReentrega
        {
            get
            {
                return this.indReentregaField;
            }
            set
            {
                this.indReentregaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indReentregaSpecified
        {
            get
            {
                return this.indReentregaFieldSpecified;
            }
            set
            {
                this.indReentregaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp")]
        public TUnidadeTransp[] infUnidTransp
        {
            get
            {
                return this.infUnidTranspField;
            }
            set
            {
                this.infUnidTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("peri")]
        public TMDFeInfMDFeInfMunDescargaInfMDFeTranspPeri[] peri
        {
            get
            {
                return this.periField;
            }
            set
            {
                this.periField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeInfMunDescargaInfMDFeTranspIndReentrega
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfMunDescargaInfMDFeTranspPeri
    {

        private string nONUField;

        private string xNomeAEField;

        private string xClaRiscoField;

        private string grEmbField;

        private string qTotProdField;

        private string qVolTipoField;

        /// <remarks/>
        public string nONU
        {
            get
            {
                return this.nONUField;
            }
            set
            {
                this.nONUField = value;
            }
        }

        /// <remarks/>
        public string xNomeAE
        {
            get
            {
                return this.xNomeAEField;
            }
            set
            {
                this.xNomeAEField = value;
            }
        }

        /// <remarks/>
        public string xClaRisco
        {
            get
            {
                return this.xClaRiscoField;
            }
            set
            {
                this.xClaRiscoField = value;
            }
        }

        /// <remarks/>
        public string grEmb
        {
            get
            {
                return this.grEmbField;
            }
            set
            {
                this.grEmbField = value;
            }
        }

        /// <remarks/>
        public string qTotProd
        {
            get
            {
                return this.qTotProdField;
            }
            set
            {
                this.qTotProdField = value;
            }
        }

        /// <remarks/>
        public string qVolTipo
        {
            get
            {
                return this.qVolTipoField;
            }
            set
            {
                this.qVolTipoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeSeg
    {

        private TMDFeInfMDFeSegInfResp infRespField;

        private TMDFeInfMDFeSegInfSeg infSegField;

        private string nApolField;

        private string[] nAverField;

        /// <remarks/>
        public TMDFeInfMDFeSegInfResp infResp
        {
            get
            {
                return this.infRespField;
            }
            set
            {
                this.infRespField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeSegInfSeg infSeg
        {
            get
            {
                return this.infSegField;
            }
            set
            {
                this.infSegField = value;
            }
        }

        /// <remarks/>
        public string nApol
        {
            get
            {
                return this.nApolField;
            }
            set
            {
                this.nApolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nAver")]
        public string[] nAver
        {
            get
            {
                return this.nAverField;
            }
            set
            {
                this.nAverField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeSegInfResp
    {

        private TMDFeInfMDFeSegInfRespRespSeg respSegField;

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        public TMDFeInfMDFeSegInfRespRespSeg respSeg
        {
            get
            {
                return this.respSegField;
            }
            set
            {
                this.respSegField = value;
            }
        }

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeSegInfRespRespSeg
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IncludeInSchema = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeSegInfSeg
    {

        private string xSegField;

        private string cNPJField;

        /// <remarks/>
        public string xSeg
        {
            get
            {
                return this.xSegField;
            }
            set
            {
                this.xSegField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeProdPred
    {

        private TMDFeInfMDFeProdPredTpCarga tpCargaField;

        private string xProdField;

        private string cEANField;

        private string nCMField;

        private TMDFeInfMDFeProdPredInfLotacao infLotacaoField;

        /// <remarks/>
        public TMDFeInfMDFeProdPredTpCarga tpCarga
        {
            get
            {
                return this.tpCargaField;
            }
            set
            {
                this.tpCargaField = value;
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
        public string cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        /// <remarks/>
        public string NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeProdPredInfLotacao infLotacao
        {
            get
            {
                return this.infLotacaoField;
            }
            set
            {
                this.infLotacaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeProdPredTpCarga
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeProdPredInfLotacao
    {

        private TMDFeInfMDFeProdPredInfLotacaoInfLocalCarrega infLocalCarregaField;

        private TMDFeInfMDFeProdPredInfLotacaoInfLocalDescarrega infLocalDescarregaField;

        /// <remarks/>
        public TMDFeInfMDFeProdPredInfLotacaoInfLocalCarrega infLocalCarrega
        {
            get
            {
                return this.infLocalCarregaField;
            }
            set
            {
                this.infLocalCarregaField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeProdPredInfLotacaoInfLocalDescarrega infLocalDescarrega
        {
            get
            {
                return this.infLocalDescarregaField;
            }
            set
            {
                this.infLocalDescarregaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeProdPredInfLotacaoInfLocalCarrega
    {

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CEP", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("latitude", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("longitude", typeof(string))]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        CEP,

        /// <remarks/>
        latitude,

        /// <remarks/>
        longitude,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeProdPredInfLotacaoInfLocalDescarrega
    {

        private string[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CEP", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("latitude", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("longitude", typeof(string))]
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
        public ItemsChoiceType1[] ItemsElementName
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        CEP,

        /// <remarks/>
        latitude,

        /// <remarks/>
        longitude,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeTot
    {

        private string qCTeField;

        private string qNFeField;

        private string qMDFeField;

        private string vCargaField;

        private TMDFeInfMDFeTotCUnid cUnidField;

        private string qCargaField;

        /// <remarks/>
        public string qCTe
        {
            get
            {
                return this.qCTeField;
            }
            set
            {
                this.qCTeField = value;
            }
        }

        /// <remarks/>
        public string qNFe
        {
            get
            {
                return this.qNFeField;
            }
            set
            {
                this.qNFeField = value;
            }
        }

        /// <remarks/>
        public string qMDFe
        {
            get
            {
                return this.qMDFeField;
            }
            set
            {
                this.qMDFeField = value;
            }
        }

        /// <remarks/>
        public string vCarga
        {
            get
            {
                return this.vCargaField;
            }
            set
            {
                this.vCargaField = value;
            }
        }

        /// <remarks/>
        public TMDFeInfMDFeTotCUnid cUnid
        {
            get
            {
                return this.cUnidField;
            }
            set
            {
                this.cUnidField = value;
            }
        }

        /// <remarks/>
        public string qCarga
        {
            get
            {
                return this.qCargaField;
            }
            set
            {
                this.qCargaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum TMDFeInfMDFeTotCUnid
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeLacres
    {

        private string nLacreField;

        /// <remarks/>
        public string nLacre
        {
            get
            {
                return this.nLacreField;
            }
            set
            {
                this.nLacreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeAutXML
    {

        private string itemField;

        private ItemChoiceType2 itemElementNameField;

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
        public ItemChoiceType2 ItemElementName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IncludeInSchema = false)]
    public enum ItemChoiceType2
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfAdic
    {

        private string infAdFiscoField;

        private string infCplField;

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
        public string infCpl
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeInfSolicNFF
    {

        private string xSolicField;

        /// <remarks/>
        public string xSolic
        {
            get
            {
                return this.xSolicField;
            }
            set
            {
                this.xSolicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class TMDFeInfMDFeSupl
    {

        private string qrCodMDFeField;

        /// <remarks/>
        public string qrCodMDFe
        {
            get
            {
                return this.qrCodMDFeField;
            }
            set
            {
                this.qrCodMDFeField = value;
            }
        }
    }
}
