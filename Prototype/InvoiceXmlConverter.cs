using System.Collections.Generic;
using System.Xml;

namespace Prototype
{
    public class InvoiceXmlConverter
    {
        public IEnumerable<XmlDocument> Invoices { get; set; }

        public InvoiceXmlConverter()
        {
            // Performs resource-intensive operation to load Xml
            // 10 seconds...
        }

        public InvoiceXmlConverter Clone()
        {
            return (InvoiceXmlConverter)MemberwiseClone();
        }

        public InvoiceXmlConverter Instance
        {
            get
            {
                return (InvoiceXmlConverter)MemberwiseClone();
            }
        }
    }
}