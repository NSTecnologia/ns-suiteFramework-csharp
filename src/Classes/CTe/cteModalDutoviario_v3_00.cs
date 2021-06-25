namespace NSSuite_CSharp.src.Classes.CTe.Duto
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class duto
    {

        private string vTarField;

        private string dIniField;

        private string dFimField;

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

        /// <remarks/>
        public string dIni
        {
            get
            {
                return this.dIniField;
            }
            set
            {
                this.dIniField = value;
            }
        }

        /// <remarks/>
        public string dFim
        {
            get
            {
                return this.dFimField;
            }
            set
            {
                this.dFimField = value;
            }
        }
    }
}
