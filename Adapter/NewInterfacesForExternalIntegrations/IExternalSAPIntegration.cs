namespace Adapter.NewInterfacesForExternalIntegrations
{
    public interface IExternalSAPIntegration
    {
        string Address { get; }
        string Endpoint { get; }
        int Port { get; }

        // No parameter - Without SAP details
        void CallIntegrationFromSAP();
    }
}