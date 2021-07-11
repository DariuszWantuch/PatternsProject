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
        public virtual DateTime DueDate { get; set; }
        public virtual Contractor Contractor { get; set; }
        public virtual ISet<Element> ElementList { get; set; }
        public virtual double CostSum { get; set; }

        public virtual string CostSumString 
        {
            get
            {
                return CostSum.ToString();
            }
        }

        public virtual string DueDateString
        {
            get
            {
                return DueDate.ToString("dd/MMMM/yyyy");
            }
        }

        public virtual string DateString
        {
            get
            {
                return Date.ToString("dd/MMMM/yyyy");
            }
        }


        public virtual int Elements
        {
            get
            {
                if (ElementList.Count() != 0)
                {
                    return ElementList.Count();
                }
                else
                {
                    return 0;
                }
            }
        }

        public virtual string Name
        {
            get
            {
                if (Contractor != null)
                {
                    return Contractor.Name;
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
                if (Contractor != null)
                {
                    return Contractor.NIP;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
