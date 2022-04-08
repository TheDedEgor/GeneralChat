﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ChatService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/ServiceChat")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ChatService.User SenderField;
        
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
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ChatService.User Sender {
            get {
                return this.SenderField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderField, value) != true)) {
                    this.SenderField = value;
                    this.RaisePropertyChanged("Sender");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ServiceChat")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ChatService.Message[] AddMessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OnlineField;
        
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
        public Client.ChatService.Message[] AddMessages {
            get {
                return this.AddMessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.AddMessagesField, value) != true)) {
                    this.AddMessagesField = value;
                    this.RaisePropertyChanged("AddMessages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Online {
            get {
                return this.OnlineField;
            }
            set {
                if ((this.OnlineField.Equals(value) != true)) {
                    this.OnlineField = value;
                    this.RaisePropertyChanged("Online");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatService.IChat")]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/UserRegistration", ReplyAction="http://tempuri.org/IChat/UserRegistrationResponse")]
        bool UserRegistration(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/UserRegistration", ReplyAction="http://tempuri.org/IChat/UserRegistrationResponse")]
        System.Threading.Tasks.Task<bool> UserRegistrationAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/UserAuthorization", ReplyAction="http://tempuri.org/IChat/UserAuthorizationResponse")]
        bool UserAuthorization(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/UserAuthorization", ReplyAction="http://tempuri.org/IChat/UserAuthorizationResponse")]
        System.Threading.Tasks.Task<bool> UserAuthorizationAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetAllMessages", ReplyAction="http://tempuri.org/IChat/GetAllMessagesResponse")]
        Client.ChatService.Message[] GetAllMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetAllMessages", ReplyAction="http://tempuri.org/IChat/GetAllMessagesResponse")]
        System.Threading.Tasks.Task<Client.ChatService.Message[]> GetAllMessagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetUser", ReplyAction="http://tempuri.org/IChat/GetUserResponse")]
        Client.ChatService.User GetUser(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetUser", ReplyAction="http://tempuri.org/IChat/GetUserResponse")]
        System.Threading.Tasks.Task<Client.ChatService.User> GetUserAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SendMessage", ReplyAction="http://tempuri.org/IChat/SendMessageResponse")]
        void SendMessage(string name, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SendMessage", ReplyAction="http://tempuri.org/IChat/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(string name, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetAddMessages", ReplyAction="http://tempuri.org/IChat/GetAddMessagesResponse")]
        Client.ChatService.Message[] GetAddMessages(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetAddMessages", ReplyAction="http://tempuri.org/IChat/GetAddMessagesResponse")]
        System.Threading.Tasks.Task<Client.ChatService.Message[]> GetAddMessagesAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ClearAddMessages", ReplyAction="http://tempuri.org/IChat/ClearAddMessagesResponse")]
        void ClearAddMessages(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ClearAddMessages", ReplyAction="http://tempuri.org/IChat/ClearAddMessagesResponse")]
        System.Threading.Tasks.Task ClearAddMessagesAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ChangeOnlineStatusUser", ReplyAction="http://tempuri.org/IChat/ChangeOnlineStatusUserResponse")]
        void ChangeOnlineStatusUser(string name, bool status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ChangeOnlineStatusUser", ReplyAction="http://tempuri.org/IChat/ChangeOnlineStatusUserResponse")]
        System.Threading.Tasks.Task ChangeOnlineStatusUserAsync(string name, bool status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : Client.ChatService.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.ClientBase<Client.ChatService.IChat>, Client.ChatService.IChat {
        
        public ChatClient() {
        }
        
        public ChatClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChatClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool UserRegistration(string name) {
            return base.Channel.UserRegistration(name);
        }
        
        public System.Threading.Tasks.Task<bool> UserRegistrationAsync(string name) {
            return base.Channel.UserRegistrationAsync(name);
        }
        
        public bool UserAuthorization(string name) {
            return base.Channel.UserAuthorization(name);
        }
        
        public System.Threading.Tasks.Task<bool> UserAuthorizationAsync(string name) {
            return base.Channel.UserAuthorizationAsync(name);
        }
        
        public Client.ChatService.Message[] GetAllMessages() {
            return base.Channel.GetAllMessages();
        }
        
        public System.Threading.Tasks.Task<Client.ChatService.Message[]> GetAllMessagesAsync() {
            return base.Channel.GetAllMessagesAsync();
        }
        
        public Client.ChatService.User GetUser(string name) {
            return base.Channel.GetUser(name);
        }
        
        public System.Threading.Tasks.Task<Client.ChatService.User> GetUserAsync(string name) {
            return base.Channel.GetUserAsync(name);
        }
        
        public void SendMessage(string name, string message) {
            base.Channel.SendMessage(name, message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string name, string message) {
            return base.Channel.SendMessageAsync(name, message);
        }
        
        public Client.ChatService.Message[] GetAddMessages(string name) {
            return base.Channel.GetAddMessages(name);
        }
        
        public System.Threading.Tasks.Task<Client.ChatService.Message[]> GetAddMessagesAsync(string name) {
            return base.Channel.GetAddMessagesAsync(name);
        }
        
        public void ClearAddMessages(string name) {
            base.Channel.ClearAddMessages(name);
        }
        
        public System.Threading.Tasks.Task ClearAddMessagesAsync(string name) {
            return base.Channel.ClearAddMessagesAsync(name);
        }
        
        public void ChangeOnlineStatusUser(string name, bool status) {
            base.Channel.ChangeOnlineStatusUser(name, status);
        }
        
        public System.Threading.Tasks.Task ChangeOnlineStatusUserAsync(string name, bool status) {
            return base.Channel.ChangeOnlineStatusUserAsync(name, status);
        }
    }
}
