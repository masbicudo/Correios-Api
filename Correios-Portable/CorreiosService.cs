using Correios.CorreiosServiceReference;
using System.ServiceModel;

namespace Correios
{
    public class CorreiosApi : AtendeClienteClient
    {
        public CorreiosApi()
            : base(
                  new BasicHttpBinding(BasicHttpSecurityMode.Transport),
                  new EndpointAddress("https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente"))
        {
        }
    }
}
