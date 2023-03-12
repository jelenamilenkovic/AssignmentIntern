using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentIntern.Models;
using FluentNHibernate.Mapping;

namespace AssignmentIntern.Mappings
{
    class TaskMapping : ClassMap<AssignmentIntern.Models.Task>
    {
        public TaskMapping()
        {
            Table("Task");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity();

            Map(x => x.Description);
            Map(x => x.Due_Date);
            Map(x => x.Title);
            References(x => x.Assignee).Column("Employee").LazyLoad();
        }
    }
}
