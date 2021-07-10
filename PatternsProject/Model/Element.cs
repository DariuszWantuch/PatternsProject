using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Model
{
    public class Element
    {
        public virtual int Id { get; set; }        
        public virtual double UnitPrice { get; set; }
        public virtual ISet<Product> Products { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
        public virtual int Quantity { get; set; }


        public virtual double ElementCost
        {
            get
            {
                if (Product != null)
                {
                    return Quantity * UnitPrice;
                }
                else
                {
                    return 0;
                }

            }
            set
            {               
            }
        }

        public virtual string ProductName
        {
            get
            {
                if (Product != null)
                {
                    return Product.Name;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
