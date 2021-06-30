using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NSSuiteClientCSharp.Projetos.CTe.Requisições
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private string idField;

        /// <remarks/>
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;

        private SignedInfoTypeSignatureMethod signatureMethodField;

        private ReferenceType referenceField;

        private string idField;

        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        public ReferenceType Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithmField;

        public SignedInfoTypeCanonicalizationMethod()
        {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

        private byte[] x509CertificateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {

        private X509DataType x509DataField;

        private string idField;

        /// <remarks/>
        public X509DataType X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {

        private string[] xPathField;

        private TTransformURI algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {

        private TransformType[] transformsField;

        private ReferenceTypeDigestMethod digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {

        private string algorithmField;

        public ReferenceTypeDigestMethod()
        {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        private string algorithmField;

        public SignedInfoTypeSignatureMethod()
        {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute("CTe", Namespace = "http://www.portalfiscal.inf.br/cte", IsNullable = false)]
    public partial class TCTe
    {

        private TCTeInfCte infCteField;

        private TCTeInfCTeSupl infCTeSuplField;

        private SignatureType signatureField;

        /// <remarks/>
        public TCTeInfCte infCte
        {
            get
            {
                return this.infCteField;
            }
            set
            {
                this.infCteField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCTeSupl infCTeSupl
        {
            get
            {
                return this.infCTeSuplField;
            }
            set
            {
                this.infCTeSuplField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCte
    {

        private TCTeInfCteIde ideField;

        private TCTeInfCteCompl complField;

        private TCTeInfCteEmit emitField;

        private TCTeInfCteRem remField;

        private TCTeInfCteExped expedField;

        private TCTeInfCteReceb recebField;

        private TCTeInfCteDest destField;

        private TCTeInfCteVPrest vPrestField;

        private TCTeInfCteImp impField;

        private object itemField;

        private TCTeInfCteAutXML[] autXMLField;

        private TRespTec infRespTecField;

        private TCTeInfCteInfSolicNFF infSolicNFFField;

        private string versaoField;

        private string idField;

        /// <remarks/>
        public TCTeInfCteIde ide
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
        public TCTeInfCteCompl compl
        {
            get
            {
                return this.complField;
            }
            set
            {
                this.complField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteEmit emit
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
        public TCTeInfCteRem rem
        {
            get
            {
                return this.remField;
            }
            set
            {
                this.remField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteExped exped
        {
            get
            {
                return this.expedField;
            }
            set
            {
                this.expedField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteReceb receb
        {
            get
            {
                return this.recebField;
            }
            set
            {
                this.recebField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteDest dest
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
        public TCTeInfCteVPrest vPrest
        {
            get
            {
                return this.vPrestField;
            }
            set
            {
                this.vPrestField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteImp imp
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
        [System.Xml.Serialization.XmlElementAttribute("infCTeNorm", typeof(TCTeInfCteInfCTeNorm))]
        [System.Xml.Serialization.XmlElementAttribute("infCteAnu", typeof(TCTeInfCteInfCteAnu))]
        [System.Xml.Serialization.XmlElementAttribute("infCteComp", typeof(TCTeInfCteInfCteComp))]
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
        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TCTeInfCteAutXML[] autXML
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
        public TCTeInfCteInfSolicNFF infSolicNFF
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteIde
    {

        private TCodUfIBGE cUFField;

        private string cCTField;

        private string cFOPField;

        private string natOpField;

        private TModCT modField;

        private string serieField;

        private string nCTField;

        private string dhEmiField;

        private TCTeInfCteIdeTpImp tpImpField;

        private TCTeInfCteIdeTpEmis tpEmisField;

        private string cDVField;

        private TAmb tpAmbField;

        private TFinCTe tpCTeField;

        private TProcEmi procEmiField;

        private string verProcField;

        private TCTeInfCteIdeIndGlobalizado indGlobalizadoField;

        private bool indGlobalizadoFieldSpecified;

        private string cMunEnvField;

        private string xMunEnvField;

        private TUf uFEnvField;

        private TModTransp modalField;

        private TCTeInfCteIdeTpServ tpServField;

        private string cMunIniField;

        private string xMunIniField;

        private TUf uFIniField;

        private string cMunFimField;

        private string xMunFimField;

        private TUf uFFimField;

        private TCTeInfCteIdeRetira retiraField;

        private string xDetRetiraField;

        private TCTeInfCteIdeIndIEToma indIETomaField;

        private object itemField;

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
        public string cCT
        {
            get
            {
                return this.cCTField;
            }
            set
            {
                this.cCTField = value;
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
        public string natOp
        {
            get
            {
                return this.natOpField;
            }
            set
            {
                this.natOpField = value;
            }
        }

        /// <remarks/>
        public TModCT mod
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
        public string nCT
        {
            get
            {
                return this.nCTField;
            }
            set
            {
                this.nCTField = value;
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
        public TCTeInfCteIdeTpImp tpImp
        {
            get
            {
                return this.tpImpField;
            }
            set
            {
                this.tpImpField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteIdeTpEmis tpEmis
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
        public TFinCTe tpCTe
        {
            get
            {
                return this.tpCTeField;
            }
            set
            {
                this.tpCTeField = value;
            }
        }

        /// <remarks/>
        public TProcEmi procEmi
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
        public TCTeInfCteIdeIndGlobalizado indGlobalizado
        {
            get
            {
                return this.indGlobalizadoField;
            }
            set
            {
                this.indGlobalizadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indGlobalizadoSpecified
        {
            get
            {
                return this.indGlobalizadoFieldSpecified;
            }
            set
            {
                this.indGlobalizadoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string cMunEnv
        {
            get
            {
                return this.cMunEnvField;
            }
            set
            {
                this.cMunEnvField = value;
            }
        }

        /// <remarks/>
        public string xMunEnv
        {
            get
            {
                return this.xMunEnvField;
            }
            set
            {
                this.xMunEnvField = value;
            }
        }

        /// <remarks/>
        public TUf UFEnv
        {
            get
            {
                return this.uFEnvField;
            }
            set
            {
                this.uFEnvField = value;
            }
        }

        /// <remarks/>
        public TModTransp modal
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
        public TCTeInfCteIdeTpServ tpServ
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
        public string xMunIni
        {
            get
            {
                return this.xMunIniField;
            }
            set
            {
                this.xMunIniField = value;
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
        public string xMunFim
        {
            get
            {
                return this.xMunFimField;
            }
            set
            {
                this.xMunFimField = value;
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
        public TCTeInfCteIdeRetira retira
        {
            get
            {
                return this.retiraField;
            }
            set
            {
                this.retiraField = value;
            }
        }

        /// <remarks/>
        public string xDetRetira
        {
            get
            {
                return this.xDetRetiraField;
            }
            set
            {
                this.xDetRetiraField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteIdeIndIEToma indIEToma
        {
            get
            {
                return this.indIETomaField;
            }
            set
            {
                this.indIETomaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("toma3", typeof(TCTeInfCteIdeToma3))]
        [System.Xml.Serialization.XmlElementAttribute("toma4", typeof(TCTeInfCteIdeToma4))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModCT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        Item57,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeTpImp
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeTpEmis
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

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TFinCTe
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TProcEmi
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeIndGlobalizado
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModTransp
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeTpServ
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeRetira
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeIndIEToma
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteIdeToma3
    {

        private TCTeInfCteIdeToma3Toma tomaField;

        /// <remarks/>
        public TCTeInfCteIdeToma3Toma toma
        {
            get
            {
                return this.tomaField;
            }
            set
            {
                this.tomaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeToma3Toma
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteIdeToma4
    {

        private TCTeInfCteIdeToma4Toma tomaField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string ieField;

        private string xNomeField;

        private string xFantField;

        private string foneField;

        private TEndereco enderTomaField;

        private string emailField;

        /// <remarks/>
        public TCTeInfCteIdeToma4Toma toma
        {
            get
            {
                return this.tomaField;
            }
            set
            {
                this.tomaField = value;
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
        public TEndereco enderToma
        {
            get
            {
                return this.enderTomaField;
            }
            set
            {
                this.enderTomaField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteIdeToma4Toma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteCompl
    {

        private string xCaracAdField;

        private string xCaracSerField;

        private string xEmiField;

        private TCTeInfCteComplFluxo fluxoField;

        private TCTeInfCteComplEntrega entregaField;

        private string origCalcField;

        private string destCalcField;

        private string xObsField;

        private TCTeInfCteComplObsCont[] obsContField;

        private TCTeInfCteComplObsFisco[] obsFiscoField;

        /// <remarks/>
        public string xCaracAd
        {
            get
            {
                return this.xCaracAdField;
            }
            set
            {
                this.xCaracAdField = value;
            }
        }

        /// <remarks/>
        public string xCaracSer
        {
            get
            {
                return this.xCaracSerField;
            }
            set
            {
                this.xCaracSerField = value;
            }
        }

        /// <remarks/>
        public string xEmi
        {
            get
            {
                return this.xEmiField;
            }
            set
            {
                this.xEmiField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteComplFluxo fluxo
        {
            get
            {
                return this.fluxoField;
            }
            set
            {
                this.fluxoField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteComplEntrega Entrega
        {
            get
            {
                return this.entregaField;
            }
            set
            {
                this.entregaField = value;
            }
        }

        /// <remarks/>
        public string origCalc
        {
            get
            {
                return this.origCalcField;
            }
            set
            {
                this.origCalcField = value;
            }
        }

        /// <remarks/>
        public string destCalc
        {
            get
            {
                return this.destCalcField;
            }
            set
            {
                this.destCalcField = value;
            }
        }

        /// <remarks/>
        public string xObs
        {
            get
            {
                return this.xObsField;
            }
            set
            {
                this.xObsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObsCont")]
        public TCTeInfCteComplObsCont[] ObsCont
        {
            get
            {
                return this.obsContField;
            }
            set
            {
                this.obsContField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObsFisco")]
        public TCTeInfCteComplObsFisco[] ObsFisco
        {
            get
            {
                return this.obsFiscoField;
            }
            set
            {
                this.obsFiscoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplFluxo
    {

        private string xOrigField;

        private TCTeInfCteComplFluxoPass[] passField;

        private string xDestField;

        private string xRotaField;

        /// <remarks/>
        public string xOrig
        {
            get
            {
                return this.xOrigField;
            }
            set
            {
                this.xOrigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pass")]
        public TCTeInfCteComplFluxoPass[] pass
        {
            get
            {
                return this.passField;
            }
            set
            {
                this.passField = value;
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
        public string xRota
        {
            get
            {
                return this.xRotaField;
            }
            set
            {
                this.xRotaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplFluxoPass
    {

        private string xPassField;

        /// <remarks/>
        public string xPass
        {
            get
            {
                return this.xPassField;
            }
            set
            {
                this.xPassField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntrega
    {

        private object itemField;

        private object item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("comData", typeof(TCTeInfCteComplEntregaComData))]
        [System.Xml.Serialization.XmlElementAttribute("noPeriodo", typeof(TCTeInfCteComplEntregaNoPeriodo))]
        [System.Xml.Serialization.XmlElementAttribute("semData", typeof(TCTeInfCteComplEntregaSemData))]
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
        [System.Xml.Serialization.XmlElementAttribute("comHora", typeof(TCTeInfCteComplEntregaComHora))]
        [System.Xml.Serialization.XmlElementAttribute("noInter", typeof(TCTeInfCteComplEntregaNoInter))]
        [System.Xml.Serialization.XmlElementAttribute("semHora", typeof(TCTeInfCteComplEntregaSemHora))]
        public object Item1
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaComData
    {

        private TCTeInfCteComplEntregaComDataTpPer tpPerField;

        private string dProgField;

        /// <remarks/>
        public TCTeInfCteComplEntregaComDataTpPer tpPer
        {
            get
            {
                return this.tpPerField;
            }
            set
            {
                this.tpPerField = value;
            }
        }

        /// <remarks/>
        public string dProg
        {
            get
            {
                return this.dProgField;
            }
            set
            {
                this.dProgField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaComDataTpPer
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaNoPeriodo
    {

        private TCTeInfCteComplEntregaNoPeriodoTpPer tpPerField;

        private string dIniField;

        private string dFimField;

        /// <remarks/>
        public TCTeInfCteComplEntregaNoPeriodoTpPer tpPer
        {
            get
            {
                return this.tpPerField;
            }
            set
            {
                this.tpPerField = value;
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaNoPeriodoTpPer
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaSemData
    {

        private TCTeInfCteComplEntregaSemDataTpPer tpPerField;

        /// <remarks/>
        public TCTeInfCteComplEntregaSemDataTpPer tpPer
        {
            get
            {
                return this.tpPerField;
            }
            set
            {
                this.tpPerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaSemDataTpPer
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaComHora
    {

        private TCTeInfCteComplEntregaComHoraTpHor tpHorField;

        private string hProgField;

        /// <remarks/>
        public TCTeInfCteComplEntregaComHoraTpHor tpHor
        {
            get
            {
                return this.tpHorField;
            }
            set
            {
                this.tpHorField = value;
            }
        }

        /// <remarks/>
        public string hProg
        {
            get
            {
                return this.hProgField;
            }
            set
            {
                this.hProgField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaComHoraTpHor
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaNoInter
    {

        private TCTeInfCteComplEntregaNoInterTpHor tpHorField;

        private string hIniField;

        private string hFimField;

        /// <remarks/>
        public TCTeInfCteComplEntregaNoInterTpHor tpHor
        {
            get
            {
                return this.tpHorField;
            }
            set
            {
                this.tpHorField = value;
            }
        }

        /// <remarks/>
        public string hIni
        {
            get
            {
                return this.hIniField;
            }
            set
            {
                this.hIniField = value;
            }
        }

        /// <remarks/>
        public string hFim
        {
            get
            {
                return this.hFimField;
            }
            set
            {
                this.hFimField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaNoInterTpHor
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplEntregaSemHora
    {

        private TCTeInfCteComplEntregaSemHoraTpHor tpHorField;

        /// <remarks/>
        public TCTeInfCteComplEntregaSemHoraTpHor tpHor
        {
            get
            {
                return this.tpHorField;
            }
            set
            {
                this.tpHorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteComplEntregaSemHoraTpHor
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplObsCont
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteComplObsFisco
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteEmit
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        private string ieField;

        private string iESTField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TEndeEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private string cEPField;

        private TUF_sem_EX ufField;

        private string foneField;

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
        public TUF_sem_EX UF
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TUF_sem_EX
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteRem
    {

        private string itemField;

        private ItemChoiceType2 itemElementNameField;

        private string ieField;

        private string xNomeField;

        private string xFantField;

        private string foneField;

        private TEndereco enderRemeField;

        private string emailField;

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
        public TEndereco enderReme
        {
            get
            {
                return this.enderRemeField;
            }
            set
            {
                this.enderRemeField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteExped
    {

        private string itemField;

        private ItemChoiceType3 itemElementNameField;

        private string ieField;

        private string xNomeField;

        private string foneField;

        private TEndereco enderExpedField;

        private string emailField;

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
        public ItemChoiceType3 ItemElementName
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
        public TEndereco enderExped
        {
            get
            {
                return this.enderExpedField;
            }
            set
            {
                this.enderExpedField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType3
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteReceb
    {

        private string itemField;

        private ItemChoiceType4 itemElementNameField;

        private string ieField;

        private string xNomeField;

        private string foneField;

        private TEndereco enderRecebField;

        private string emailField;

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
        public ItemChoiceType4 ItemElementName
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
        public TEndereco enderReceb
        {
            get
            {
                return this.enderRecebField;
            }
            set
            {
                this.enderRecebField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType4
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteDest
    {

        private string itemField;

        private ItemChoiceType5 itemElementNameField;

        private string ieField;

        private string xNomeField;

        private string foneField;

        private string iSUFField;

        private TEndereco enderDestField;

        private string emailField;

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
        public ItemChoiceType5 ItemElementName
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
        public string ISUF
        {
            get
            {
                return this.iSUFField;
            }
            set
            {
                this.iSUFField = value;
            }
        }

        /// <remarks/>
        public TEndereco enderDest
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType5
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteVPrest
    {

        private string vTPrestField;

        private string vRecField;

        private TCTeInfCteVPrestComp[] compField;

        /// <remarks/>
        public string vTPrest
        {
            get
            {
                return this.vTPrestField;
            }
            set
            {
                this.vTPrestField = value;
            }
        }

        /// <remarks/>
        public string vRec
        {
            get
            {
                return this.vRecField;
            }
            set
            {
                this.vRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comp")]
        public TCTeInfCteVPrestComp[] Comp
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteVPrestComp
    {

        private string xNomeField;

        private string vCompField;

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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteImp
    {

        private TImp iCMSField;

        private string vTotTribField;

        private string infAdFiscoField;

        private TCTeInfCteImpICMSUFFim iCMSUFFimField;

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
        public TCTeInfCteImpICMSUFFim ICMSUFFim
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImp
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TImpICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TImpICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS45", typeof(TImpICMS45))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TImpICMS60))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TImpICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSOutraUF", typeof(TImpICMSOutraUF))]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMS60
    {

        private TImpICMS60CST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        private string pICMSSTRetField;

        private string vCredField;

        /// <remarks/>
        public TImpICMS60CST CST
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
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        /// <remarks/>
        public string pICMSSTRet
        {
            get
            {
                return this.pICMSSTRetField;
            }
            set
            {
                this.pICMSSTRetField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpICMS60CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TImpICMSOutraUF
    {

        private TImpICMSOutraUFCST cSTField;

        private string pRedBCOutraUFField;

        private string vBCOutraUFField;

        private string pICMSOutraUFField;

        private string vICMSOutraUFField;

        /// <remarks/>
        public TImpICMSOutraUFCST CST
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
        public string pRedBCOutraUF
        {
            get
            {
                return this.pRedBCOutraUFField;
            }
            set
            {
                this.pRedBCOutraUFField = value;
            }
        }

        /// <remarks/>
        public string vBCOutraUF
        {
            get
            {
                return this.vBCOutraUFField;
            }
            set
            {
                this.vBCOutraUFField = value;
            }
        }

        /// <remarks/>
        public string pICMSOutraUF
        {
            get
            {
                return this.pICMSOutraUFField;
            }
            set
            {
                this.pICMSOutraUFField = value;
            }
        }

        /// <remarks/>
        public string vICMSOutraUF
        {
            get
            {
                return this.vICMSOutraUFField;
            }
            set
            {
                this.vICMSOutraUFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpICMSOutraUFCST
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TImpICMSSNCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteImpICMSUFFim
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNorm
    {

        private TCTeInfCteInfCTeNormInfCarga infCargaField;

        private TCTeInfCteInfCTeNormInfDoc infDocField;

        private TCTeInfCteInfCTeNormEmiDocAnt[] docAntField;

        private TCTeInfCteInfCTeNormInfModal infModalField;

        private TCTeInfCteInfCTeNormVeicNovos[] veicNovosField;

        private TCTeInfCteInfCTeNormCobr cobrField;

        private TCTeInfCteInfCTeNormInfCteSub infCteSubField;

        private TCTeInfCteInfCTeNormInfGlobalizado infGlobalizadoField;

        private TCTeInfCteInfCTeNormInfCTeMultimodal[] infServVincField;

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfCarga infCarga
        {
            get
            {
                return this.infCargaField;
            }
            set
            {
                this.infCargaField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfDoc infDoc
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
        [System.Xml.Serialization.XmlArrayItemAttribute("emiDocAnt", IsNullable = false)]
        public TCTeInfCteInfCTeNormEmiDocAnt[] docAnt
        {
            get
            {
                return this.docAntField;
            }
            set
            {
                this.docAntField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfModal infModal
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
        [System.Xml.Serialization.XmlElementAttribute("veicNovos")]
        public TCTeInfCteInfCTeNormVeicNovos[] veicNovos
        {
            get
            {
                return this.veicNovosField;
            }
            set
            {
                this.veicNovosField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteInfCTeNormCobr cobr
        {
            get
            {
                return this.cobrField;
            }
            set
            {
                this.cobrField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfCteSub infCteSub
        {
            get
            {
                return this.infCteSubField;
            }
            set
            {
                this.infCteSubField = value;
            }
        }

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfGlobalizado infGlobalizado
        {
            get
            {
                return this.infGlobalizadoField;
            }
            set
            {
                this.infGlobalizadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("infCTeMultimodal", IsNullable = false)]
        public TCTeInfCteInfCTeNormInfCTeMultimodal[] infServVinc
        {
            get
            {
                return this.infServVincField;
            }
            set
            {
                this.infServVincField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCarga
    {

        private string vCargaField;

        private string proPredField;

        private string xOutCatField;

        private TCTeInfCteInfCTeNormInfCargaInfQ[] infQField;

        private string vCargaAverbField;

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
        public string proPred
        {
            get
            {
                return this.proPredField;
            }
            set
            {
                this.proPredField = value;
            }
        }

        /// <remarks/>
        public string xOutCat
        {
            get
            {
                return this.xOutCatField;
            }
            set
            {
                this.xOutCatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infQ")]
        public TCTeInfCteInfCTeNormInfCargaInfQ[] infQ
        {
            get
            {
                return this.infQField;
            }
            set
            {
                this.infQField = value;
            }
        }

        /// <remarks/>
        public string vCargaAverb
        {
            get
            {
                return this.vCargaAverbField;
            }
            set
            {
                this.vCargaAverbField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCargaInfQ
    {

        private TCTeInfCteInfCTeNormInfCargaInfQCUnid cUnidField;

        private string tpMedField;

        private string qCargaField;

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfCargaInfQCUnid cUnid
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
        public string tpMed
        {
            get
            {
                return this.tpMedField;
            }
            set
            {
                this.tpMedField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormInfCargaInfQCUnid
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDoc
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infNF", typeof(TCTeInfCteInfCTeNormInfDocInfNF))]
        [System.Xml.Serialization.XmlElementAttribute("infNFe", typeof(TCTeInfCteInfCTeNormInfDocInfNFe))]
        [System.Xml.Serialization.XmlElementAttribute("infOutros", typeof(TCTeInfCteInfCTeNormInfDocInfOutros))]
        public object[] Items
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDocInfNF
    {

        private string nRomaField;

        private string nPedField;

        private TModNF modField;

        private string serieField;

        private string nDocField;

        private string dEmiField;

        private string vBCField;

        private string vICMSField;

        private string vBCSTField;

        private string vSTField;

        private string vProdField;

        private string vNFField;

        private string nCFOPField;

        private string nPesoField;

        private string pINField;

        private string dPrevField;

        private object[] itemsField;

        /// <remarks/>
        public string nRoma
        {
            get
            {
                return this.nRomaField;
            }
            set
            {
                this.nRomaField = value;
            }
        }

        /// <remarks/>
        public string nPed
        {
            get
            {
                return this.nPedField;
            }
            set
            {
                this.nPedField = value;
            }
        }

        /// <remarks/>
        public TModNF mod
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
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
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

        /// <remarks/>
        public string nCFOP
        {
            get
            {
                return this.nCFOPField;
            }
            set
            {
                this.nCFOPField = value;
            }
        }

        /// <remarks/>
        public string nPeso
        {
            get
            {
                return this.nPesoField;
            }
            set
            {
                this.nPesoField = value;
            }
        }

        /// <remarks/>
        public string PIN
        {
            get
            {
                return this.pINField;
            }
            set
            {
                this.pINField = value;
            }
        }

        /// <remarks/>
        public string dPrev
        {
            get
            {
                return this.dPrevField;
            }
            set
            {
                this.dPrevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga", typeof(TUnidCarga))]
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp", typeof(TUnidadeTransp))]
        public object[] Items
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDocInfNFe
    {

        private string chaveField;

        private string pINField;

        private string dPrevField;

        private object[] itemsField;

        /// <remarks/>
        public string chave
        {
            get
            {
                return this.chaveField;
            }
            set
            {
                this.chaveField = value;
            }
        }

        /// <remarks/>
        public string PIN
        {
            get
            {
                return this.pINField;
            }
            set
            {
                this.pINField = value;
            }
        }

        /// <remarks/>
        public string dPrev
        {
            get
            {
                return this.dPrevField;
            }
            set
            {
                this.dPrevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga", typeof(TUnidCarga))]
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp", typeof(TUnidadeTransp))]
        public object[] Items
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfDocInfOutros
    {

        private TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc tpDocField;

        private string descOutrosField;

        private string nDocField;

        private string dEmiField;

        private string vDocFiscField;

        private string dPrevField;

        private object[] itemsField;

        /// <remarks/>
        public TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc tpDoc
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
        public string descOutros
        {
            get
            {
                return this.descOutrosField;
            }
            set
            {
                this.descOutrosField = value;
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
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        /// <remarks/>
        public string vDocFisc
        {
            get
            {
                return this.vDocFiscField;
            }
            set
            {
                this.vDocFiscField = value;
            }
        }

        /// <remarks/>
        public string dPrev
        {
            get
            {
                return this.dPrevField;
            }
            set
            {
                this.dPrevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infUnidCarga", typeof(TUnidCarga))]
        [System.Xml.Serialization.XmlElementAttribute("infUnidTransp", typeof(TUnidadeTransp))]
        public object[] Items
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

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
    public partial class TCTeInfCteInfCTeNormEmiDocAnt
    {

        private string itemField;

        private ItemChoiceType6 itemElementNameField;

        private string ieField;

        private TUf ufField;

        private string xNomeField;

        private TCTeInfCteInfCTeNormEmiDocAntIdDocAnt[] idDocAntField;

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
        public ItemChoiceType6 ItemElementName
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
        [System.Xml.Serialization.XmlElementAttribute("idDocAnt")]
        public TCTeInfCteInfCTeNormEmiDocAntIdDocAnt[] idDocAnt
        {
            get
            {
                return this.idDocAntField;
            }
            set
            {
                this.idDocAntField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType6
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAntIdDocAnt
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("idDocAntEle", typeof(TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntEle))]
        [System.Xml.Serialization.XmlElementAttribute("idDocAntPap", typeof(TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPap))]
        public object[] Items
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntEle
    {

        private string chCTeField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPap
    {

        private TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPapTpDoc tpDocField;

        private string serieField;

        private string subserField;

        private string nDocField;

        private string dEmiField;

        /// <remarks/>
        public TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPapTpDoc tpDoc
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
        public string subser
        {
            get
            {
                return this.subserField;
            }
            set
            {
                this.subserField = value;
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
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPapTpDoc
    {

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfModal
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormVeicNovos
    {

        private string chassiField;

        private string cCorField;

        private string xCorField;

        private string cModField;

        private string vUnitField;

        private string vFreteField;

        /// <remarks/>
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
            }
        }

        /// <remarks/>
        public string cCor
        {
            get
            {
                return this.cCorField;
            }
            set
            {
                this.cCorField = value;
            }
        }

        /// <remarks/>
        public string xCor
        {
            get
            {
                return this.xCorField;
            }
            set
            {
                this.xCorField = value;
            }
        }

        /// <remarks/>
        public string cMod
        {
            get
            {
                return this.cModField;
            }
            set
            {
                this.cModField = value;
            }
        }

        /// <remarks/>
        public string vUnit
        {
            get
            {
                return this.vUnitField;
            }
            set
            {
                this.vUnitField = value;
            }
        }

        /// <remarks/>
        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormCobr
    {

        private TCTeInfCteInfCTeNormCobrFat fatField;

        private TCTeInfCteInfCTeNormCobrDup[] dupField;

        /// <remarks/>
        public TCTeInfCteInfCTeNormCobrFat fat
        {
            get
            {
                return this.fatField;
            }
            set
            {
                this.fatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dup")]
        public TCTeInfCteInfCTeNormCobrDup[] dup
        {
            get
            {
                return this.dupField;
            }
            set
            {
                this.dupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormCobrFat
    {

        private string nFatField;

        private string vOrigField;

        private string vDescField;

        private string vLiqField;

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
        public string vOrig
        {
            get
            {
                return this.vOrigField;
            }
            set
            {
                this.vOrigField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <remarks/>
        public string vLiq
        {
            get
            {
                return this.vLiqField;
            }
            set
            {
                this.vLiqField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormCobrDup
    {

        private string nDupField;

        private string dVencField;

        private string vDupField;

        /// <remarks/>
        public string nDup
        {
            get
            {
                return this.nDupField;
            }
            set
            {
                this.nDupField = value;
            }
        }

        /// <remarks/>
        public string dVenc
        {
            get
            {
                return this.dVencField;
            }
            set
            {
                this.dVencField = value;
            }
        }

        /// <remarks/>
        public string vDup
        {
            get
            {
                return this.vDupField;
            }
            set
            {
                this.vDupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCteSub
    {

        private string chCteField;

        private object itemField;

        private TCTeInfCteInfCTeNormInfCteSubIndAlteraToma indAlteraTomaField;

        private bool indAlteraTomaFieldSpecified;

        /// <remarks/>
        public string chCte
        {
            get
            {
                return this.chCteField;
            }
            set
            {
                this.chCteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("refCteAnu", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("tomaICMS", typeof(TCTeInfCteInfCTeNormInfCteSubTomaICMS))]
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
        public TCTeInfCteInfCTeNormInfCteSubIndAlteraToma indAlteraToma
        {
            get
            {
                return this.indAlteraTomaField;
            }
            set
            {
                this.indAlteraTomaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indAlteraTomaSpecified
        {
            get
            {
                return this.indAlteraTomaFieldSpecified;
            }
            set
            {
                this.indAlteraTomaFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCteSubTomaICMS
    {

        private object itemField;

        private ItemChoiceType8 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("refCte", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TCTeInfCteInfCTeNormInfCteSubTomaICMSRefNF))]
        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType8 ItemElementName
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCteSubTomaICMSRefNF
    {

        private string itemField;

        private ItemChoiceType7 itemElementNameField;

        private TModDoc modField;

        private string serieField;

        private string subserieField;

        private string nroField;

        private string valorField;

        private string dEmiField;

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
        public ItemChoiceType7 ItemElementName
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
        public TModDoc mod
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
        public string subserie
        {
            get
            {
                return this.subserieField;
            }
            set
            {
                this.subserieField = value;
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
        public string valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }

        /// <remarks/>
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType7
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TModDoc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1B")]
        Item1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2E")]
        Item2E,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

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
        [System.Xml.Serialization.XmlEnumAttribute("8B")]
        Item8B,

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
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType8
    {

        /// <remarks/>
        refCte,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFe,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public enum TCTeInfCteInfCTeNormInfCteSubIndAlteraToma
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfGlobalizado
    {

        private string xObsField;

        /// <remarks/>
        public string xObs
        {
            get
            {
                return this.xObsField;
            }
            set
            {
                this.xObsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCTeNormInfCTeMultimodal
    {

        private string chCTeMultimodalField;

        /// <remarks/>
        public string chCTeMultimodal
        {
            get
            {
                return this.chCTeMultimodalField;
            }
            set
            {
                this.chCTeMultimodalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCteAnu
    {

        private string chCteField;

        private string dEmiField;

        /// <remarks/>
        public string chCte
        {
            get
            {
                return this.chCteField;
            }
            set
            {
                this.chCteField = value;
            }
        }

        /// <remarks/>
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfCteComp
    {

        private string chCTeField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteAutXML
    {

        private string itemField;

        private ItemChoiceType9 itemElementNameField;

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
        public ItemChoiceType9 ItemElementName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte", IncludeInSchema = false)]
    public enum ItemChoiceType9
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCteInfSolicNFF
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/cte")]
    public partial class TCTeInfCTeSupl
    {

        private string qrCodCTeField;

        /// <remarks/>
        public string qrCodCTe
        {
            get
            {
                return this.qrCodCTeField;
            }
            set
            {
                this.qrCodCTeField = value;
            }
        }
    }
}
