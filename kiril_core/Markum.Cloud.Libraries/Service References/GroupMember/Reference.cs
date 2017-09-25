﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Markum.Cloud.Libraries.GroupMember {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", ConfigurationName="GroupMember.GroupMemberSoap")]
    public interface GroupMemberSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/AddGroupMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        long AddGroupMember(string PostOffice, string Group, string MemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/AddGroupMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> AddGroupMemberAsync(string PostOffice, string Group, string MemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/GetGroupMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        long GetGroupMember(string PostOffice, string Group, string MemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/GetGroupMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> GetGroupMemberAsync(string PostOffice, string Group, string MemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/GetGroupMemberObjectPropertie" +
            "s", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesResponse GetGroupMemberObjectProperties(Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/GetGroupMemberObjectPropertie" +
            "s", ReplyAction="*")]
        System.Threading.Tasks.Task<Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesResponse> GetGroupMemberObjectPropertiesAsync(Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/ListGroupMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        Markum.Cloud.Libraries.GroupMember.ListGroupMemberResponse ListGroupMember(Markum.Cloud.Libraries.GroupMember.ListGroupMemberRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/ListGroupMember", ReplyAction="*")]
        System.Threading.Tasks.Task<Markum.Cloud.Libraries.GroupMember.ListGroupMemberResponse> ListGroupMemberAsync(Markum.Cloud.Libraries.GroupMember.ListGroupMemberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/RemoveGroupMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        long RemoveGroupMember(string PostOffice, string Group, string MemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/RemoveGroupMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> RemoveGroupMemberAsync(string PostOffice, string Group, string MemberAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/EditGroupMember", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        long EditGroupMember(string PostOffice, string Group, string MemberAddress, string NewMemberAddress, string NewPostoffice, string NewGroup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://mailenable.com/MEWebAdminService/GroupMember/EditGroupMember", ReplyAction="*")]
        System.Threading.Tasks.Task<long> EditGroupMemberAsync(string PostOffice, string Group, string MemberAddress, string NewMemberAddress, string NewPostoffice, string NewGroup);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember")]
    public partial class GroupMember : MarshalByRefObject {
        
        private string addressField;
        
        private string postofficeField;
        
        private string mailboxField;
        
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
        public string Postoffice {
            get {
                return this.postofficeField;
            }
            set {
                this.postofficeField = value;
                this.RaisePropertyChanged("Postoffice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Mailbox {
            get {
                return this.mailboxField;
            }
            set {
                this.mailboxField = value;
                this.RaisePropertyChanged("Mailbox");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupMember))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember")]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGroupMemberObjectProperties", WrapperNamespace="http://mailenable.com/MEWebAdminService/GroupMember", IsWrapped=true)]
    public partial class GetGroupMemberObjectPropertiesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=0)]
        public string PostOffice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=1)]
        public string Group;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=2)]
        public string MemberAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=3)]
        public Markum.Cloud.Libraries.GroupMember.GroupMember ObjectProperties;
        
        public GetGroupMemberObjectPropertiesRequest() {
        }
        
        public GetGroupMemberObjectPropertiesRequest(string PostOffice, string Group, string MemberAddress, Markum.Cloud.Libraries.GroupMember.GroupMember ObjectProperties) {
            this.PostOffice = PostOffice;
            this.Group = Group;
            this.MemberAddress = MemberAddress;
            this.ObjectProperties = ObjectProperties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGroupMemberObjectPropertiesResponse", WrapperNamespace="http://mailenable.com/MEWebAdminService/GroupMember", IsWrapped=true)]
    public partial class GetGroupMemberObjectPropertiesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=0)]
        public long GetGroupMemberObjectPropertiesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=1)]
        public Markum.Cloud.Libraries.GroupMember.GroupMember ObjectProperties;
        
        public GetGroupMemberObjectPropertiesResponse() {
        }
        
        public GetGroupMemberObjectPropertiesResponse(long GetGroupMemberObjectPropertiesResult, Markum.Cloud.Libraries.GroupMember.GroupMember ObjectProperties) {
            this.GetGroupMemberObjectPropertiesResult = GetGroupMemberObjectPropertiesResult;
            this.ObjectProperties = ObjectProperties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListGroupMember", WrapperNamespace="http://mailenable.com/MEWebAdminService/GroupMember", IsWrapped=true)]
    public partial class ListGroupMemberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=0)]
        public Markum.Cloud.Libraries.GroupMember.GroupMember[] ObjectList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=1)]
        public string PostOffice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=2)]
        public string Group;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=3)]
        public string MemberAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=4)]
        public long Top;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=5)]
        public long MaxLength;
        
        public ListGroupMemberRequest() {
        }
        
        public ListGroupMemberRequest(Markum.Cloud.Libraries.GroupMember.GroupMember[] ObjectList, string PostOffice, string Group, string MemberAddress, long Top, long MaxLength) {
            this.ObjectList = ObjectList;
            this.PostOffice = PostOffice;
            this.Group = Group;
            this.MemberAddress = MemberAddress;
            this.Top = Top;
            this.MaxLength = MaxLength;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListGroupMemberResponse", WrapperNamespace="http://mailenable.com/MEWebAdminService/GroupMember", IsWrapped=true)]
    public partial class ListGroupMemberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=0)]
        public long ListGroupMemberResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mailenable.com/MEWebAdminService/GroupMember", Order=1)]
        public Markum.Cloud.Libraries.GroupMember.GroupMember[] ObjectList;
        
        public ListGroupMemberResponse() {
        }
        
        public ListGroupMemberResponse(long ListGroupMemberResult, Markum.Cloud.Libraries.GroupMember.GroupMember[] ObjectList) {
            this.ListGroupMemberResult = ListGroupMemberResult;
            this.ObjectList = ObjectList;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GroupMemberSoapChannel : Markum.Cloud.Libraries.GroupMember.GroupMemberSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupMemberSoapClient : System.ServiceModel.ClientBase<Markum.Cloud.Libraries.GroupMember.GroupMemberSoap>, Markum.Cloud.Libraries.GroupMember.GroupMemberSoap {
        
        public GroupMemberSoapClient() {
        }
        
        public GroupMemberSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupMemberSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupMemberSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupMemberSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long AddGroupMember(string PostOffice, string Group, string MemberAddress) {
            return base.Channel.AddGroupMember(PostOffice, Group, MemberAddress);
        }
        
        public System.Threading.Tasks.Task<long> AddGroupMemberAsync(string PostOffice, string Group, string MemberAddress) {
            return base.Channel.AddGroupMemberAsync(PostOffice, Group, MemberAddress);
        }
        
        public long GetGroupMember(string PostOffice, string Group, string MemberAddress) {
            return base.Channel.GetGroupMember(PostOffice, Group, MemberAddress);
        }
        
        public System.Threading.Tasks.Task<long> GetGroupMemberAsync(string PostOffice, string Group, string MemberAddress) {
            return base.Channel.GetGroupMemberAsync(PostOffice, Group, MemberAddress);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesResponse Markum.Cloud.Libraries.GroupMember.GroupMemberSoap.GetGroupMemberObjectProperties(Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesRequest request) {
            return base.Channel.GetGroupMemberObjectProperties(request);
        }
        
        public long GetGroupMemberObjectProperties(string PostOffice, string Group, string MemberAddress, ref Markum.Cloud.Libraries.GroupMember.GroupMember ObjectProperties) {
            Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesRequest inValue = new Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesRequest();
            inValue.PostOffice = PostOffice;
            inValue.Group = Group;
            inValue.MemberAddress = MemberAddress;
            inValue.ObjectProperties = ObjectProperties;
            Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesResponse retVal = ((Markum.Cloud.Libraries.GroupMember.GroupMemberSoap)(this)).GetGroupMemberObjectProperties(inValue);
            ObjectProperties = retVal.ObjectProperties;
            return retVal.GetGroupMemberObjectPropertiesResult;
        }
        
        public System.Threading.Tasks.Task<Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesResponse> GetGroupMemberObjectPropertiesAsync(Markum.Cloud.Libraries.GroupMember.GetGroupMemberObjectPropertiesRequest request) {
            return base.Channel.GetGroupMemberObjectPropertiesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Markum.Cloud.Libraries.GroupMember.ListGroupMemberResponse Markum.Cloud.Libraries.GroupMember.GroupMemberSoap.ListGroupMember(Markum.Cloud.Libraries.GroupMember.ListGroupMemberRequest request) {
            return base.Channel.ListGroupMember(request);
        }
        
        public long ListGroupMember(ref Markum.Cloud.Libraries.GroupMember.GroupMember[] ObjectList, string PostOffice, string Group, string MemberAddress, long Top, long MaxLength) {
            Markum.Cloud.Libraries.GroupMember.ListGroupMemberRequest inValue = new Markum.Cloud.Libraries.GroupMember.ListGroupMemberRequest();
            inValue.ObjectList = ObjectList;
            inValue.PostOffice = PostOffice;
            inValue.Group = Group;
            inValue.MemberAddress = MemberAddress;
            inValue.Top = Top;
            inValue.MaxLength = MaxLength;
            Markum.Cloud.Libraries.GroupMember.ListGroupMemberResponse retVal = ((Markum.Cloud.Libraries.GroupMember.GroupMemberSoap)(this)).ListGroupMember(inValue);
            ObjectList = retVal.ObjectList;
            return retVal.ListGroupMemberResult;
        }
        
        public System.Threading.Tasks.Task<Markum.Cloud.Libraries.GroupMember.ListGroupMemberResponse> ListGroupMemberAsync(Markum.Cloud.Libraries.GroupMember.ListGroupMemberRequest request) {
            return base.Channel.ListGroupMemberAsync(request);
        }
        
        public long RemoveGroupMember(string PostOffice, string Group, string MemberAddress) {
            return base.Channel.RemoveGroupMember(PostOffice, Group, MemberAddress);
        }
        
        public System.Threading.Tasks.Task<long> RemoveGroupMemberAsync(string PostOffice, string Group, string MemberAddress) {
            return base.Channel.RemoveGroupMemberAsync(PostOffice, Group, MemberAddress);
        }
        
        public long EditGroupMember(string PostOffice, string Group, string MemberAddress, string NewMemberAddress, string NewPostoffice, string NewGroup) {
            return base.Channel.EditGroupMember(PostOffice, Group, MemberAddress, NewMemberAddress, NewPostoffice, NewGroup);
        }
        
        public System.Threading.Tasks.Task<long> EditGroupMemberAsync(string PostOffice, string Group, string MemberAddress, string NewMemberAddress, string NewPostoffice, string NewGroup) {
            return base.Channel.EditGroupMemberAsync(PostOffice, Group, MemberAddress, NewMemberAddress, NewPostoffice, NewGroup);
        }
    }
}
