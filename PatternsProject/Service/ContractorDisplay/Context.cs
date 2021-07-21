using PatternsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.ContractorDisplay
{
    public class Context
    {
        private Display display;

        public void SetDisplay(Display display)
        {
            this.display = display;
        }

        public string Display(Contractor contractor)
        {
            return display.Display(contractor);
        }
    }
}
