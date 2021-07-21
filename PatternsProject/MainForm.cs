using DevExpress.XtraEditors;
using PatternsProject.Model;
using PatternsProject.Properties;
using PatternsProject.Repo;
using PatternsProject.Report;
using PatternsProject.Service;
using PatternsProject.Service.Generator;
using PatternsProject.Service.Listener;
using PatternsProject.Service.Notify;
using PatternsProject.Utility;
using PatternsProject.View.ContractorForms;
using PatternsProject.View.InvoiceForms;
using PatternsProject.View.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsProject
{   
    public partial class PatternsProject : DevExpress.XtraEditors.XtraForm
    {
        private ProductService productService = new ProductService();
        private ContractorService contractorService = new ContractorService();
        private ProductRepository productRepository = new ProductRepository();
        private InvoiceRepository invoiceRepository = new InvoiceRepository();       
        private List<Product> productList = new List<Product>();
        private ContractorRepository contractorRepository = new ContractorRepository();       
        public Worker worker = new Worker();
        EmailSendable email = new EmailSendable();

        public PatternsProject()
        {
            InitializeComponent();
            NHService.GetNHService();
            this.CenterToScreen();      

            gridControlContractor.DataSource = contractorRepository.GetAll();
            gridControlProduct.DataSource = productRepository.GetAll();
            gridControlInvoice.DataSource = invoiceRepository.GetAll();
            invoiceBindingSource1.DataSource = invoiceRepository.GetAll();                 
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void addButtonContractor_Click(object sender, EventArgs e)
        {
            using (ContractorForm addContractorForm = new ContractorForm())
            {
                if(addContractorForm.ShowDialog() == DialogResult.OK)
                {
                    var logger = new LoggingListener($"Dodano nowego kontrahenta.");

                    worker.events.AddEvent(EventType.Contractors, logger);

                    gridControlContractor.DataSource = contractorRepository.GetAll();
                }
            }
        }

        private void addButtonProduct_Click(object sender, EventArgs e)
        {
            using (ProductForm addProductForm = new ProductForm())
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    var logger = new LoggingListener($"Dodano nowy produkt.");

                    worker.events.AddEvent(EventType.Products, logger);

                    gridControlProduct.DataSource = productRepository.GetAll();
                }
            }
        }

        private void deleteButtonProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)gridViewProduct.GetFocusedRow();

            bool result = productService.Delete(selectedProduct);

            if(result == true)
            {
                var logger = new LoggingListener($"Usunięto produkt o nazwie: {selectedProduct.Name}");

                worker.events.AddEvent(EventType.Products, logger);

                gridControlProduct.DataSource = productRepository.GetAll();
            }
            
        }

        private void editButtonProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)gridViewProduct.GetFocusedRow();

            using (ProductForm editProductForm = new ProductForm(selectedProduct))
            {
                if (editProductForm.ShowDialog() == DialogResult.OK)
                {
                    gridControlProduct.DataSource = productRepository.GetAll();

                    var logger = new LoggingListener($"Edytowano produkt o nazwie: {selectedProduct.Name}");

                    worker.events.AddEvent(EventType.Products, logger);
                }
            }
        }

        private void editButtonContractor_Click(object sender, EventArgs e)
        {
            Contractor selectedContractor = (Contractor)gridViewContractor.GetFocusedRow();

            using (ContractorForm editContractorForm = new ContractorForm(selectedContractor))
            {
                if (editContractorForm.ShowDialog() == DialogResult.OK)
                {
                    gridControlContractor.DataSource = contractorRepository.GetAll();

                    var logger = new LoggingListener($"Edytowano kontrahenta o nazwie: {selectedContractor.Name}");

                    worker.events.AddEvent(EventType.Contractors, logger);
                }
            }
        }

        private void deleteButtonContractor_Click(object sender, EventArgs e)
        {
            Contractor selectedContractor = (Contractor)gridViewContractor.GetFocusedRow();

            bool result = contractorService.Delete(selectedContractor);

            if (result == true)
            {
                var logger = new LoggingListener($"Usunięto kontrahenta o nazwie: {selectedContractor.Name}.");

                worker.events.AddEvent(EventType.Contractors, logger);
                gridControlContractor.DataSource = contractorRepository.GetAll();
            }
        }

        private void addButtonInvoice_Click(object sender, EventArgs e)
        {
            using (InvoiceForm invoiceForm = new InvoiceForm())
            {
                if (invoiceForm.ShowDialog() == DialogResult.OK)
                {
                    var logger = new LoggingListener($"Dodano nową fakturę.");

                    worker.events.AddEvent(EventType.Invoices, logger);

                    gridControlInvoice.DataSource = invoiceRepository.GetAll();
                }
            }
        }

        private void viewButtonInvoice_Click(object sender, EventArgs e)
        {
            var invoice = (Invoice)gridViewInvoice.GetFocusedRow();
            using (ViewInvoiceForm viewInvoiceForm = new ViewInvoiceForm(invoice.Id))
            {
                if (viewInvoiceForm.ShowDialog() == DialogResult.OK)
                {
                    var logger = new LoggingListener($"Wyświetlono fakturę o nazwie: {invoice.Name}.");

                    worker.events.AddEvent(EventType.Invoices, logger);
                }
            }
        }

        private void sendButtonEmail_Click(object sender, EventArgs e)
        {
            InvoiceSenderService invoiceSender = new InvoiceSenderService(email);

            try
            {                             
                var invoice = (Invoice)gridViewInvoice.GetFocusedRow();
                
                var invoicePath = GenerateDocument(new PdfGenerator(), invoice);

                invoiceSender.Send(invoice.Contractor.Email, $"Faktura nr {invoice.Id}", $"Wystawiono fakturę nr {invoice.Id}", invoice.Id, invoicePath);

                var logger = new LoggingListener($"Faktura nr { invoice.Id }, została wysłana pomyślnie na adres: { invoice.Contractor.Email}");

                worker.events.AddEvent(EventType.SentInvoices, logger);

                XtraMessageBox.Show($"Faktura nr {invoice.Id}, została wysłana pomyślnie na adres: {invoice.Contractor.Email}", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Wystąpił problem podczas wysyłki email: {ex}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void genereteButtonPdf_Click(object sender, EventArgs e)
        {                                
            try
            {
                var invoice = (Invoice)gridViewInvoice.GetFocusedRow();

                GenerateDocument(new PdfGenerator(), invoice);

                var logger = new LoggingListener($"Faktura nr {invoice.Id}, została pomyślnie wygenrowana do PDF-a.");

                worker.events.AddEvent(EventType.GeneratePDFs, logger);

                XtraMessageBox.Show($"Faktura nr {invoice.Id}, została pomyślnie wygenrowana do PDF-a.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Wystąpił problem podczas generowania faktury do PDF-a: {ex}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static string GenerateDocument(Generator generator, Invoice invoice)
        {
            generator.Template(invoice);

            return generator.path;
        }

        private void PatternsProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            worker.SaveGeneratePDFs();
            worker.SaveInvoices();
            worker.SavePContractors();
            worker.SaveProduct();
            worker.SaveSentInvoices();
        }
    }
}