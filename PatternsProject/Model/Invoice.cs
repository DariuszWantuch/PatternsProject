using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Model
{
    public class Invoice
    {
        public virtual int Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Contractor Contractor { get; set; }
        public virtual ISet<Element> ElementList { get; set; }

        public virtual Contractor contractor { get; set; }

        public virtual string Name
        {
            get
            {
                if (contractor != null)
                {
                    return contractor.Name;
                }
                else
                {
                    return null;
                }
            }
        }

        public virtual string NIP
        {
            get
            {
                if (contractor != null)
                {
                    return contractor.NIP;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
