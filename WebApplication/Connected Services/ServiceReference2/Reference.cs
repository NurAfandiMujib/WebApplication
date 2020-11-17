﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        double add(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        System.Threading.Tasks.Task<double> addAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sub", ReplyAction="http://tempuri.org/IService1/subResponse")]
        double sub(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sub", ReplyAction="http://tempuri.org/IService1/subResponse")]
        System.Threading.Tasks.Task<double> subAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/multiple", ReplyAction="http://tempuri.org/IService1/multipleResponse")]
        double multiple(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/multiple", ReplyAction="http://tempuri.org/IService1/multipleResponse")]
        System.Threading.Tasks.Task<double> multipleAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/divide", ReplyAction="http://tempuri.org/IService1/divideResponse")]
        double divide(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/divide", ReplyAction="http://tempuri.org/IService1/divideResponse")]
        System.Threading.Tasks.Task<double> divideAsync(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication.ServiceReference2.IService1>, WebApplication.ServiceReference2.IService1 {
        
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
        
        public double add(double num1, double num2) {
            return base.Channel.add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> addAsync(double num1, double num2) {
            return base.Channel.addAsync(num1, num2);
        }
        
        public double sub(double num1, double num2) {
            return base.Channel.sub(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> subAsync(double num1, double num2) {
            return base.Channel.subAsync(num1, num2);
        }
        
        public double multiple(double num1, double num2) {
            return base.Channel.multiple(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> multipleAsync(double num1, double num2) {
            return base.Channel.multipleAsync(num1, num2);
        }
        
        public double divide(double num1, double num2) {
            return base.Channel.divide(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> divideAsync(double num1, double num2) {
            return base.Channel.divideAsync(num1, num2);
        }
    }
}
