namespace NSSuite_CSharp.src.Classes.CTe.Aereo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class aereo
    {
        private string nMinuField;

        private string nOCAField;

        private string dPrevAereoField;

        private aereoNatCarga natCargaField;

        private aereoTarifa tarifaField;

        private aereoPeri[] periField;

        /// <remarks/>
        public string nMinu
        {
            get
            {
                return this.nMinuField;
            }
            set
            {
                this.nMinuField = value;
            }
        }

        /// <remarks/>
        public string nOCA
        {
            get
            {
                return this.nOCAField;
            }
            set
            {
                this.nOCAField = value;
            }
        }

        /// <remarks/>
        public string dPrevAereo
        {
            get
            {
                return this.dPrevAereoField;
            }
            set
            {
                this.dPrevAereoField = value;
            }
        }

        /// <remarks/>
        public aereoNatCarga natCarga
        {
            get
            {
                return this.natCargaField;
            }
            set
            {
                this.natCargaField = value;
            }
        }

        /// <remarks/>
        public aereoTarifa tarifa
        {
            get
            {
                return this.tarifaField;
            }
            set
            {
                this.tarifaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("peri")]
        public aereoPeri[] peri
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoNatCarga
    {

        private string xDimeField;

        private aereoNatCargaCInfManu[] cInfManuField;

        /// <remarks/>
        public string xDime
        {
            get
            {
                return this.xDimeField;
            }
            set
            {
                this.xDimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cInfManu")]
        public aereoNatCargaCInfManu[] cInfManu
        {
            get
            {
                return this.cInfManuField;
            }
            set
            {
                this.cInfManuField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum aereoNatCargaCInfManu
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
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoTarifa
    {

        private string clField;

        private string cTarField;

        private string vTarField;

        /// <remarks/>
        public string CL
        {
            get
            {
                return this.clField;
            }
            set
            {
                this.clField = value;
            }
        }

        /// <remarks/>
        public string cTar
        {
            get
            {
                return this.cTarField;
            }
            set
            {
                this.cTarField = value;
            }
        }

        /// <remarks/>
        public string vTar
        {
            get
            {
                return this.vTarField;
            }
            set
            {
                this.vTarField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoPeri
    {

        private string nONUField;

        private string qTotEmbField;

        private aereoPeriInfTotAP infTotAPField;

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
        public string qTotEmb
        {
            get
            {
                return this.qTotEmbField;
            }
            set
            {
                this.qTotEmbField = value;
            }
        }

        /// <remarks/>
        public aereoPeriInfTotAP infTotAP
        {
            get
            {
                return this.infTotAPField;
            }
            set
            {
                this.infTotAPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class aereoPeriInfTotAP
    {

        private string qTotProdField;

        private aereoPeriInfTotAPUniAP uniAPField;

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
        public aereoPeriInfTotAPUniAP uniAP
        {
            get
            {
                return this.uniAPField;
            }
            set
            {
                this.uniAPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum aereoPeriInfTotAPUniAP
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
}