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

namespace PatternsProject.View.ContractorForms
{
    public partial class ContractorForm : DevExpress.XtraEditors.XtraForm
    {
        ContractorRepository contractorRepository = new ContractorRepository();
        private Contractor _selectedContractor = new Contractor();
        int contractorId = 0;

        public ContractorForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public ContractorForm(Contractor selectedContractor)
        {
            InitializeComponent();
            this.CenterToParent();

            _selectedContractor = selectedContractor;

            contractorId = selectedContractor.Id;

            textEditContractorAddress.Text = selectedContractor.Address;
            textEditContractorEmail.Text = selectedContractor.Email;
            textEditContractorName.Text = selectedContractor.Name;
            textEditContractorNIP.Text = selectedContractor.NIP;
            textEditContractorPhone.Text = selectedContractor.Phone;
        }

        private void backButtonContractor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void resetButtonContractor_Click(object sender, EventArgs e)
        {
            textEditContractorAddress.Text = "";
            textEditContractorEmail.Text = "";
            textEditContractorName.Text = "";
            textEditContractorNIP.Text = "";
            textEditContractorPhone.Text = "";
        }

        private void saveButtonContractor_Click(object sender, EventArgs e)
        {
            if (contractorId == 0)
            {
                var contractor = new Contractor()
                {
                    Address = textEditContractorAddress.Text.ToString(),
                    Email = textEditContractorEmail.Text.ToString(),
                    Name = textEditContractorName.Text.ToString(),
                    NIP = textEditContractorNIP.Text.ToString(),
                    Phone = textEditContractorPhone.Text.ToString()
                };

                contractorRepository.Save(contractor);

                XtraMessageBox.Show("Kontrahent został pomyślnie dodany. ", "Dodawanie kontrahenta", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                _selectedContractor.Address = textEditContractorAddress.Text.ToString();
                _selectedContractor.Email = textEditContractorEmail.Text.ToString();
                _selectedContractor.Name = textEditContractorName.Text.ToString();
                _selectedContractor.NIP = textEditContractorNIP.Text.ToString();
                _selectedContractor.Phone = textEditContractorPhone.Text.ToString();

                contractorRepository.Save(_selectedContractor);

                XtraMessageBox.Show("Produkt został pomyślnie zaktualizowany. ", "Aktualizacja produktu", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}