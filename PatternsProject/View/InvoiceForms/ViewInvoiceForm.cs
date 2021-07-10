using DevExpress.XtraEditors;
using PatternsProject.Model;
using PatternsProject.Repo;
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
    public partial class ViewInvoiceForm : DevExpress.XtraEditors.XtraForm
    {
        private InvoiceRepository invoiceRepository = new InvoiceRepository();
        private Invoice invoice = new Invoice();

        public ViewInvoiceForm(int id)
        {
            InitializeComponent();
            this.CenterToParent();

            invoice = invoiceRepository.Get(id);

            elementBindingSource.DataSource = invoice.ElementList;

            textEditContractor.Text = invoice.Contractor.Name + ", " + invoice.Contractor.PostalCode + " " + invoice.Contractor.City + ", " + invoice.Contractor.Street + ", " + invoice.Contractor.Phone;

            labelControlViewInvoice.Text = "Razem: " + invoice.CostSum.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}