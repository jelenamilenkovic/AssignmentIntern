using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentIntern.Models;
using FluentNHibernate.Mapping;

namespace AssignmentIntern.Mappings
{
    class EmployeeMapping : ClassMap<AssignmentIntern.Models.Employee>
    {
        public EmployeeMapping() {
        Table("Employee");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity();

        Map(x => x.DateOfBirth);
        Map(x => x.Email);
        Map(x => x.FullName);
        Map(x => x.MonthlySalary);
        Map(x => x.PhoneNumber);
        References(x => x.Department).Column("Department").LazyLoad();
        HasMany(x => x.Tasks).KeyColumn("Employee").LazyLoad().Cascade.All().Inverse(); }
    }
}
