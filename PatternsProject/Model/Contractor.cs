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
        public virtual long NIP { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
       
    }
}
