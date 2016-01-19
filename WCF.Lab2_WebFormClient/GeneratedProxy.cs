﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="WCF_Service", ConfigurationName="IBMI")]
public interface IBMI
{
    
    [System.ServiceModel.OperationContractAttribute(Action="WCF_Service/IBMI/BMI", ReplyAction="WCF_Service/IBMI/BMIResponse")]
    decimal BMI(decimal height, decimal weight);
    
    [System.ServiceModel.OperationContractAttribute(Action="WCF_Service/IBMI/BMI", ReplyAction="WCF_Service/IBMI/BMIResponse")]
    System.Threading.Tasks.Task<decimal> BMIAsync(decimal height, decimal weight);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IBMIChannel : IBMI, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class BMIClient : System.ServiceModel.ClientBase<IBMI>, IBMI
{
    
    public BMIClient()
    {
    }
    
    public BMIClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BMIClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BMIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BMIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public decimal BMI(decimal height, decimal weight)
    {
        return base.Channel.BMI(height, weight);
    }
    
    public System.Threading.Tasks.Task<decimal> BMIAsync(decimal height, decimal weight)
    {
        return base.Channel.BMIAsync(height, weight);
    }
}