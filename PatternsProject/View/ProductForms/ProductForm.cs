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

namespace PatternsProject.View.ProductForms
{
    public partial class ProductForm : DevExpress.XtraEditors.XtraForm
    {
        private ProductRepository productRepository = new ProductRepository();
        private Product _selectedProduct = new Product();
        int productId = 0;

        public ProductForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public ProductForm(Product selectedProduct)
        {
            InitializeComponent();
            this.CenterToParent();

            _selectedProduct = selectedProduct;

            productId = selectedProduct.Id;

            textEditProductCost.Text = selectedProduct.Cost;
            textEditProductEAN.Text = selectedProduct.EAN;
            textEditProductName.Text = selectedProduct.Name;
        }

        private void backButtonAddProduct_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void saveButtonAddProduct_Click(object sender, EventArgs e)
        {
            if(productId == 0)
            {
                var product = new Product()
                {
                    Name = textEditProductName.Text.ToString(),
                    Cost = textEditProductCost.Text.ToString(),
                    EAN = textEditProductEAN.Text.ToString()
                };

                productRepository.Save(product);

                XtraMessageBox.Show("Produkt został pomyślnie dodany. ", "Dodawanie produktu", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                _selectedProduct.Cost = textEditProductCost.Text.ToString();
                _selectedProduct.Name = textEditProductName.Text.ToString();
                _selectedProduct.EAN = textEditProductEAN.Text.ToString();

                productRepository.Save(_selectedProduct);

                XtraMessageBox.Show("Produkt został pomyślnie zaktualizowany. ", "Aktualizacja produktu", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void resetButtonAddProduct_Click(object sender, EventArgs e)
        {
            textEditProductCost.Text = "";
            textEditProductName.Text = "";
            textEditProductEAN.Text = "";
        }
    }
}