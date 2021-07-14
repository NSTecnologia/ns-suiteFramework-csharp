namespace NSSuite_CSharp.src.Classes.CTe.MultiModal
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class multimodal
    {

        private string cOTMField;

        private multimodalIndNegociavel indNegociavelField;

        private multimodalSeg segField;

        /// <remarks/>
        public string COTM
        {
            get
            {
                return this.cOTMField;
            }
            set
            {
                this.cOTMField = value;
            }
        }

        /// <remarks/>
        public multimodalIndNegociavel indNegociavel
        {
            get
            {
                return this.indNegociavelField;
            }
            set
            {
                this.indNegociavelField = value;
            }
        }

        /// <remarks/>
        public multimodalSeg seg
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum multimodalIndNegociavel
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class multimodalSeg
    {

        private multimodalSegInfSeg infSegField;

        private string nApolField;

        private string nAverField;

        /// <remarks/>
        public multimodalSegInfSeg infSeg
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
        public string nAver
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class multimodalSegInfSeg
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
}
