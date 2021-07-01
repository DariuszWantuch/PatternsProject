using DevExpress.XtraEditors;
using PatternsProject.Model;
using PatternsProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsProject.Service
{
    public class ContractorService
    {
        ContractorRepository contractorRepository = new ContractorRepository();

        public bool Delete(Contractor selectedContractor)
        {
            var result = XtraMessageBox.Show("Czy napewno chcesz usunąć wybranego kontrahenta? ", "Usuwanie kontrahenta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (selectedContractor.Id > 0)
                {
                    contractorRepository.Delete(selectedContractor);                  

                    XtraMessageBox.Show("Kontrahent został pomyślnie usunięty. ", "Usuwanie kontrahenta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Błąd pobierania kontrahenta do usunięcia. ", "Usuwanie kontrahenta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }

            return false;
        }
    }
}
