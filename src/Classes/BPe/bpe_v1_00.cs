namespace NSSuiteClientCSharp.src.Classes.BPe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    [System.Xml.Serialization.XmlRootAttribute("BPe", Namespace = "http://www.portalfiscal.inf.br/bpe", IsNullable = false)]
    public partial class TBPe
    {

        private TBPeInfBPe infBPeField;

        private TBPeInfBPeSupl infBPeSuplField;

        //private SignatureType signatureField;

        /// <remarks/>
        public TBPeInfBPe infBPe
        {
            get
            {
                return this.infBPeField;
            }
            set
            {
                this.infBPeField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeSupl infBPeSupl
        {
            get
            {
                return this.infBPeSuplField;
            }
            set
            {
                this.infBPeSuplField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public SignatureType Signature
        //{
        //    get
        //    {
        //        return this.signatureField;
        //    }
        //    set
        //    {
        //        this.signatureField = value;
        //    }
        //}
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPe
    {

        private TBPeInfBPeIde ideField;

        private TBPeInfBPeEmit emitField;

        private TBPeInfBPeComp compField;

        private TBPeInfBPeAgencia agenciaField;

        private TBPeInfBPeInfBPeSub infBPeSubField;

        private TBPeInfBPeInfPassagem infPassagemField;

        private TBPeInfBPeInfViagem[] infViagemField;

        private TBPeInfBPeInfValorBPe infValorBPeField;

        private TBPeInfBPeImp impField;

        private TBPeInfBPePag[] pagField;

        private TBPeInfBPeAutXML[] autXMLField;

        private TBPeInfBPeInfAdic infAdicField;

        private TRespTec infRespTecField;

        private string versaoField;

        private string idField;

        /// <remarks/>
        public TBPeInfBPeIde ide
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
        public TBPeInfBPeEmit emit
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
        public TBPeInfBPeComp comp
        {
            get
            {
                return this.compField;
            }
            set
            {
                this.compField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeAgencia agencia
        {
            get
            {
                return this.agenciaField;
            }
            set
            {
                this.agenciaField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfBPeSub infBPeSub
        {
            get
            {
                return this.infBPeSubField;
            }
            set
            {
                this.infBPeSubField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfPassagem infPassagem
        {
            get
            {
                return this.infPassagemField;
            }
            set
            {
                this.infPassagemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infViagem")]
        public TBPeInfBPeInfViagem[] infViagem
        {
            get
            {
                return this.infViagemField;
            }
            set
            {
                this.infViagemField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfValorBPe infValorBPe
        {
            get
            {
                return this.infValorBPeField;
            }
            set
            {
                this.infValorBPeField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeImp imp
        {
            get
            {
                return this.impField;
            }
            set
            {
                this.impField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pag")]
        public TBPeInfBPePag[] pag
        {
            get
            {
                return this.pagField;
            }
            set
            {
                this.pagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TBPeInfBPeAutXML[] autXML
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
        public TBPeInfBPeInfAdic infAdic
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeIde
    {

        private TCodUfIBGE cUFField;

        private TAmb tpAmbField;

        private TModBPe modField;

        private string serieField;

        private string nBPField;

        private string cBPField;

        private string cDVField;

        private TBPeInfBPeIdeModal modalField;

        private string dhEmiField;

        private TBPeInfBPeIdeTpEmis tpEmisField;

        private string verProcField;

        private TBPeInfBPeIdeTpBPe tpBPeField;

        private TIndPres indPresField;

        private TUf_sem_EX uFIniField;

        private string cMunIniField;

        private TUf uFFimField;

        private string cMunFimField;

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
        public TModBPe mod
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
        public string nBP
        {
            get
            {
                return this.nBPField;
            }
            set
            {
                this.nBPField = value;
            }
        }

        /// <remarks/>
        public string cBP
        {
            get
            {
                return this.cBPField;
            }
            set
            {
                this.cBPField = value;
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
        public TBPeInfBPeIdeModal modal
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
        public TBPeInfBPeIdeTpEmis tpEmis
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
        public TBPeInfBPeIdeTpBPe tpBPe
        {
            get
            {
                return this.tpBPeField;
            }
            set
            {
                this.tpBPeField = value;
            }
        }

        /// <remarks/>
        public TIndPres indPres
        {
            get
            {
                return this.indPresField;
            }
            set
            {
                this.indPresField = value;
            }
        }

        /// <remarks/>
        public TUf_sem_EX UFIni
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
        public string cMunIni
        {
            get
            {
                return this.cMunIniField;
            }
            set
            {
                this.cMunIniField = value;
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
        public string cMunFim
        {
            get
            {
                return this.cMunFimField;
            }
            set
            {
                this.cMunFimField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TModBPe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeModal
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeTpEmis
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeIdeTpBPe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TIndPres
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
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeEmit
    {

        private string cNPJField;

        private string ieField;

        private string iESTField;

        private string xNomeField;

        private string xFantField;

        private string imField;

        private string cNAEField;

        private TBPeInfBPeEmitCRT cRTField;

        private TEndeEmi enderEmitField;

        private string tARField;

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
        public string IEST
        {
            get
            {
                return this.iESTField;
            }
            set
            {
                this.iESTField = value;
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
        public string CNAE
        {
            get
            {
                return this.cNAEField;
            }
            set
            {
                this.cNAEField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeEmitCRT CRT
        {
            get
            {
                return this.cRTField;
            }
            set
            {
                this.cRTField = value;
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

        /// <remarks/>
        public string TAR
        {
            get
            {
                return this.tARField;
            }
            set
            {
                this.tARField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeEmitCRT
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeComp
    {

        private string xNomeField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string ieField;

        private TEndereco enderCompField;

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
        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
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
        public TEndereco enderComp
        {
            get
            {
                return this.enderCompField;
            }
            set
            {
                this.enderCompField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        idEstrangeiro,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TEndereco
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private string cEPField;

        private TUf ufField;

        private string cPaisField;

        private string xPaisField;

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
        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        /// <remarks/>
        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeAgencia
    {

        private string xNomeField;

        private string cNPJField;

        private TEndereco enderAgenciaField;

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
        public TEndereco enderAgencia
        {
            get
            {
                return this.enderAgenciaField;
            }
            set
            {
                this.enderAgenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfBPeSub
    {

        private string chBPeField;

        private TTipoSubstituicao tpSubField;

        /// <remarks/>
        public string chBPe
        {
            get
            {
                return this.chBPeField;
            }
            set
            {
                this.chBPeField = value;
            }
        }

        /// <remarks/>
        public TTipoSubstituicao tpSub
        {
            get
            {
                return this.tpSubField;
            }
            set
            {
                this.tpSubField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TTipoSubstituicao
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfPassagem
    {

        private string cLocOrigField;

        private string xLocOrigField;

        private string cLocDestField;

        private string xLocDestField;

        private string dhEmbField;

        private string dhValidadeField;

        private TBPeInfBPeInfPassagemInfPassageiro infPassageiroField;

        /// <remarks/>
        public string cLocOrig
        {
            get
            {
                return this.cLocOrigField;
            }
            set
            {
                this.cLocOrigField = value;
            }
        }

        /// <remarks/>
        public string xLocOrig
        {
            get
            {
                return this.xLocOrigField;
            }
            set
            {
                this.xLocOrigField = value;
            }
        }

        /// <remarks/>
        public string cLocDest
        {
            get
            {
                return this.cLocDestField;
            }
            set
            {
                this.cLocDestField = value;
            }
        }

        /// <remarks/>
        public string xLocDest
        {
            get
            {
                return this.xLocDestField;
            }
            set
            {
                this.xLocDestField = value;
            }
        }

        /// <remarks/>
        public string dhEmb
        {
            get
            {
                return this.dhEmbField;
            }
            set
            {
                this.dhEmbField = value;
            }
        }

        /// <remarks/>
        public string dhValidade
        {
            get
            {
                return this.dhValidadeField;
            }
            set
            {
                this.dhValidadeField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfPassagemInfPassageiro infPassageiro
        {
            get
            {
                return this.infPassageiroField;
            }
            set
            {
                this.infPassageiroField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfPassagemInfPassageiro
    {

        private string xNomeField;

        private string cPFField;

        private TDoc tpDocField;

        private string nDocField;

        private string xDocField;

        private string dNascField;

        private string foneField;

        private string emailField;

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
        public string CPF
        {
            get
            {
                return this.cPFField;
            }
            set
            {
                this.cPFField = value;
            }
        }

        /// <remarks/>
        public TDoc tpDoc
        {
            get
            {
                return this.tpDocField;
            }
            set
            {
                this.tpDocField = value;
            }
        }

        /// <remarks/>
        public string nDoc
        {
            get
            {
                return this.nDocField;
            }
            set
            {
                this.nDocField = value;
            }
        }

        /// <remarks/>
        public string xDoc
        {
            get
            {
                return this.xDocField;
            }
            set
            {
                this.xDocField = value;
            }
        }

        /// <remarks/>
        public string dNasc
        {
            get
            {
                return this.dNascField;
            }
            set
            {
                this.dNascField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TDoc
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfViagem
    {

        private string cPercursoField;

        private string xPercursoField;

        private TBPeInfBPeInfViagemTpViagem tpViagemField;

        private TBPeInfBPeInfViagemTpServ tpServField;

        private TBPeInfBPeInfViagemTpAcomodacao tpAcomodacaoField;

        private TBPeInfBPeInfViagemTpTrecho tpTrechoField;

        private string dhViagemField;

        private string dhConexaoField;

        private string prefixoField;

        private string poltronaField;

        private string plataformaField;

        private TBPeInfBPeInfViagemInfTravessia infTravessiaField;

        /// <remarks/>
        public string cPercurso
        {
            get
            {
                return this.cPercursoField;
            }
            set
            {
                this.cPercursoField = value;
            }
        }

        /// <remarks/>
        public string xPercurso
        {
            get
            {
                return this.xPercursoField;
            }
            set
            {
                this.xPercursoField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfViagemTpViagem tpViagem
        {
            get
            {
                return this.tpViagemField;
            }
            set
            {
                this.tpViagemField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfViagemTpServ tpServ
        {
            get
            {
                return this.tpServField;
            }
            set
            {
                this.tpServField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfViagemTpAcomodacao tpAcomodacao
        {
            get
            {
                return this.tpAcomodacaoField;
            }
            set
            {
                this.tpAcomodacaoField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfViagemTpTrecho tpTrecho
        {
            get
            {
                return this.tpTrechoField;
            }
            set
            {
                this.tpTrechoField = value;
            }
        }

        /// <remarks/>
        public string dhViagem
        {
            get
            {
                return this.dhViagemField;
            }
            set
            {
                this.dhViagemField = value;
            }
        }

        /// <remarks/>
        public string dhConexao
        {
            get
            {
                return this.dhConexaoField;
            }
            set
            {
                this.dhConexaoField = value;
            }
        }

        /// <remarks/>
        public string prefixo
        {
            get
            {
                return this.prefixoField;
            }
            set
            {
                this.prefixoField = value;
            }
        }

        /// <remarks/>
        public string poltrona
        {
            get
            {
                return this.poltronaField;
            }
            set
            {
                this.poltronaField = value;
            }
        }

        /// <remarks/>
        public string plataforma
        {
            get
            {
                return this.plataformaField;
            }
            set
            {
                this.plataformaField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfViagemInfTravessia infTravessia
        {
            get
            {
                return this.infTravessiaField;
            }
            set
            {
                this.infTravessiaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpViagem
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpServ
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpAcomodacao
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemTpTrecho
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfViagemInfTravessia
    {

        private TBPeInfBPeInfViagemInfTravessiaTpVeiculo tpVeiculoField;

        private TBPeInfBPeInfViagemInfTravessiaSitVeiculo sitVeiculoField;

        /// <remarks/>
        public TBPeInfBPeInfViagemInfTravessiaTpVeiculo tpVeiculo
        {
            get
            {
                return this.tpVeiculoField;
            }
            set
            {
                this.tpVeiculoField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfViagemInfTravessiaSitVeiculo sitVeiculo
        {
            get
            {
                return this.sitVeiculoField;
            }
            set
            {
                this.sitVeiculoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemInfTravessiaTpVeiculo
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
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfViagemInfTravessiaSitVeiculo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfValorBPe
    {

        private string vBPField;

        private string vDescontoField;

        private string vPgtoField;

        private string vTrocoField;

        private TBPeInfBPeInfValorBPeTpDesconto tpDescontoField;

        private bool tpDescontoFieldSpecified;

        private string xDescontoField;

        private string cDescontoField;

        private TBPeInfBPeInfValorBPeComp[] compField;

        /// <remarks/>
        public string vBP
        {
            get
            {
                return this.vBPField;
            }
            set
            {
                this.vBPField = value;
            }
        }

        /// <remarks/>
        public string vDesconto
        {
            get
            {
                return this.vDescontoField;
            }
            set
            {
                this.vDescontoField = value;
            }
        }

        /// <remarks/>
        public string vPgto
        {
            get
            {
                return this.vPgtoField;
            }
            set
            {
                this.vPgtoField = value;
            }
        }

        /// <remarks/>
        public string vTroco
        {
            get
            {
                return this.vTrocoField;
            }
            set
            {
                this.vTrocoField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPeInfValorBPeTpDesconto tpDesconto
        {
            get
            {
                return this.tpDescontoField;
            }
            set
            {
                this.tpDescontoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpDescontoSpecified
        {
            get
            {
                return this.tpDescontoFieldSpecified;
            }
            set
            {
                this.tpDescontoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string xDesconto
        {
            get
            {
                return this.xDescontoField;
            }
            set
            {
                this.xDescontoField = value;
            }
        }

        /// <remarks/>
        public string cDesconto
        {
            get
            {
                return this.cDescontoField;
            }
            set
            {
                this.cDescontoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comp")]
        public TBPeInfBPeInfValorBPeComp[] Comp
        {
            get
            {
                return this.compField;
            }
            set
            {
                this.compField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfValorBPeTpDesconto
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
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfValorBPeComp
    {

        private TBPeInfBPeInfValorBPeCompTpComp tpCompField;

        private string vCompField;

        /// <remarks/>
        public TBPeInfBPeInfValorBPeCompTpComp tpComp
        {
            get
            {
                return this.tpCompField;
            }
            set
            {
                this.tpCompField = value;
            }
        }

        /// <remarks/>
        public string vComp
        {
            get
            {
                return this.vCompField;
            }
            set
            {
                this.vCompField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPeInfValorBPeCompTpComp
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
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImp
    {

        private TImp iCMSField;

        private string vTotTribField;

        private string infAdFiscoField;

        private TBPeInfBPeImpICMSUFFim iCMSUFFimField;

        /// <remarks/>
        public TImp ICMS
        {
            get
            {
                return this.iCMSField;
            }
            set
            {
                this.iCMSField = value;
            }
        }

        /// <remarks/>
        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }

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
        public TBPeInfBPeImpICMSUFFim ICMSUFFim
        {
            get
            {
                return this.iCMSUFFimField;
            }
            set
            {
                this.iCMSUFFimField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImp
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TImpICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TImpICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS45", typeof(TImpICMS45))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TImpICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN", typeof(TImpICMSSN))]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS00
    {

        private TImpICMS00CST cSTField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public TImpICMS00CST CST
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS00CST
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS20
    {

        private TImpICMS20CST cSTField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public TImpICMS20CST CST
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS20CST
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS45
    {

        private TImpICMS45CST cSTField;

        /// <remarks/>
        public TImpICMS45CST CST
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS45CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMS90
    {

        private TImpICMS90CST cSTField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string vCredField;

        /// <remarks/>
        public TImpICMS90CST CST
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
        public string vCred
        {
            get
            {
                return this.vCredField;
            }
            set
            {
                this.vCredField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMS90CST
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TImpICMSSN
    {

        private TImpICMSSNCST cSTField;

        private TImpICMSSNIndSN indSNField;

        /// <remarks/>
        public TImpICMSSNCST CST
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
        public TImpICMSSNIndSN indSN
        {
            get
            {
                return this.indSNField;
            }
            set
            {
                this.indSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMSSNCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TImpICMSSNIndSN
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeImpICMSUFFim
    {

        private string vBCUFFimField;

        private string pFCPUFFimField;

        private string pICMSUFFimField;

        private string pICMSInterField;

        private string vFCPUFFimField;

        private string vICMSUFFimField;

        private string vICMSUFIniField;

        /// <remarks/>
        public string vBCUFFim
        {
            get
            {
                return this.vBCUFFimField;
            }
            set
            {
                this.vBCUFFimField = value;
            }
        }

        /// <remarks/>
        public string pFCPUFFim
        {
            get
            {
                return this.pFCPUFFimField;
            }
            set
            {
                this.pFCPUFFimField = value;
            }
        }

        /// <remarks/>
        public string pICMSUFFim
        {
            get
            {
                return this.pICMSUFFimField;
            }
            set
            {
                this.pICMSUFFimField = value;
            }
        }

        /// <remarks/>
        public string pICMSInter
        {
            get
            {
                return this.pICMSInterField;
            }
            set
            {
                this.pICMSInterField = value;
            }
        }

        /// <remarks/>
        public string vFCPUFFim
        {
            get
            {
                return this.vFCPUFFimField;
            }
            set
            {
                this.vFCPUFFimField = value;
            }
        }

        /// <remarks/>
        public string vICMSUFFim
        {
            get
            {
                return this.vICMSUFFimField;
            }
            set
            {
                this.vICMSUFFimField = value;
            }
        }

        /// <remarks/>
        public string vICMSUFIni
        {
            get
            {
                return this.vICMSUFIniField;
            }
            set
            {
                this.vICMSUFIniField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPePag
    {

        private TBPeInfBPePagTPag tPagField;

        private string xPagField;

        private string nDocPagField;

        private string vPagField;

        private TBPeInfBPePagCard cardField;

        /// <remarks/>
        public TBPeInfBPePagTPag tPag
        {
            get
            {
                return this.tPagField;
            }
            set
            {
                this.tPagField = value;
            }
        }

        /// <remarks/>
        public string xPag
        {
            get
            {
                return this.xPagField;
            }
            set
            {
                this.xPagField = value;
            }
        }

        /// <remarks/>
        public string nDocPag
        {
            get
            {
                return this.nDocPagField;
            }
            set
            {
                this.nDocPagField = value;
            }
        }

        /// <remarks/>
        public string vPag
        {
            get
            {
                return this.vPagField;
            }
            set
            {
                this.vPagField = value;
            }
        }

        /// <remarks/>
        public TBPeInfBPePagCard card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagTPag
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
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPePagCard
    {

        private TBPeInfBPePagCardTpIntegra tpIntegraField;

        private string cNPJField;

        private TBPeInfBPePagCardTBand tBandField;

        private bool tBandFieldSpecified;

        private string xBandField;

        private string cAutField;

        private string nsuTransField;

        private string nsuHostField;

        private string nParcelasField;

        private string infAdCardField;

        /// <remarks/>
        public TBPeInfBPePagCardTpIntegra tpIntegra
        {
            get
            {
                return this.tpIntegraField;
            }
            set
            {
                this.tpIntegraField = value;
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

        /// <remarks/>
        public TBPeInfBPePagCardTBand tBand
        {
            get
            {
                return this.tBandField;
            }
            set
            {
                this.tBandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tBandSpecified
        {
            get
            {
                return this.tBandFieldSpecified;
            }
            set
            {
                this.tBandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string xBand
        {
            get
            {
                return this.xBandField;
            }
            set
            {
                this.xBandField = value;
            }
        }

        /// <remarks/>
        public string cAut
        {
            get
            {
                return this.cAutField;
            }
            set
            {
                this.cAutField = value;
            }
        }

        /// <remarks/>
        public string nsuTrans
        {
            get
            {
                return this.nsuTransField;
            }
            set
            {
                this.nsuTransField = value;
            }
        }

        /// <remarks/>
        public string nsuHost
        {
            get
            {
                return this.nsuHostField;
            }
            set
            {
                this.nsuHostField = value;
            }
        }

        /// <remarks/>
        public string nParcelas
        {
            get
            {
                return this.nParcelasField;
            }
            set
            {
                this.nParcelasField = value;
            }
        }

        /// <remarks/>
        public string infAdCard
        {
            get
            {
                return this.infAdCardField;
            }
            set
            {
                this.infAdCardField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagCardTpIntegra
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public enum TBPeInfBPePagCardTBand
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
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeAutXML
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe", IncludeInSchema = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeInfAdic
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/bpe")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/bpe")]
    public partial class TBPeInfBPeSupl
    {

        private string qrCodBPeField;

        private string boardPassBPeField;

        /// <remarks/>
        public string qrCodBPe
        {
            get
            {
                return this.qrCodBPeField;
            }
            set
            {
                this.qrCodBPeField = value;
            }
        }

        /// <remarks/>
        public string boardPassBPe
        {
            get
            {
                return this.boardPassBPeField;
            }
            set
            {
                this.boardPassBPeField = value;
            }
        }
    }
}
