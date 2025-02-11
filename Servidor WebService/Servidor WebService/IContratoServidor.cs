using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Servidor_WebService
{
    [ServiceContract]
    internal interface IContratoServidor
    {
        [OperationContract]
        bool EnviaStringProServidor(string pMensagemEnviada);
        [OperationContract]
        string PegaStringDoServidor();
    }
}
