using DevExpress.XtraEditors;
using PatternsProject.Model;
using PatternsProject.Repo;
using PatternsProject.Report;
using PatternsProject.Service.ContractorDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsProject.View.InvoiceForms
{
    public partial class InvoiceForm : DevExpress.XtraEditors.XtraForm
    {       
        private readonly List<Element> elements = new List<Element>();
        private Contractor contractor = new Contractor();
        private Invoice invoice = new Invoice();
        private InvoiceRepository invoiceRepository = new InvoiceRepository();
        Context context = new Context();

        public InvoiceForm()
        {
            InitializeComponent();
            this.CenterToParent();

            elementBindingSource.DataSource = elements;
            context.SetDisplay(new DisplayLongAddress());
        }

        private void addButtonContractor_Click(object sender, EventArgs e)
        {
            using(AddContractorForm addContractorForm = new AddContractorForm())
            {
                if(addContractorForm.ShowDialog() == DialogResult.OK)
                {
                    contractor = addContractorForm.contractor;

                    textEditAddContractor.Text = context.Display(contractor);
                }
            }
        }

        private void addButtonProduct_Click(object sender, EventArgs e)
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {                  
                    Element element = new Element();

                    element.Product = addProductForm.product;

                    element.UnitPrice = Convert.ToDouble(addProductForm.product.Cost);

                    element.Quantity = 1;

                    elements.Add(element);

                    elementBindingSource.DataSource = elements;

                    elementBindingSource.ResetBindings(true);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            elements.Clear();
            contractor = null;

            textEditAddContractor.Text = "";
            elementBindingSource.ResetBindings(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var index = gridViewInvoiceElement.GetSelectedRows();
            if(index.Length == 1)
            {
                var temp = (Element)gridViewInvoiceElement.GetRow(index.First());

                elements.Remove(temp);              
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(contractor.Id == 0)
            {
                XtraMessageBox.Show("Brak kontrahenta.","Powiadomienie",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (elements.Count() == 0)
            {
                XtraMessageBox.Show("Brak elementów.", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            invoice.Contractor = contractor;
            invoice.ElementList = elements.ToHashSet();
            invoice.Date = DateTime.Today;
            invoice.DueDate = DateTime.Today.AddDays(10);

            foreach (var item in elements)
            {
                item.Invoice = invoice;
                invoice.CostSum += item.ElementCost;
            }
            invoiceRepository.Save(invoice);

            this.DialogResult = DialogResult.OK;
        }      
    }
}