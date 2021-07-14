namespace NSSuite_CSharp.src.Classes.MDFe.Aereo
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/mdfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/mdfe", IsNullable = false)]
    public partial class aereo
    {

        private string nacField;

        private string matrField;

        private string nVooField;

        private string cAerEmbField;

        private string cAerDesField;

        private string dVooField;

        /// <remarks/>
        public string nac
        {
            get
            {
                return this.nacField;
            }
            set
            {
                this.nacField = value;
            }
        }

        /// <remarks/>
        public string matr
        {
            get
            {
                return this.matrField;
            }
            set
            {
                this.matrField = value;
            }
        }

        /// <remarks/>
        public string nVoo
        {
            get
            {
                return this.nVooField;
            }
            set
            {
                this.nVooField = value;
            }
        }

        /// <remarks/>
        public string cAerEmb
        {
            get
            {
                return this.cAerEmbField;
            }
            set
            {
                this.cAerEmbField = value;
            }
        }

        /// <remarks/>
        public string cAerDes
        {
            get
            {
                return this.cAerDesField;
            }
            set
            {
                this.cAerDesField = value;
            }
        }

        /// <remarks/>
        public string dVoo
        {
            get
            {
                return this.dVooField;
            }
            set
            {
                this.dVooField = value;
            }
        }
    }
}