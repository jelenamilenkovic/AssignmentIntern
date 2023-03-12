using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentIntern.Models
{
    public class Employee
    {
        public virtual int Id { get; protected set; }
        public virtual string FullName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual DateTime DateOfBirth{ get; set; }
        public virtual int MonthlySalary { get; set; }
        public virtual Department Department { get; set; }
        public virtual IList<Task> Tasks { get; set; }


        public Employee()
        {
            Tasks = new List<Task>();
        }
    }
}
