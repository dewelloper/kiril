﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Markum.Cloud.Libraries.ListMember {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", ConfigurationName="ListMember.ListMemberSoap")]
    public interface ListMemberSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/AddListMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        long AddListMember(string PostOffice, string ListName, string ListMemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/AddListMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> AddListMemberAsync(string PostOffice, string ListName, string ListMemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/GetListMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        long GetListMember(string PostOffice, string ListName, string ListMemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/GetListMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> GetListMemberAsync(string PostOffice, string ListName, string ListMemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/GetListMemberObjectProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesResponse GetListMemberObjectProperties(Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/GetListMemberObjectProperties", ReplyAction="*")]
        System.Threading.Tasks.Task<Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesResponse> GetListMemberObjectPropertiesAsync(Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/ListListMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        Markum.Cloud.Libraries.ListMember.ListListMemberResponse ListListMember(Markum.Cloud.Libraries.ListMember.ListListMemberRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/ListListMember", ReplyAction="*")]
        System.Threading.Tasks.Task<Markum.Cloud.Libraries.ListMember.ListListMemberResponse> ListListMemberAsync(Markum.Cloud.Libraries.ListMember.ListListMemberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/RemoveListMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        long RemoveListMember(string PostOffice, string ListName, string ListMemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/RemoveListMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> RemoveListMemberAsync(string PostOffice, string ListName, string ListMemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/EditListMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        long EditListMember(string PostOffice, string ListName, string ListMemberAddress, string NewListMemberAddress, string NewPostoffice, string NewListName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/ListMember/EditListMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> EditListMemberAsync(string PostOffice, string ListName, string ListMemberAddress, string NewListMemberAddress, string NewPostoffice, string NewListName);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember")]
    public partial class ListMember : MarshalByRefObject {
        
        private string addressField;
        
        private string accountNameField;
        
        private string listNameField;
        
        private long listMemberTypeField;
        
        private long statusField;
        
        private string hostField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AccountName {
            get {
                return this.accountNameField;
            }
            set {
                this.accountNameField = value;
                this.RaisePropertyChanged("AccountName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ListName {
            get {
                return this.listNameField;
            }
            set {
                this.listNameField = value;
                this.RaisePropertyChanged("ListName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public long ListMemberType {
            get {
                return this.listMemberTypeField;
            }
            set {
                this.listMemberTypeField = value;
                this.RaisePropertyChanged("ListMemberType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public long Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Host {
            get {
                return this.hostField;
            }
            set {
                this.hostField = value;
                this.RaisePropertyChanged("Host");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListMember))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember")]
    public abstract partial class MarshalByRefObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetListMemberObjectProperties", WrapperNamespace="http://mailenable.com/MEWebAdminService/ListMember", IsWrapped=true)]
    public partial class GetListMemberObjectPropertiesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=0)]
        public string PostOffice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=1)]
        public string ListName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=2)]
        public string ListMemberAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=3)]
        public Markum.Cloud.Libraries.ListMember.ListMember ObjectProperties;
        
        public GetListMemberObjectPropertiesRequest() {
        }
        
        public GetListMemberObjectPropertiesRequest(string PostOffice, string ListName, string ListMemberAddress, Markum.Cloud.Libraries.ListMember.ListMember ObjectProperties) {
            this.PostOffice = PostOffice;
            this.ListName = ListName;
            this.ListMemberAddress = ListMemberAddress;
            this.ObjectProperties = ObjectProperties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetListMemberObjectPropertiesResponse", WrapperNamespace="http://mailenable.com/MEWebAdminService/ListMember", IsWrapped=true)]
    public partial class GetListMemberObjectPropertiesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=0)]
        public long GetListMemberObjectPropertiesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=1)]
        public Markum.Cloud.Libraries.ListMember.ListMember ObjectProperties;
        
        public GetListMemberObjectPropertiesResponse() {
        }
        
        public GetListMemberObjectPropertiesResponse(long GetListMemberObjectPropertiesResult, Markum.Cloud.Libraries.ListMember.ListMember ObjectProperties) {
            this.GetListMemberObjectPropertiesResult = GetListMemberObjectPropertiesResult;
            this.ObjectProperties = ObjectProperties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListListMember", WrapperNamespace="http://mailenable.com/MEWebAdminService/ListMember", IsWrapped=true)]
    public partial class ListListMemberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=0)]
        public Markum.Cloud.Libraries.ListMember.ListMember[] ObjectList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=1)]
        public string PostOffice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=2)]
        public string ListName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=3)]
        public string ListMemberAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=4)]
        public long Status;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=5)]
        public long ListMemberType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=6)]
        public long Top;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=7)]
        public long MaxLength;
        
        public ListListMemberRequest() {
        }
        
        public ListListMemberRequest(Markum.Cloud.Libraries.ListMember.ListMember[] ObjectList, string PostOffice, string ListName, string ListMemberAddress, long Status, long ListMemberType, long Top, long MaxLength) {
            this.ObjectList = ObjectList;
            this.PostOffice = PostOffice;
            this.ListName = ListName;
            this.ListMemberAddress = ListMemberAddress;
            this.Status = Status;
            this.ListMemberType = ListMemberType;
            this.Top = Top;
            this.MaxLength = MaxLength;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListListMemberResponse", WrapperNamespace="http://mailenable.com/MEWebAdminService/ListMember", IsWrapped=true)]
    public partial class ListListMemberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=0)]
        public long ListListMemberResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/ListMember", Order=1)]
        public Markum.Cloud.Libraries.ListMember.ListMember[] ObjectList;
        
        public ListListMemberResponse() {
        }
        
        public ListListMemberResponse(long ListListMemberResult, Markum.Cloud.Libraries.ListMember.ListMember[] ObjectList) {
            this.ListListMemberResult = ListListMemberResult;
            this.ObjectList = ObjectList;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ListMemberSoapChannel : Markum.Cloud.Libraries.ListMember.ListMemberSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListMemberSoapClient : System.ServiceModel.ClientBase<Markum.Cloud.Libraries.ListMember.ListMemberSoap>, Markum.Cloud.Libraries.ListMember.ListMemberSoap {
        
        public ListMemberSoapClient() {
        }
        
        public ListMemberSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ListMemberSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListMemberSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListMemberSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long AddListMember(string PostOffice, string ListName, string ListMemberAddress) {
            return base.Channel.AddListMember(PostOffice, ListName, ListMemberAddress);
        }
        
        public System.Threading.Tasks.Task<long> AddListMemberAsync(string PostOffice, string ListName, string ListMemberAddress) {
            return base.Channel.AddListMemberAsync(PostOffice, ListName, ListMemberAddress);
        }
        
        public long GetListMember(string PostOffice, string ListName, string ListMemberAddress) {
            return base.Channel.GetListMember(PostOffice, ListName, ListMemberAddress);
        }
        
        public System.Threading.Tasks.Task<long> GetListMemberAsync(string PostOffice, string ListName, string ListMemberAddress) {
            return base.Channel.GetListMemberAsync(PostOffice, ListName, ListMemberAddress);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesResponse Markum.Cloud.Libraries.ListMember.ListMemberSoap.GetListMemberObjectProperties(Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesRequest request) {
            return base.Channel.GetListMemberObjectProperties(request);
        }
        
        public long GetListMemberObjectProperties(string PostOffice, string ListName, string ListMemberAddress, ref Markum.Cloud.Libraries.ListMember.ListMember ObjectProperties) {
            Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesRequest inValue = new Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesRequest();
            inValue.PostOffice = PostOffice;
            inValue.ListName = ListName;
            inValue.ListMemberAddress = ListMemberAddress;
            inValue.ObjectProperties = ObjectProperties;
            Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesResponse retVal = ((Markum.Cloud.Libraries.ListMember.ListMemberSoap)(this)).GetListMemberObjectProperties(inValue);
            ObjectProperties = retVal.ObjectProperties;
            return retVal.GetListMemberObjectPropertiesResult;
        }
        
        public System.Threading.Tasks.Task<Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesResponse> GetListMemberObjectPropertiesAsync(Markum.Cloud.Libraries.ListMember.GetListMemberObjectPropertiesRequest request) {
            return base.Channel.GetListMemberObjectPropertiesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Markum.Cloud.Libraries.ListMember.ListListMemberResponse Markum.Cloud.Libraries.ListMember.ListMemberSoap.ListListMember(Markum.Cloud.Libraries.ListMember.ListListMemberRequest request) {
            return base.Channel.ListListMember(request);
        }
        
        public long ListListMember(ref Markum.Cloud.Libraries.ListMember.ListMember[] ObjectList, string PostOffice, string ListName, string ListMemberAddress, long Status, long ListMemberType, long Top, long MaxLength) {
            Markum.Cloud.Libraries.ListMember.ListListMemberRequest inValue = new Markum.Cloud.Libraries.ListMember.ListListMemberRequest();
            inValue.ObjectList = ObjectList;
            inValue.PostOffice = PostOffice;
            inValue.ListName = ListName;
            inValue.ListMemberAddress = ListMemberAddress;
            inValue.Status = Status;
            inValue.ListMemberType = ListMemberType;
            inValue.Top = Top;
            inValue.MaxLength = MaxLength;
            Markum.Cloud.Libraries.ListMember.ListListMemberResponse retVal = ((Markum.Cloud.Libraries.ListMember.ListMemberSoap)(this)).ListListMember(inValue);
            ObjectList = retVal.ObjectList;
            return retVal.ListListMemberResult;
        }
        
        public System.Threading.Tasks.Task<Markum.Cloud.Libraries.ListMember.ListListMemberResponse> ListListMemberAsync(Markum.Cloud.Libraries.ListMember.ListListMemberRequest request) {
            return base.Channel.ListListMemberAsync(request);
        }
        
        public long RemoveListMember(string PostOffice, string ListName, string ListMemberAddress) {
            return base.Channel.RemoveListMember(PostOffice, ListName, ListMemberAddress);
        }
        
        public System.Threading.Tasks.Task<long> RemoveListMemberAsync(string PostOffice, string ListName, string ListMemberAddress) {
            return base.Channel.RemoveListMemberAsync(PostOffice, ListName, ListMemberAddress);
        }
        
        public long EditListMember(string PostOffice, string ListName, string ListMemberAddress, string NewListMemberAddress, string NewPostoffice, string NewListName) {
            return base.Channel.EditListMember(PostOffice, ListName, ListMemberAddress, NewListMemberAddress, NewPostoffice, NewListName);
        }
        
        public System.Threading.Tasks.Task<long> EditListMemberAsync(string PostOffice, string ListName, string ListMemberAddress, string NewListMemberAddress, string NewPostoffice, string NewListName) {
            return base.Channel.EditListMemberAsync(PostOffice, ListName, ListMemberAddress, NewListMemberAddress, NewPostoffice, NewListName);
        }
    }
}