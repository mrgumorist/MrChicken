﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mr.ChickenBot.ServiceReferenceMrChickenBot {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMrChickenBot.IProgrammService")]
    public interface IProgrammService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/Msg", ReplyAction="http://tempuri.org/IProgrammService/MsgResponse")]
        string Msg([System.ServiceModel.MessageParameterAttribute(Name="msg")] string msg1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/Msg", ReplyAction="http://tempuri.org/IProgrammService/MsgResponse")]
        System.Threading.Tasks.Task<string> MsgAsync(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProgrammServiceChannel : Mr.ChickenBot.ServiceReferenceMrChickenBot.IProgrammService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProgrammServiceClient : System.ServiceModel.ClientBase<Mr.ChickenBot.ServiceReferenceMrChickenBot.IProgrammService>, Mr.ChickenBot.ServiceReferenceMrChickenBot.IProgrammService {
        
        public ProgrammServiceClient() {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgrammServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Msg(string msg1) {
            return base.Channel.Msg(msg1);
        }
        
        public System.Threading.Tasks.Task<string> MsgAsync(string msg) {
            return base.Channel.MsgAsync(msg);
        }
    }
}