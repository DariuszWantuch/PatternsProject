using PatternsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.ContractorDisplay
{
    public class DisplayLongAddress : Display
    {
        public string Display(Contractor contractor)
        {
            return contractor.Name + "," + contractor.PostalCode + contractor.City + "," + contractor.Street + "," + contractor.Phone;
        }
    }
}
