using PatternsProject.Model;
using PatternsProject.Report;
using PatternsProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Generator
{
    public class PdfGenerator : Generator
    {
        InvoiceReport invoiceReport = new InvoiceReport();
        protected override string Generate(Invoice invoice) 
        {           
            var invoiceName = $"{invoice.Id}{DateTime.UtcNow.ToString("dd")}{DateTime.UtcNow.ToString("hh")}{DateTime.UtcNow.ToString("mm")}{DateTime.UtcNow.ToString("ss")}.pdf";
            var invoicePath = PathOptions.GeneratePDF + invoiceName;
            List<Invoice> invoiceList = new List<Invoice>();
            invoiceList.Add(invoice);
            invoiceReport.DataSource = invoiceList;
            invoiceReport.DataMember = "ElementList";
            invoiceReport.ExportToPdf(invoicePath);

            return invoicePath;
        }
    }
}
