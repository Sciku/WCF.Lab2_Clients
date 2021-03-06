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
[System.ServiceModel.ServiceContractAttribute(Namespace="WCF_Service_ThousandDays", ConfigurationName="IThousandDays")]
public interface IThousandDays
{
    
    [System.ServiceModel.OperationContractAttribute(Action="WCF_Service_ThousandDays/IThousandDays/days", ReplyAction="WCF_Service_ThousandDays/IThousandDays/daysResponse")]
    double days(int year, int month, int day);
    
    [System.ServiceModel.OperationContractAttribute(Action="WCF_Service_ThousandDays/IThousandDays/days", ReplyAction="WCF_Service_ThousandDays/IThousandDays/daysResponse")]
    System.Threading.Tasks.Task<double> daysAsync(int year, int month, int day);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IThousandDaysChannel : IThousandDays, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ThousandDaysClient : System.ServiceModel.ClientBase<IThousandDays>, IThousandDays
{
    
    public ThousandDaysClient()
    {
    }
    
    public ThousandDaysClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ThousandDaysClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ThousandDaysClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ThousandDaysClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double days(int year, int month, int day)
    {
        return base.Channel.days(year, month, day);
    }
    
    public System.Threading.Tasks.Task<double> daysAsync(int year, int month, int day)
    {
        return base.Channel.daysAsync(year, month, day);
    }
}
