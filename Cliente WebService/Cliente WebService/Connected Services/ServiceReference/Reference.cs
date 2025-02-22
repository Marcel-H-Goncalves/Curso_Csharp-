﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IContratoServidor")]
    public interface IContratoServidor
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoServidor/EnviaStringProServidor", ReplyAction="http://tempuri.org/IContratoServidor/EnviaStringProServidorResponse")]
        bool EnviaStringProServidor(string pMensagemEnviada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoServidor/EnviaStringProServidor", ReplyAction="http://tempuri.org/IContratoServidor/EnviaStringProServidorResponse")]
        System.Threading.Tasks.Task<bool> EnviaStringProServidorAsync(string pMensagemEnviada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoServidor/PegaStringDoServidor", ReplyAction="http://tempuri.org/IContratoServidor/PegaStringDoServidorResponse")]
        string PegaStringDoServidor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoServidor/PegaStringDoServidor", ReplyAction="http://tempuri.org/IContratoServidor/PegaStringDoServidorResponse")]
        System.Threading.Tasks.Task<string> PegaStringDoServidorAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IContratoServidorChannel : ServiceReference.IContratoServidor, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ContratoServidorClient : System.ServiceModel.ClientBase<ServiceReference.IContratoServidor>, ServiceReference.IContratoServidor
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ContratoServidorClient() : 
                base(ContratoServidorClient.GetDefaultBinding(), ContratoServidorClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IContratoServidor.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContratoServidorClient(EndpointConfiguration endpointConfiguration) : 
                base(ContratoServidorClient.GetBindingForEndpoint(endpointConfiguration), ContratoServidorClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContratoServidorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ContratoServidorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContratoServidorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ContratoServidorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ContratoServidorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool EnviaStringProServidor(string pMensagemEnviada)
        {
            return base.Channel.EnviaStringProServidor(pMensagemEnviada);
        }
        
        public System.Threading.Tasks.Task<bool> EnviaStringProServidorAsync(string pMensagemEnviada)
        {
            return base.Channel.EnviaStringProServidorAsync(pMensagemEnviada);
        }
        
        public string PegaStringDoServidor()
        {
            return base.Channel.PegaStringDoServidor();
        }
        
        public System.Threading.Tasks.Task<string> PegaStringDoServidorAsync()
        {
            return base.Channel.PegaStringDoServidorAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IContratoServidor))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IContratoServidor))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.1.219/MeuServidorLocal");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ContratoServidorClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IContratoServidor);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ContratoServidorClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IContratoServidor);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IContratoServidor,
        }
    }
}
