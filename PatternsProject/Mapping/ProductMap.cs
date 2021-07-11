using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PatternsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Mapping
{
    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Schema("dbo");
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Name);
            Property(x => x.Cost);
            Property(x => x.EAN);
            Property(x => x.Description);
        }
    }
}
