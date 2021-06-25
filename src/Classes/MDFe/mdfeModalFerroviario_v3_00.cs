namespace NSSuite_CSharp.src.Classes.MDFe.Ferrov
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IsNullable = false)]
    public partial class ferrov
    {

        private ferrovTrem tremField;

        private ferrovVag[] vagField;

        /// <remarks/>
        public ferrovTrem trem
        {
            get
            {
                return this.tremField;
            }
            set
            {
                this.tremField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vag")]
        public ferrovVag[] vag
        {
            get
            {
                return this.vagField;
            }
            set
            {
                this.vagField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class ferrovTrem
    {

        private string xPrefField;

        private string dhTremField;

        private string xOriField;

        private string xDestField;

        private string qVagField;

        /// <remarks/>
        public string xPref
        {
            get
            {
                return this.xPrefField;
            }
            set
            {
                this.xPrefField = value;
            }
        }

        /// <remarks/>
        public string dhTrem
        {
            get
            {
                return this.dhTremField;
            }
            set
            {
                this.dhTremField = value;
            }
        }

        /// <remarks/>
        public string xOri
        {
            get
            {
                return this.xOriField;
            }
            set
            {
                this.xOriField = value;
            }
        }

        /// <remarks/>
        public string xDest
        {
            get
            {
                return this.xDestField;
            }
            set
            {
                this.xDestField = value;
            }
        }

        /// <remarks/>
        public string qVag
        {
            get
            {
                return this.qVagField;
            }
            set
            {
                this.qVagField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    public partial class ferrovVag
    {

        private string pesoBCField;

        private string pesoRField;

        private string tpVagField;

        private string serieField;

        private string nVagField;

        private string nSeqField;

        private string tuField;

        /// <remarks/>
        public string pesoBC
        {
            get
            {
                return this.pesoBCField;
            }
            set
            {
                this.pesoBCField = value;
            }
        }

        /// <remarks/>
        public string pesoR
        {
            get
            {
                return this.pesoRField;
            }
            set
            {
                this.pesoRField = value;
            }
        }

        /// <remarks/>
        public string tpVag
        {
            get
            {
                return this.tpVagField;
            }
            set
            {
                this.tpVagField = value;
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
        public string nVag
        {
            get
            {
                return this.nVagField;
            }
            set
            {
                this.nVagField = value;
            }
        }

        /// <remarks/>
        public string nSeq
        {
            get
            {
                return this.nSeqField;
            }
            set
            {
                this.nSeqField = value;
            }
        }

        /// <remarks/>
        public string TU
        {
            get
            {
                return this.tuField;
            }
            set
            {
                this.tuField = value;
            }
        }
    }
}