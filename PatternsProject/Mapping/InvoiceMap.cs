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
    public class InvoiceMap : ClassMapping<Invoice>
    {
        public InvoiceMap()
        {
            Table("Invoice");
            Schema("dbo");
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.Date);
            Property(x => x.CostSum);
            Property(x => x.DueDate);

            ManyToOne(x => x.Contractor, x =>
            {
                x.Column("Contractor_Id");
                x.Lazy(LazyRelation.NoLazy);
                x.Cascade(Cascade.All);
            });

            Set(x => x.ElementList, m =>
            {
                m.Inverse(true);
                m.Key(k => k.Column("Invoice_Id"));
                m.Cascade(Cascade.All);
                m.Lazy(CollectionLazy.NoLazy);
            }, r => r.OneToMany(x => x.Class(typeof(Element))));
        }
    }
}
