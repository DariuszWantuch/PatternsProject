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
    public partial class AddContractorForm : DevExpress.XtraEditors.XtraForm
    {
        public Contractor contractor { get; set; }

        private readonly BindingSource bindingSource = new BindingSource();

        ContractorRepository contractorRepository = new ContractorRepository();

        public AddContractorForm()
        {
            InitializeComponent();
            this.CenterToParent();

            bindingSource.DataSource = contractorRepository.GetAll();
            gridControlContractor.DataSource = bindingSource;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addButtonProduct_Click(object sender, EventArgs e)
        {
            contractor = this.bindingSource.Current as Contractor;

            this.DialogResult = DialogResult.OK;
        }
    }
}