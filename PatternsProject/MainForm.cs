using DevExpress.XtraEditors;
using PatternsProject.Model;
using PatternsProject.Repo;
using PatternsProject.Service;
using PatternsProject.View.ContractorForms;
using PatternsProject.View.InvoiceForms;
using PatternsProject.View.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public PatternsProject()
        {
            InitializeComponent();
            NHService.Init();
            this.CenterToScreen();
          
            gridControlContractor.DataSource = contractorRepository.GetAll();
            gridControlProduct.DataSource = productRepository.GetAll(); ;
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
                }
            }
        }

        private void deleteButtonContractor_Click(object sender, EventArgs e)
        {
            Contractor selectedContractor = (Contractor)gridViewContractor.GetFocusedRow();

            bool result = contractorService.Delete(selectedContractor);

            if (result == true)
            {
                gridControlContractor.DataSource = contractorRepository.GetAll();
            }
        }

        private void addButtonInvoice_Click(object sender, EventArgs e)
        {
            using (InvoiceForm invoiceForm = new InvoiceForm())
            {
                if (invoiceForm.ShowDialog() == DialogResult.OK)
                {
                    gridControlInvoice.DataSource = invoiceRepository.GetAll();
                }
            }
        }
    }
}