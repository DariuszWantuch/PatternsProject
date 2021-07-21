using DevExpress.XtraEditors;
using PatternsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsProject.Service.Generator
{
    public abstract class Generator
    {
        public string path;
        public void Template(Invoice invoice)
        {
            this.StartGenerate();
            path = this.Generate(invoice);
            this.EndGenerate();
        }

        protected void StartGenerate()
        {
            XtraMessageBox.Show("Rozpoczęcie generowania.", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void EndGenerate()
        {
            XtraMessageBox.Show("Zakończenie generowania.", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected abstract string Generate(Invoice invoice);
    }
}
