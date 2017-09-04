﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="https://ws.geonorge.no/SKWS2/services/SSR", ConfigurationName="SSR")]
public interface SSR
{
    
    // CODEGEN: Generating message contract since the wrapper namespace (http://ws.ngisssrws.sk.hosledata.no) of message ssrSokRequest does not match the default value (https://ws.geonorge.no/SKWS2/services/SSR)
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SsrRecord))]
    ssrSokResponse ssrSok(ssrSokRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<ssrSokResponse> ssrSokAsync(ssrSokRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:ssr2.ws.statkart.no")]
public partial class SsrSokRes
{
    
    private SsrSokStatus sokStatusField;
    
    private SsrRecord[] ssrRecordsField;
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public SsrSokStatus sokStatus
    {
        get
        {
            return this.sokStatusField;
        }
        set
        {
            this.sokStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public SsrRecord[] ssrRecords
    {
        get
        {
            return this.ssrRecordsField;
        }
        set
        {
            this.ssrRecordsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:ssr2.ws.statkart.no")]
public partial class SsrSokStatus
{
    
    private string meldingField;
    
    private bool mereDataField;
    
    private bool okField;
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public string melding
    {
        get
        {
            return this.meldingField;
        }
        set
        {
            this.meldingField = value;
        }
    }
    
    /// <remarks/>
    public bool mereData
    {
        get
        {
            return this.mereDataField;
        }
        set
        {
            this.mereDataField = value;
        }
    }
    
    /// <remarks/>
    public bool ok
    {
        get
        {
            return this.okField;
        }
        set
        {
            this.okField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:ssr2.ws.statkart.no")]
public partial class SsrRecord
{
    
    private int enh_navntypeField;
    
    private string enh_snspraakField;
    
    private double for_aust1Field;
    
    private int for_kommField;
    
    private double for_nord1Field;
    
    private string for_produktField;
    
    private string for_snavnField;
    
    private string kom_navnField;
    
    private string nty_tekstField;
    
    private int sosiKoordSystField;
    
    /// <remarks/>
    public int enh_navntype
    {
        get
        {
            return this.enh_navntypeField;
        }
        set
        {
            this.enh_navntypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public string enh_snspraak
    {
        get
        {
            return this.enh_snspraakField;
        }
        set
        {
            this.enh_snspraakField = value;
        }
    }
    
    /// <remarks/>
    public double for_aust1
    {
        get
        {
            return this.for_aust1Field;
        }
        set
        {
            this.for_aust1Field = value;
        }
    }
    
    /// <remarks/>
    public int for_komm
    {
        get
        {
            return this.for_kommField;
        }
        set
        {
            this.for_kommField = value;
        }
    }
    
    /// <remarks/>
    public double for_nord1
    {
        get
        {
            return this.for_nord1Field;
        }
        set
        {
            this.for_nord1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public string for_produkt
    {
        get
        {
            return this.for_produktField;
        }
        set
        {
            this.for_produktField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public string for_snavn
    {
        get
        {
            return this.for_snavnField;
        }
        set
        {
            this.for_snavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public string kom_navn
    {
        get
        {
            return this.kom_navnField;
        }
        set
        {
            this.kom_navnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
    public string nty_tekst
    {
        get
        {
            return this.nty_tekstField;
        }
        set
        {
            this.nty_tekstField = value;
        }
    }
    
    /// <remarks/>
    public int sosiKoordSyst
    {
        get
        {
            return this.sosiKoordSystField;
        }
        set
        {
            this.sosiKoordSystField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ssrSok", WrapperNamespace="http://ws.ngisssrws.sk.hosledata.no", IsWrapped=true)]
public partial class ssrSokRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public string brukerid;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
    public string passord;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
    public string aliasId;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
    public string navn;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
    public string fylkeKommueListe;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
    public int nordLL;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=6)]
    public int ostLL;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=7)]
    public int nordUR;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=8)]
    public int ostUR;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=9)]
    public int maxAnt;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=10)]
    public int sosiKoordSyst;
    
    public ssrSokRequest()
    {
    }
    
    public ssrSokRequest(string brukerid, string passord, string aliasId, string navn, string fylkeKommueListe, int nordLL, int ostLL, int nordUR, int ostUR, int maxAnt, int sosiKoordSyst)
    {
        this.brukerid = brukerid;
        this.passord = passord;
        this.aliasId = aliasId;
        this.navn = navn;
        this.fylkeKommueListe = fylkeKommueListe;
        this.nordLL = nordLL;
        this.ostLL = ostLL;
        this.nordUR = nordUR;
        this.ostUR = ostUR;
        this.maxAnt = maxAnt;
        this.sosiKoordSyst = sosiKoordSyst;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ssrSokResponse", WrapperNamespace="https://ws.geonorge.no/SKWS2/services/SSR", IsWrapped=true)]
public partial class ssrSokResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public SsrSokRes ssrSokReturn;
    
    public ssrSokResponse()
    {
    }
    
    public ssrSokResponse(SsrSokRes ssrSokReturn)
    {
        this.ssrSokReturn = ssrSokReturn;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface SSRChannel : SSR, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SSRClient : System.ServiceModel.ClientBase<SSR>, SSR
{
    
    public SSRClient()
    {
    }
    
    public SSRClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SSRClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SSRClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SSRClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ssrSokResponse SSR.ssrSok(ssrSokRequest request)
    {
        return base.Channel.ssrSok(request);
    }
    
    public SsrSokRes ssrSok(string brukerid, string passord, string aliasId, string navn, string fylkeKommueListe, int nordLL, int ostLL, int nordUR, int ostUR, int maxAnt, int sosiKoordSyst)
    {
        ssrSokRequest inValue = new ssrSokRequest();
        inValue.brukerid = brukerid;
        inValue.passord = passord;
        inValue.aliasId = aliasId;
        inValue.navn = navn;
        inValue.fylkeKommueListe = fylkeKommueListe;
        inValue.nordLL = nordLL;
        inValue.ostLL = ostLL;
        inValue.nordUR = nordUR;
        inValue.ostUR = ostUR;
        inValue.maxAnt = maxAnt;
        inValue.sosiKoordSyst = sosiKoordSyst;
        ssrSokResponse retVal = ((SSR)(this)).ssrSok(inValue);
        return retVal.ssrSokReturn;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ssrSokResponse> SSR.ssrSokAsync(ssrSokRequest request)
    {
        return base.Channel.ssrSokAsync(request);
    }
    
    public System.Threading.Tasks.Task<ssrSokResponse> ssrSokAsync(string brukerid, string passord, string aliasId, string navn, string fylkeKommueListe, int nordLL, int ostLL, int nordUR, int ostUR, int maxAnt, int sosiKoordSyst)
    {
        ssrSokRequest inValue = new ssrSokRequest();
        inValue.brukerid = brukerid;
        inValue.passord = passord;
        inValue.aliasId = aliasId;
        inValue.navn = navn;
        inValue.fylkeKommueListe = fylkeKommueListe;
        inValue.nordLL = nordLL;
        inValue.ostLL = ostLL;
        inValue.nordUR = nordUR;
        inValue.ostUR = ostUR;
        inValue.maxAnt = maxAnt;
        inValue.sosiKoordSyst = sosiKoordSyst;
        return ((SSR)(this)).ssrSokAsync(inValue);
    }
}
