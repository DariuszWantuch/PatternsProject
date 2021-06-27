using DevExpress.XtraEditors;
using PatternsProject.Service;
using PatternsProject.View.Contractor;
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
        public PatternsProject()
        {
            InitializeComponent();
            NHService.Init();
            this.CenterToScreen();
                
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
    }
}