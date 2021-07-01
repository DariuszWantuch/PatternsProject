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
    public class ProductService
    {
        ProductRepository productRepository = new ProductRepository();

        public bool Delete(Product selectedProduct)
        {
            var result = XtraMessageBox.Show("Czy napewno chcesz usunąć wybrany produkt? ", "Usuwanie produktu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (selectedProduct.Id > 0)
                {
                    productRepository.Delete(selectedProduct);                  

                    XtraMessageBox.Show("Produkt został pomyślnie usunięty. ", "Usuwanie produktu",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Błąd pobierania produktu do usunięcia. ", "Usuwanie produktu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }

            return false;
        }
    }
}
