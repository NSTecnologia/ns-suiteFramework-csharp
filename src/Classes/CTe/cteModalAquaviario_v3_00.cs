namespace NSSuite_CSharp.src.Classes.CTe.Aquav {

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IsNullable=false)]
public partial class aquav {
    
    private string vPrestField;
    
    private string vAFRMMField;
    
    private string xNavioField;
    
    private aquavBalsa[] balsaField;
    
    private string nViagField;
    
    private aquavDirec direcField;
    
    private string irinField;
    
    private aquavDetCont[] detContField;
    
    private aquavTpNav tpNavField;
    
    private bool tpNavFieldSpecified;
    
    /// <remarks/>
    public string vPrest {
        get {
            return this.vPrestField;
        }
        set {
            this.vPrestField = value;
        }
    }
    
    /// <remarks/>
    public string vAFRMM {
        get {
            return this.vAFRMMField;
        }
        set {
            this.vAFRMMField = value;
        }
    }
    
    /// <remarks/>
    public string xNavio {
        get {
            return this.xNavioField;
        }
        set {
            this.xNavioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("balsa")]
    public aquavBalsa[] balsa {
        get {
            return this.balsaField;
        }
        set {
            this.balsaField = value;
        }
    }
    
    /// <remarks/>
    public string nViag {
        get {
            return this.nViagField;
        }
        set {
            this.nViagField = value;
        }
    }
    
    /// <remarks/>
    public aquavDirec direc {
        get {
            return this.direcField;
        }
        set {
            this.direcField = value;
        }
    }
    
    /// <remarks/>
    public string irin {
        get {
            return this.irinField;
        }
        set {
            this.irinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("detCont")]
    public aquavDetCont[] detCont {
        get {
            return this.detContField;
        }
        set {
            this.detContField = value;
        }
    }
    
    /// <remarks/>
    public aquavTpNav tpNav {
        get {
            return this.tpNavField;
        }
        set {
            this.tpNavField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tpNavSpecified {
        get {
            return this.tpNavFieldSpecified;
        }
        set {
            this.tpNavFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public partial class aquavBalsa {
    
    private string xBalsaField;
    
    /// <remarks/>
    public string xBalsa {
        get {
            return this.xBalsaField;
        }
        set {
            this.xBalsaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public enum aquavDirec {
    
    /// <remarks/>
    N,
    
    /// <remarks/>
    S,
    
    /// <remarks/>
    L,
    
    /// <remarks/>
    O,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public partial class aquavDetCont {
    
    private string nContField;
    
    private aquavDetContLacre[] lacreField;
    
    private aquavDetContInfDoc infDocField;
    
    /// <remarks/>
    public string nCont {
        get {
            return this.nContField;
        }
        set {
            this.nContField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("lacre")]
    public aquavDetContLacre[] lacre {
        get {
            return this.lacreField;
        }
        set {
            this.lacreField = value;
        }
    }
    
    /// <remarks/>
    public aquavDetContInfDoc infDoc {
        get {
            return this.infDocField;
        }
        set {
            this.infDocField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public partial class aquavDetContLacre {
    
    private string nLacreField;
    
    /// <remarks/>
    public string nLacre {
        get {
            return this.nLacreField;
        }
        set {
            this.nLacreField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public partial class aquavDetContInfDoc {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infNF", typeof(aquavDetContInfDocInfNF))]
    [System.Xml.Serialization.XmlElementAttribute("infNFe", typeof(aquavDetContInfDocInfNFe))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public partial class aquavDetContInfDocInfNF {
    
    private string serieField;
    
    private string nDocField;
    
    private string unidRatField;
    
    /// <remarks/>
    public string serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    public string nDoc {
        get {
            return this.nDocField;
        }
        set {
            this.nDocField = value;
        }
    }
    
    /// <remarks/>
    public string unidRat {
        get {
            return this.unidRatField;
        }
        set {
            this.unidRatField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public partial class aquavDetContInfDocInfNFe {
    
    private string chaveField;
    
    private string unidRatField;
    
    /// <remarks/>
    public string chave {
        get {
            return this.chaveField;
        }
        set {
            this.chaveField = value;
        }
    }
    
    /// <remarks/>
    public string unidRat {
        get {
            return this.unidRatField;
        }
        set {
            this.unidRatField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
public enum aquavTpNav {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}
}
