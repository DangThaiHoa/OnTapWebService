﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NhapDonVi.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Connect", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Disconnect", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Select", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Select(string strStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool CheckKey(string sql);
        
        // CODEGEN: Parameter 'hinhanh' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NhapDonVi.ServiceReference.InsertResponse Insert(NhapDonVi.ServiceReference.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertDonVi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void InsertDonVi(string strStore, string madv, string tendv);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Insert", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string strStore;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string manv;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string hoten;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int gioitinh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public System.DateTime ngaysinh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string diachi;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] hinhanh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public string madv;
        
        public InsertRequest() {
        }
        
        public InsertRequest(string strStore, string manv, string hoten, int gioitinh, System.DateTime ngaysinh, string diachi, byte[] hinhanh, string madv) {
            this.strStore = strStore;
            this.manv = manv;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.hinhanh = hinhanh;
            this.madv = madv;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertResponse {
        
        public InsertResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : NhapDonVi.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<NhapDonVi.ServiceReference.WebServiceSoap>, NhapDonVi.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Connect() {
            base.Channel.Connect();
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        public System.Data.DataSet Select(string strStore) {
            return base.Channel.Select(strStore);
        }
        
        public bool CheckKey(string sql) {
            return base.Channel.CheckKey(sql);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NhapDonVi.ServiceReference.InsertResponse NhapDonVi.ServiceReference.WebServiceSoap.Insert(NhapDonVi.ServiceReference.InsertRequest request) {
            return base.Channel.Insert(request);
        }
        
        public void Insert(string strStore, string manv, string hoten, int gioitinh, System.DateTime ngaysinh, string diachi, byte[] hinhanh, string madv) {
            NhapDonVi.ServiceReference.InsertRequest inValue = new NhapDonVi.ServiceReference.InsertRequest();
            inValue.strStore = strStore;
            inValue.manv = manv;
            inValue.hoten = hoten;
            inValue.gioitinh = gioitinh;
            inValue.ngaysinh = ngaysinh;
            inValue.diachi = diachi;
            inValue.hinhanh = hinhanh;
            inValue.madv = madv;
            NhapDonVi.ServiceReference.InsertResponse retVal = ((NhapDonVi.ServiceReference.WebServiceSoap)(this)).Insert(inValue);
        }
        
        public void InsertDonVi(string strStore, string madv, string tendv) {
            base.Channel.InsertDonVi(strStore, madv, tendv);
        }
    }
}
