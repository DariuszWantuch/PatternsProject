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
    public partial class AddProductForm : DevExpress.XtraEditors.XtraForm
    {
        public Product product { get; set; }

        private readonly BindingSource bindingSource = new BindingSource();
        ProductRepository productRepository = new ProductRepository();

        public AddProductForm()
        {
            InitializeComponent();
            this.CenterToParent();

            bindingSource.DataSource = productRepository.GetAll();
            gridControlProduct.DataSource = bindingSource;          
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addButtonProduct_Click(object sender, EventArgs e)
        {        
            product = this.bindingSource.Current as Product;

            this.DialogResult = DialogResult.OK;
        }
    }
}