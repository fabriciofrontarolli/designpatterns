using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pre Loading all heavy stuff from DB or File
            var invoiceXmlConverter = new InvoiceXmlConverter();

            // Default approach - to use via Clone method
            var salesInvoiceConverter = invoiceXmlConverter.Clone();

            // Another approach - to use via property
            var manufactureInvoiceConverter = invoiceXmlConverter.Instance;

            Console.ReadKey();
        }
    }
}