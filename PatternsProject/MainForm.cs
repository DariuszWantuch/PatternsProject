using DevExpress.XtraEditors;
using PatternsProject.Model;
using PatternsProject.Repo;
using PatternsProject.Service;
using PatternsProject.View.ContractorForms;
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
        private ProductRepository productRepository = new ProductRepository();        

        public PatternsProject()
        {
            InitializeComponent();
            NHService.Init();
            this.CenterToScreen();          

            gridControlProduct.DataSource = productRepository.GetAll();
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
            var result = XtraMessageBox.Show("Czy napewno chcesz usunąć wybrany produkt? ", "Usuwanie produktu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            Product selectedProduct = (Product)gridViewProduct.GetFocusedRow();

            if(result == DialogResult.Yes)
            {
                if(selectedProduct.Id > 0)
                {
                    productRepository.Delete(selectedProduct);

                    gridControlProduct.DataSource = productRepository.GetAll();

                    XtraMessageBox.Show("Produkt został pomyślnie usunięty. ", "Usuwanie produktu", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Błąd pobierania produktu do usunięcia. ", "Usuwanie produktu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
        }

        private void editButtonProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)gridViewProduct.GetFocusedRow();

            using (ProductForm addProductForm = new ProductForm(selectedProduct))
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    gridControlProduct.DataSource = productRepository.GetAll();
                }
            }
        }
    }
}