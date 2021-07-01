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
    public class ContractorMap : ClassMapping<Contractor>
    {
        public ContractorMap()
        {
            Table("Contractor");
            Schema("dbo");
            Id(x => x.Id, map => map.Generator(Generators.Identity));
            Property(x => x.NIP);
            Property(x => x.Name);
            Property(x => x.Email);
            Property(x => x.Address);
            Property(x => x.Phone);
        }
    }
}
