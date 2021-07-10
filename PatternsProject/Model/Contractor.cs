using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Model
{
    public class Contractor
    {
        public virtual int Id { get; set; }
        public virtual string NIP { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Street { get; set; }
        public virtual string Phone { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }

    }
}
