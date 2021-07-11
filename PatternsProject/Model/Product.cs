using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Model
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Cost { get; set; }
        public virtual string EAN { get; set; }
        public virtual string Description { get; set; }
    }
}
