﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WnfrmJsn.Transl {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Transl.ITransl")]
    public interface ITransl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransl/ReadJson", ReplyAction="http://tempuri.org/ITransl/ReadJsonResponse")]
        string ReadJson(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITransl/ReadJson", ReplyAction="http://tempuri.org/ITransl/ReadJsonResponse")]
        System.Threading.Tasks.Task<string> ReadJsonAsync(string city);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITranslChannel : WnfrmJsn.Transl.ITransl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TranslClient : System.ServiceModel.ClientBase<WnfrmJsn.Transl.ITransl>, WnfrmJsn.Transl.ITransl {
        
        public TranslClient() {
        }
        
        public TranslClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TranslClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TranslClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TranslClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ReadJson(string city) {
            return base.Channel.ReadJson(city);
        }
        
        public System.Threading.Tasks.Task<string> ReadJsonAsync(string city) {
            return base.Channel.ReadJsonAsync(city);
        }
    }
}