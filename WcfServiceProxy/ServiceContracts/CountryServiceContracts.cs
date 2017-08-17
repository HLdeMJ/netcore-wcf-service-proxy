﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfProxy.CountryServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryDto", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.DTO")]
    [System.SerializableAttribute()]
    public partial class CountryDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CountryServiceReference.ICountryService")]
    public interface ICountryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/GetCountries", ReplyAction="http://tempuri.org/ICountryService/GetCountriesResponse")]
        WcfProxy.CountryServiceReference.GetCountriesResponse GetCountries(WcfProxy.CountryServiceReference.GetCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/GetCountries", ReplyAction="http://tempuri.org/ICountryService/GetCountriesResponse")]
        System.Threading.Tasks.Task<WcfProxy.CountryServiceReference.GetCountriesResponse> GetCountriesAsync(WcfProxy.CountryServiceReference.GetCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/SaveCountry", ReplyAction="http://tempuri.org/ICountryService/SaveCountryResponse")]
        WcfProxy.CountryServiceReference.SaveCountryResponse SaveCountry(WcfProxy.CountryServiceReference.SaveCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/SaveCountry", ReplyAction="http://tempuri.org/ICountryService/SaveCountryResponse")]
        System.Threading.Tasks.Task<WcfProxy.CountryServiceReference.SaveCountryResponse> SaveCountryAsync(WcfProxy.CountryServiceReference.SaveCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Clear", ReplyAction="http://tempuri.org/ICountryService/ClearResponse")]
        WcfProxy.CountryServiceReference.ClearResponse Clear(WcfProxy.CountryServiceReference.ClearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Clear", ReplyAction="http://tempuri.org/ICountryService/ClearResponse")]
        System.Threading.Tasks.Task<WcfProxy.CountryServiceReference.ClearResponse> ClearAsync(WcfProxy.CountryServiceReference.ClearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCountries", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCountriesRequest {
        
        public GetCountriesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCountriesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCountriesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WcfProxy.CountryServiceReference.CountryDto[] GetCountriesResult;
        
        public GetCountriesResponse() {
        }
        
        public GetCountriesResponse(WcfProxy.CountryServiceReference.CountryDto[] GetCountriesResult) {
            this.GetCountriesResult = GetCountriesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveCountry", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveCountryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WcfProxy.CountryServiceReference.CountryDto country;
        
        public SaveCountryRequest() {
        }
        
        public SaveCountryRequest(WcfProxy.CountryServiceReference.CountryDto country) {
            this.country = country;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveCountryResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveCountryResponse {
        
        public SaveCountryResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Clear", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ClearRequest {
        
        public ClearRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ClearResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ClearResponse {
        
        public ClearResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICountryServiceChannel : WcfProxy.CountryServiceReference.ICountryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CountryServiceClient : System.ServiceModel.ClientBase<WcfProxy.CountryServiceReference.ICountryService>, WcfProxy.CountryServiceReference.ICountryService {
        
        public CountryServiceClient() {
        }
        
        public CountryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CountryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CountryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CountryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfProxy.CountryServiceReference.GetCountriesResponse GetCountries(WcfProxy.CountryServiceReference.GetCountriesRequest request) {
            return base.Channel.GetCountries(request);
        }
        
        public System.Threading.Tasks.Task<WcfProxy.CountryServiceReference.GetCountriesResponse> GetCountriesAsync(WcfProxy.CountryServiceReference.GetCountriesRequest request) {
            return base.Channel.GetCountriesAsync(request);
        }
        
        public WcfProxy.CountryServiceReference.SaveCountryResponse SaveCountry(WcfProxy.CountryServiceReference.SaveCountryRequest request) {
            return base.Channel.SaveCountry(request);
        }
        
        public System.Threading.Tasks.Task<WcfProxy.CountryServiceReference.SaveCountryResponse> SaveCountryAsync(WcfProxy.CountryServiceReference.SaveCountryRequest request) {
            return base.Channel.SaveCountryAsync(request);
        }
        
        public WcfProxy.CountryServiceReference.ClearResponse Clear(WcfProxy.CountryServiceReference.ClearRequest request) {
            return base.Channel.Clear(request);
        }
        
        public System.Threading.Tasks.Task<WcfProxy.CountryServiceReference.ClearResponse> ClearAsync(WcfProxy.CountryServiceReference.ClearRequest request) {
            return base.Channel.ClearAsync(request);
        }
    }
}
