﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace xphu.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDetail", Namespace="http://schemas.datacontract.org/2004/07/xphu")]
    [System.SerializableAttribute()]
    public partial class UserDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idaccField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool roleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idacc {
            get {
                return this.idaccField;
            }
            set {
                if ((object.ReferenceEquals(this.idaccField, value) != true)) {
                    this.idaccField = value;
                    this.RaisePropertyChanged("idacc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string pass {
            get {
                return this.passField;
            }
            set {
                if ((object.ReferenceEquals(this.passField, value) != true)) {
                    this.passField = value;
                    this.RaisePropertyChanged("pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool role {
            get {
                return this.roleField;
            }
            set {
                if ((this.roleField.Equals(value) != true)) {
                    this.roleField = value;
                    this.RaisePropertyChanged("role");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Option", Namespace="http://schemas.datacontract.org/2004/07/xphu")]
    [System.SerializableAttribute()]
    public partial class Option : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime deadlinetimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idoptField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contents {
            get {
                return this.contentsField;
            }
            set {
                if ((object.ReferenceEquals(this.contentsField, value) != true)) {
                    this.contentsField = value;
                    this.RaisePropertyChanged("contents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime deadlinetime {
            get {
                return this.deadlinetimeField;
            }
            set {
                if ((this.deadlinetimeField.Equals(value) != true)) {
                    this.deadlinetimeField = value;
                    this.RaisePropertyChanged("deadlinetime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idopt {
            get {
                return this.idoptField;
            }
            set {
                if ((object.ReferenceEquals(this.idoptField, value) != true)) {
                    this.idoptField = value;
                    this.RaisePropertyChanged("idopt");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vote", Namespace="http://schemas.datacontract.org/2004/07/xphu")]
    [System.SerializableAttribute()]
    public partial class Vote : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idaccField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idoptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idvoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime timeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idacc {
            get {
                return this.idaccField;
            }
            set {
                if ((object.ReferenceEquals(this.idaccField, value) != true)) {
                    this.idaccField = value;
                    this.RaisePropertyChanged("idacc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idopt {
            get {
                return this.idoptField;
            }
            set {
                if ((object.ReferenceEquals(this.idoptField, value) != true)) {
                    this.idoptField = value;
                    this.RaisePropertyChanged("idopt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idvote {
            get {
                return this.idvoteField;
            }
            set {
                if ((object.ReferenceEquals(this.idvoteField, value) != true)) {
                    this.idvoteField = value;
                    this.RaisePropertyChanged("idvote");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime time {
            get {
                return this.timeField;
            }
            set {
                if ((this.timeField.Equals(value) != true)) {
                    this.timeField = value;
                    this.RaisePropertyChanged("time");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DsAcount", ReplyAction="http://tempuri.org/IService1/DsAcountResponse")]
        System.Data.DataSet DsAcount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DsAcount", ReplyAction="http://tempuri.org/IService1/DsAcountResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> DsAcountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DangNhap", ReplyAction="http://tempuri.org/IService1/DangNhapResponse")]
        bool DangNhap(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DangNhap", ReplyAction="http://tempuri.org/IService1/DangNhapResponse")]
        System.Threading.Tasks.Task<bool> DangNhapAsync(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Account", ReplyAction="http://tempuri.org/IService1/AccountResponse")]
        bool Account(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Account", ReplyAction="http://tempuri.org/IService1/AccountResponse")]
        System.Threading.Tasks.Task<bool> AccountAsync(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Them", ReplyAction="http://tempuri.org/IService1/ThemResponse")]
        bool Them(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Them", ReplyAction="http://tempuri.org/IService1/ThemResponse")]
        System.Threading.Tasks.Task<bool> ThemAsync(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sua", ReplyAction="http://tempuri.org/IService1/SuaResponse")]
        bool Sua(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sua", ReplyAction="http://tempuri.org/IService1/SuaResponse")]
        System.Threading.Tasks.Task<bool> SuaAsync(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Xoa", ReplyAction="http://tempuri.org/IService1/XoaResponse")]
        bool Xoa(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Xoa", ReplyAction="http://tempuri.org/IService1/XoaResponse")]
        System.Threading.Tasks.Task<bool> XoaAsync(xphu.ServiceReference1.UserDetail userinfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IThemOption", ReplyAction="http://tempuri.org/IService1/IThemOptionResponse")]
        bool IThemOption(string idopt, string contents, string code, System.DateTime dealinetime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IThemOption", ReplyAction="http://tempuri.org/IService1/IThemOptionResponse")]
        System.Threading.Tasks.Task<bool> IThemOptionAsync(string idopt, string contents, string code, System.DateTime dealinetime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/XoaOption", ReplyAction="http://tempuri.org/IService1/XoaOptionResponse")]
        bool XoaOption(xphu.ServiceReference1.Option xoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/XoaOption", ReplyAction="http://tempuri.org/IService1/XoaOptionResponse")]
        System.Threading.Tasks.Task<bool> XoaOptionAsync(xphu.ServiceReference1.Option xoa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadContent", ReplyAction="http://tempuri.org/IService1/LoadContentResponse")]
        bool LoadContent(xphu.ServiceReference1.Vote vote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadContent", ReplyAction="http://tempuri.org/IService1/LoadContentResponse")]
        System.Threading.Tasks.Task<bool> LoadContentAsync(xphu.ServiceReference1.Vote vote);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : xphu.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<xphu.ServiceReference1.IService1>, xphu.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet DsAcount() {
            return base.Channel.DsAcount();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> DsAcountAsync() {
            return base.Channel.DsAcountAsync();
        }
        
        public bool DangNhap(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.DangNhap(userinfo);
        }
        
        public System.Threading.Tasks.Task<bool> DangNhapAsync(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.DangNhapAsync(userinfo);
        }
        
        public bool Account(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.Account(userinfo);
        }
        
        public System.Threading.Tasks.Task<bool> AccountAsync(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.AccountAsync(userinfo);
        }
        
        public bool Them(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.Them(userinfo);
        }
        
        public System.Threading.Tasks.Task<bool> ThemAsync(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.ThemAsync(userinfo);
        }
        
        public bool Sua(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.Sua(userinfo);
        }
        
        public System.Threading.Tasks.Task<bool> SuaAsync(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.SuaAsync(userinfo);
        }
        
        public bool Xoa(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.Xoa(userinfo);
        }
        
        public System.Threading.Tasks.Task<bool> XoaAsync(xphu.ServiceReference1.UserDetail userinfo) {
            return base.Channel.XoaAsync(userinfo);
        }
        
        public bool IThemOption(string idopt, string contents, string code, System.DateTime dealinetime) {
            return base.Channel.IThemOption(idopt, contents, code, dealinetime);
        }
        
        public System.Threading.Tasks.Task<bool> IThemOptionAsync(string idopt, string contents, string code, System.DateTime dealinetime) {
            return base.Channel.IThemOptionAsync(idopt, contents, code, dealinetime);
        }
        
        public bool XoaOption(xphu.ServiceReference1.Option xoa) {
            return base.Channel.XoaOption(xoa);
        }
        
        public System.Threading.Tasks.Task<bool> XoaOptionAsync(xphu.ServiceReference1.Option xoa) {
            return base.Channel.XoaOptionAsync(xoa);
        }
        
        public bool LoadContent(xphu.ServiceReference1.Vote vote) {
            return base.Channel.LoadContent(vote);
        }
        
        public System.Threading.Tasks.Task<bool> LoadContentAsync(xphu.ServiceReference1.Vote vote) {
            return base.Channel.LoadContentAsync(vote);
        }
    }
}
