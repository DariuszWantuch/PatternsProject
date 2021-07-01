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
    public class ElementMap : ClassMapping<Element>
    {
        public ElementMap()
        {
            Table("Element");
            Schema("dbo");
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Quantity);
            Property(x => x.UnitPrice);

            ManyToOne(x => x.Product, m =>
            {
                m.Column("Product_Id");
                m.Lazy(LazyRelation.NoLazy);
                m.Cascade(Cascade.All);
            });

            ManyToOne(x => x.Invoice, m =>
            {
                m.Column("Invoice_Id");
                m.Cascade(Cascade.All);
            });
        }
    }
}
