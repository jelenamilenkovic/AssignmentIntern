using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentIntern.Models;
using FluentNHibernate.Mapping;

namespace AssignmentIntern.Mappings
{
    class DepartmentMapping : ClassMap<AssignmentIntern.Models.Department>
    {
        public DepartmentMapping()
        {
            Table("Department");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.City);
            Map(x => x.Country);
            Map(x => x.DepartmentName);

            HasMany(x => x.Employees).KeyColumn("Employees").LazyLoad().Cascade.All().Inverse();

        }
    }
}
