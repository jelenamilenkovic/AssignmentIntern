using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentIntern.Models
{
    public class Task
    {
        public virtual int Id { get; protected set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Employee Assignee{ get; set; }
        public virtual DateTime Due_Date { get; set; }


        public Task()
        {
        }
    }
}
