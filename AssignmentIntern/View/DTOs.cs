using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentIntern.View
{
    #region Department
    public class DepartmentView
    {
        public int Id;
        public string DepartmentName;
        public string City;
        public string Country;
        

        public DepartmentView()
        {

        }
        public DepartmentView(int id, string DepartmentName, string City, string Country)
        {
            this.Id = id;
            this.DepartmentName= DepartmentName;
            this.City = City;
            this.Country = Country;
        }
    }

    public class DepartmentBasic
    {
        public int Id;
        public virtual string DepartmentName { get; set; }
        public virtual string City { get; set; }
        public virtual string Country {  get; set; }

        public virtual IList<EmployeeBasic> Employees { get; set; }
        public DepartmentBasic()
        {
            Employees = new List<EmployeeBasic>();
        }
        public DepartmentBasic(int id, string DepartmentName, string City, string Country)
        {
            this.Id = id;
            this.DepartmentName = DepartmentName;
            this.City = City;
            this.Country = Country;
        }
    }

    #endregion

    #region Employee
      public class EmployeeView
    {
        public int Id;
        public string FullName;
        public string Email;
        public int Department;
        public string PhoneNumber;
        public DateTime DateOfBirth;
        public int MonthlySalary;


        public EmployeeView()
        {

        }
        public EmployeeView(int id, string FullName, string Email, string PhoneNumber,int Department,DateTime DateOfBirth,int MonthlySalary)
        {
            this.Id = id;
            this.FullName= FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Department = Department;
            this.DateOfBirth = DateOfBirth;
            this.MonthlySalary = MonthlySalary;
        }
        public EmployeeView(int id, string FullName, string Email, string PhoneNumber, DateTime DateOfBirth, int MonthlySalary)
        {
            this.Id = id;
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.DateOfBirth = DateOfBirth;
            this.MonthlySalary = MonthlySalary;
        }
    }

    public class EmployeeBasic
    {
        public int Id;
        public virtual string FullName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual int MonthlySalary { get; set; }
        public DepartmentBasic Department;
        public virtual IList<TaskBasic> Tasks { get; set; }
        public EmployeeBasic()
        {
            Tasks = new List<TaskBasic>();
        }
        public EmployeeBasic(int id, string FullName, string Email, string PhoneNumber, DateTime DateOfBirth, int MonthlySalary)
        {
            this.Id = id;
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.DateOfBirth = DateOfBirth;
            this.MonthlySalary = MonthlySalary;
        }
    }



    #endregion

    #region Task
    public class TaskView
    {
        public int Id;
        public string Title;
        public string Description;
        public DateTime Due_Date;
        public EmployeeBasic Assignee;


        public TaskView()
        {

        }
        public TaskView(int id, string Title, string Description,  DateTime Due_Date)
        {
            this.Id = id;
            this.Title= Title;
            this.Description = Description;
            this.Due_Date = Due_Date;
        }
    }

    public class TaskBasic
    {

        public  int Id;
        public virtual string Title{ get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Due_Date { get; set; }
        public virtual EmployeeBasic Assignee { get; set; }
        public TaskBasic()
        {
        }
        public TaskBasic(int id, string Title, string Description, DateTime Due_Date)
        {

            this.Id = id;
            this.Title = Title;
            this.Description = Description;
            this.Due_Date = Due_Date;
        }
    }
    #endregion
}
