using Adapter.NewInterfacesForExternalIntegrations;
using System;

namespace Adapter.NewIntegrations
{
    public class ExternalSalesForceIntegration : IExternalSalesForceIntegration
    {
        public void IntegrateWithSalesForce()
        {
            //.. Encapsulates details
            Console.WriteLine("Integration with SalesForce...");
        }
    }
}