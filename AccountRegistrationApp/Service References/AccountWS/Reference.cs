﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountRegistrationApp.AccountWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountInfo", Namespace="http://schemas.datacontract.org/2004/07/AccountWcf")]
    [System.SerializableAttribute()]
    public partial class AccountInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string useridField;
        
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
        public string firstname {
            get {
                return this.firstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstnameField, value) != true)) {
                    this.firstnameField = value;
                    this.RaisePropertyChanged("firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastnameField, value) != true)) {
                    this.lastnameField = value;
                    this.RaisePropertyChanged("lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userid {
            get {
                return this.useridField;
            }
            set {
                if ((object.ReferenceEquals(this.useridField, value) != true)) {
                    this.useridField = value;
                    this.RaisePropertyChanged("userid");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountServiceFault", Namespace="http://schemas.datacontract.org/2004/07/AccountWcf")]
    [System.SerializableAttribute()]
    public partial class AccountServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountWS.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CreateAccount", ReplyAction="http://tempuri.org/IAccountService/CreateAccountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AccountRegistrationApp.AccountWS.AccountServiceFault), Action="http://tempuri.org/IAccountService/CreateAccountAccountServiceFaultFault", Name="AccountServiceFault", Namespace="http://schemas.datacontract.org/2004/07/AccountWcf")]
        bool CreateAccount(AccountRegistrationApp.AccountWS.AccountInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CreateAccount", ReplyAction="http://tempuri.org/IAccountService/CreateAccountResponse")]
        System.Threading.Tasks.Task<bool> CreateAccountAsync(AccountRegistrationApp.AccountWS.AccountInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Authenticate", ReplyAction="http://tempuri.org/IAccountService/AuthenticateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AccountRegistrationApp.AccountWS.AccountServiceFault), Action="http://tempuri.org/IAccountService/AuthenticateAccountServiceFaultFault", Name="AccountServiceFault", Namespace="http://schemas.datacontract.org/2004/07/AccountWcf")]
        bool Authenticate(AccountRegistrationApp.AccountWS.AccountInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Authenticate", ReplyAction="http://tempuri.org/IAccountService/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(AccountRegistrationApp.AccountWS.AccountInfo info);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : AccountRegistrationApp.AccountWS.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<AccountRegistrationApp.AccountWS.IAccountService>, AccountRegistrationApp.AccountWS.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateAccount(AccountRegistrationApp.AccountWS.AccountInfo info) {
            return base.Channel.CreateAccount(info);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAccountAsync(AccountRegistrationApp.AccountWS.AccountInfo info) {
            return base.Channel.CreateAccountAsync(info);
        }
        
        public bool Authenticate(AccountRegistrationApp.AccountWS.AccountInfo info) {
            return base.Channel.Authenticate(info);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(AccountRegistrationApp.AccountWS.AccountInfo info) {
            return base.Channel.AuthenticateAsync(info);
        }
    }
}
