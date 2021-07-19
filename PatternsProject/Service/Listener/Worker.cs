using PatternsProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Listener
{
    public class Worker
    {
        public EventManager events;

        public Worker()
        {
            events = new EventManager();
        }

        public void SaveProduct()
        {
            events.UpdateFiles(EventType.Products, "ProductLogs.txt");
        }

        public void SavePContractors()
        {
            events.UpdateFiles(EventType.Contractors, "ContractorLogs.txt");
        }

        public void SaveInvoices()
        {
            events.UpdateFiles(EventType.Invoices, "InvoiceLogs.txt");
        }

        public void SaveGeneratePDFs()
        {
            events.UpdateFiles(EventType.GeneratePDFs, "GeneratePDFLogs.txt");
        }

        public void SaveSentInvoices()
        {
            events.UpdateFiles(EventType.SentInvoices, "SentInvoiceLogs.txt");
        }
    }
}
