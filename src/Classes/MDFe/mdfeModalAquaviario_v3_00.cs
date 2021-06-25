namespace NSSuite_CSharp.src.Classes.MDFe.Aquav
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IsNullable = false)]
    public partial class aquav
    {

        private string irinField;

        private string tpEmbField;

        private string cEmbarField;

        private string xEmbarField;

        private string nViagField;

        private string cPrtEmbField;

        private string cPrtDestField;

        private string prtTransField;

        private aquavTpNav tpNavField;

        private bool tpNavFieldSpecified;

        private aquavInfTermCarreg[] infTermCarregField;

        private aquavInfTermDescarreg[] infTermDescarregField;

        private aquavInfEmbComb[] infEmbCombField;

        private aquavInfUnidCargaVazia[] infUnidCargaVaziaField;

        private aquavInfUnidTranspVazia[] infUnidTranspVaziaField;

        /// <remarks/>
        public string irin
        {
            get
            {
                return this.irinField;
            }
            set
            {
                this.irinField = value;
            }
        }

        /// <remarks/>
        public string tpEmb
        {
            get
            {
                return this.tpEmbField;
            }
            set
            {
                this.tpEmbField = value;
            }
        }

        /// <remarks/>
        public string cEmbar
        {
            get
            {
                return this.cEmbarField;
            }
            set
            {
                this.cEmbarField = value;
            }
        }

        /// <remarks/>
        public string xEmbar
        {
            get
            {
                return this.xEmbarField;
            }
            set
            {
                this.xEmbarField = value;
            }
        }

        /// <remarks/>
        public string nViag
        {
            get
            {
                return this.nViagField;
            }
            set
            {
                this.nViagField = value;
            }
        }

        /// <remarks/>
        public string cPrtEmb
        {
            get
            {
                return this.cPrtEmbField;
            }
            set
            {
                this.cPrtEmbField = value;
            }
        }

        /// <remarks/>
        public string cPrtDest
        {
            get
            {
                return this.cPrtDestField;
            }
            set
            {
                this.cPrtDestField = value;
            }
        }

        /// <remarks/>
        public string prtTrans
        {
            get
            {
                return this.prtTransField;
            }
            set
            {
                this.prtTransField = value;
            }
        }

        /// <remarks/>
        public aquavTpNav tpNav
        {
            get
            {
                return this.tpNavField;
            }
            set
            {
                this.tpNavField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpNavSpecified
        {
            get
            {
                return this.tpNavFieldSpecified;
            }
            set
            {
                this.tpNavFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infTermCarreg")]
        public aquavInfTermCarreg[] infTermCarreg
        {
            get
            {
                return this.infTermCarregField;
            }
            set
            {
                this.infTermCarregField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infTermDescarreg")]
        public aquavInfTermDescarreg[] infTermDescarreg
        {
            get
            {
                return this.infTermDescarregField;
            }
            set
            {
                this.infTermDescarregField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infEmbComb")]
        public aquavInfEmbComb[] infEmbComb
        {
            get
            {
                return this.infEmbCombField;
            }
            set
            {
                this.infEmbCombField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidCargaVazia")]
        public aquavInfUnidCargaVazia[] infUnidCargaVazia
        {
            get
            {
                return this.infUnidCargaVaziaField;
            }
            set
            {
                this.infUnidCargaVaziaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidTranspVazia")]
        public aquavInfUnidTranspVazia[] infUnidTranspVazia
        {
            get
            {
                return this.infUnidTranspVaziaField;
            }
            set
            {
                this.infUnidTranspVaziaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum aquavTpNav
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

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
    public partial class aquavInfTermCarreg
    {

        private string cTermCarregField;

        private string xTermCarregField;

        /// <remarks/>
        public string cTermCarreg
        {
            get
            {
                return this.cTermCarregField;
            }
            set
            {
                this.cTermCarregField = value;
            }
        }

        /// <remarks/>
        public string xTermCarreg
        {
            get
            {
                return this.xTermCarregField;
            }
            set
            {
                this.xTermCarregField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class aquavInfTermDescarreg
    {

        private string cTermDescarregField;

        private string xTermDescarregField;

        /// <remarks/>
        public string cTermDescarreg
        {
            get
            {
                return this.cTermDescarregField;
            }
            set
            {
                this.cTermDescarregField = value;
            }
        }

        /// <remarks/>
        public string xTermDescarreg
        {
            get
            {
                return this.xTermDescarregField;
            }
            set
            {
                this.xTermDescarregField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class aquavInfEmbComb
    {

        private string cEmbCombField;

        private string xBalsaField;

        /// <remarks/>
        public string cEmbComb
        {
            get
            {
                return this.cEmbCombField;
            }
            set
            {
                this.cEmbCombField = value;
            }
        }

        /// <remarks/>
        public string xBalsa
        {
            get
            {
                return this.xBalsaField;
            }
            set
            {
                this.xBalsaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class aquavInfUnidCargaVazia
    {

        private string idUnidCargaVaziaField;

        private aquavInfUnidCargaVaziaTpUnidCargaVazia tpUnidCargaVaziaField;

        /// <remarks/>
        public string idUnidCargaVazia
        {
            get
            {
                return this.idUnidCargaVaziaField;
            }
            set
            {
                this.idUnidCargaVaziaField = value;
            }
        }

        /// <remarks/>
        public aquavInfUnidCargaVaziaTpUnidCargaVazia tpUnidCargaVazia
        {
            get
            {
                return this.tpUnidCargaVaziaField;
            }
            set
            {
                this.tpUnidCargaVaziaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum aquavInfUnidCargaVaziaTpUnidCargaVazia
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
    public partial class aquavInfUnidTranspVazia
    {

        private string idUnidTranspVaziaField;

        private aquavInfUnidTranspVaziaTpUnidTranspVazia tpUnidTranspVaziaField;

        /// <remarks/>
        public string idUnidTranspVazia
        {
            get
            {
                return this.idUnidTranspVaziaField;
            }
            set
            {
                this.idUnidTranspVaziaField = value;
            }
        }

        /// <remarks/>
        public aquavInfUnidTranspVaziaTpUnidTranspVazia tpUnidTranspVazia
        {
            get
            {
                return this.tpUnidTranspVaziaField;
            }
            set
            {
                this.tpUnidTranspVaziaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public enum aquavInfUnidTranspVaziaTpUnidTranspVazia
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
}