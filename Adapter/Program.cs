using Adapter.LegacyIntegrations;
using Adapter.NewIntegrations;
using Adapter.NewInterfacesForExternalIntegrations;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integration with SalesForce
            IExternalSalesForceIntegration salesForceInterface = new ExternalSalesForceIntegration();
            salesForceInterface.IntegrateWithSalesForce();

            //Integration with SAP
            IExternalSAPIntegration sapInterface = new LegacyIntegrationSAPAdapter();
            sapInterface.CallIntegrationFromSAP();

            Console.ReadKey();
        }
    }
}