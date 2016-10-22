using Adapter.NewInterfacesForExternalIntegrations;
using System;

namespace Adapter.LegacyIntegrations
{
    public class LegacyIntegrationSAPAdapter : IExternalSAPIntegration
    {
        private LegacyIntegrationSAP legacyIntegrationSAP;

        public LegacyIntegrationSAPAdapter()
        {
            legacyIntegrationSAP = new LegacyIntegrationSAP();
        }

        public string Address
        {
            get
            {
                return "Address";
            }
        }

        public string Endpoint
        {
            get
            {
                return "Endpoint";
            }
        }

        public int Port
        {
            get
            {
                return 1000;
            }
        }

        /// New implementation encapsulates SAP integration details
        public void CallIntegrationFromSAP()
        {
            Console.WriteLine("Adapter Setting up parameters for legacy class...");

            legacyIntegrationSAP.CallIntegrationFromSAP(Address, Endpoint, Port);
        }
    }
}