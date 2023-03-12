using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentIntern.Models
{
    public class Department
    {
        public virtual int Id { get; protected set; }
        public virtual string DepartmentName { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }
        public virtual IList<Employee> Employees { get; set; }


        public Department()
        {
            Employees = new List<Employee>();
        }
    }
}
