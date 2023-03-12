using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using AssignmentIntern.Models;
using System.Windows.Forms;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
namespace AssignmentIntern.View
{          
    public class DTOManager
    {
        public static async System.Threading.Tasks.Task SendMail(string department,string subject,string content) {
            try
            {
                ISession s = Middleware.GetSession();
                string apiKey = "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";
                var client = new SendGridClient(apiKey);
                var senderEmail = new EmailAddress("jelenamilenkovic@sendgrid.com", "Verified Sender email");
                string emailSubject = subject; ;
                string htmlContent = "<strong>Example for internship</strong>";
                string textContent = content;
                IQuery q = s.CreateSQLQuery("select e.email from employee e left join department d on d.id=e.department where d.departmentname=:depart");
                q.SetString("depart", department);
                IList<string> allOfthem = q.List<string>();
                foreach (string email in allOfthem)
                {
                    var recieverEmail = new EmailAddress(email, "Receiver Name");
                    var msg = MailHelper.CreateSingleEmail(senderEmail, recieverEmail, emailSubject, textContent, htmlContent);
                    var resp = await client.SendEmailAsync(msg).ConfigureAwait(false);
                }

                s.Close();
            }
            catch(Exception ec)
            {

            }

        }
        #region Department
        public static List<DepartmentView> readDepartments()
        {
            List<DepartmentView> departments = new List<DepartmentView>();
            try
            {
                ISession s = Middleware.GetSession();

                IEnumerable<AssignmentIntern.Models.Department> allofthem = from o in s.Query<AssignmentIntern.Models.Department>() select o;

                foreach (AssignmentIntern.Models.Department d in allofthem)
                {
                    departments.Add(new DepartmentView(d.Id, d.DepartmentName,d.City,d.Country));
                }

                s.Close();
            }
            catch (Exception ec)
            {
            }

            return departments;
        }
        public static DepartmentBasic readDepartment(int id)
        {
            DepartmentBasic department = new DepartmentBasic();
            try
            {
                ISession s = Middleware.GetSession();
                Department d = s.Load<Department>(id);

                department.City = d.City;
                department.Country = d.Country;
                department.DepartmentName = d.DepartmentName;

                s.Close();
            }
            catch (Exception ec)
            {
            }

            return department;
        }
        public static void createDepartment(DepartmentBasic d)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Department o = new AssignmentIntern.Models.Department();
                o.City = d.City;
                o.Country = d.Country;
                o.DepartmentName = d.DepartmentName;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static DepartmentBasic updateDepartment(DepartmentBasic p)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Department o = s.Load<AssignmentIntern.Models.Department>(p.Id);
                o.City = p.City;
                o.Country = p.Country;
                o.DepartmentName = p.DepartmentName;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void deleteDepartment(int id)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Department o = s.Load<AssignmentIntern.Models.Department>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<string> NamesOfDepartments()
        {
            List<string> departments = new List<string>();
            try
            {
                ISession s = Middleware.GetSession();

                IQuery q = s.CreateSQLQuery("select distinct d.departmentname from Department d");
                IList<string> allOfthem = q.List<string>();
                foreach (string d in allOfthem)
                {
                    departments.Add(d);
                }

                s.Close();

            }
            catch (Exception ec)
            {
            }

            return departments;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        // 5. Any additional meaningful statistics.
        ///////////////////////////////////////////////////////////////////////////////////////////
        public static IList<object[]> statistic(string department)
        {
            IList<object[]> result=new List<object[]>();
            
            try
            {
               
                ISession s = Middleware.GetSession();
                IQuery q = s.CreateQuery("select d.country,d.city,sum(e.monthlysalary),count(e.department),sum(e.MonthlySalary*1.0)/(count(e.department)*1.0) from employee e "+"left join department d on d.id=e.department where d.departmentname='QA'"+" group by (d.city, d.country);");

                result = q.List<object[]>();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            } 
            return result;
        }
        #endregion

        
        #region Employee

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 3. Display the 5 employees who complated the largest number of tasks in the past month.
        ///////////////////////////////////////////////////////////////////////////////////////////
        public static List<EmployeeView> read5Employees()
        {
            List<EmployeeView> employees = new List<EmployeeView>();
            try
            { ISession s = Middleware.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT b.* FROM Task a, Employee b where a.Assignee = b.id group by a.Assignee order by count(a.Assignee) desc limit 5;");
                q.AddEntity(typeof(Employee));
                IList<Employee> allOfthem = q.List<Employee>();
                foreach (AssignmentIntern.Models.Employee d in allOfthem)
                {
                    employees.Add(new EmployeeView(d.Id,d.FullName,d.Email,d.PhoneNumber,d.DateOfBirth,d.MonthlySalary));
                }

                s.Close();
                
            }
            catch (Exception ec)
            {
            }

            return employees;
        }
       ///////////////////////////////////////////////////////////////////////////////////////////
        // 1.Create, read, update and delete an employee
        ///////////////////////////////////////////////////////////////////////////////////////////
        public static List<EmployeeView> readEmployees()
        {
            List<EmployeeView> employees = new List<EmployeeView>();
            try
            {
               ISession s = Middleware.GetSession();

                IEnumerable<AssignmentIntern.Models.Employee> allofthem = from o in s.Query<AssignmentIntern.Models.Employee>() select o;

                foreach (AssignmentIntern.Models.Employee d in allofthem)
                {
                    employees.Add(new EmployeeView(d.Id, d.FullName, d.Email, d.PhoneNumber,d.Department.Id, d.DateOfBirth, d.MonthlySalary));
                }

                s.Close();
            }
            catch (Exception ec)
            {
            }

            return employees;
        }
        public static EmployeeBasic readEmployee(int id)
        {
            EmployeeBasic empl = new EmployeeBasic();
            try
            {
                ISession s = Middleware.GetSession();
                Employee d = s.Load<Employee>(id);
                empl = new EmployeeBasic(d.Id, d.FullName, d.Email, d.PhoneNumber, d.DateOfBirth, d.MonthlySalary);

                s.Close();
            }
            catch (Exception ec)
            {
            }

            return empl;
        }
        public static void createEmployee(EmployeeBasic d)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Employee o = new AssignmentIntern.Models.Employee();
                o.Department = s.Load<Department>(d.Department.Id);
                o.FullName = d.FullName;
                o.Email = d.Email;
                o.DateOfBirth = d.DateOfBirth;
                o.MonthlySalary = d.MonthlySalary;
                o.PhoneNumber = d.PhoneNumber;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static EmployeeBasic updateEmployee(EmployeeBasic p)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Employee o = s.Load<AssignmentIntern.Models.Employee>(p.Id);
                o.FullName = p.FullName;
                o.Email = p.Email;
                o.DateOfBirth = p.DateOfBirth;
                o.MonthlySalary = p.MonthlySalary;
                o.PhoneNumber = p.PhoneNumber;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void deleteEmployee(int id)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Employee o = s.Load<AssignmentIntern.Models.Employee>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 1.Create, read, update and delete a task
        ///////////////////////////////////////////////////////////////////////////////////////////
        
        #region Task
        public static List<TaskView> readTasks()
        {
            List<TaskView> tasks = new List<TaskView>();
            try
            {
                ISession s = Middleware.GetSession();

                IEnumerable<AssignmentIntern.Models.Task> allofthem = from o in s.Query<AssignmentIntern.Models.Task>() select o;

                foreach (AssignmentIntern.Models.Task d in allofthem)
                {
                    tasks.Add(new TaskView(d.Id,d.Title,d.Description,d.Due_Date));
                }

                s.Close();
            }
            catch (Exception ec)
            {
            }

            return tasks;
        }
        public static TaskBasic readTask(int id)
        {
            TaskBasic empl = new TaskBasic();
            try
            {
                ISession s = Middleware.GetSession();
                AssignmentIntern.Models.Task d = s.Load<AssignmentIntern.Models.Task>(id);
                empl = new TaskBasic(d.Id,d.Title,d.Description,d.Due_Date);

                s.Close();
            }
            catch (Exception ec)
            {
            }

            return empl;
        }

        public static void createTask(TaskBasic d)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Task o = new AssignmentIntern.Models.Task();
                o.Assignee = s.Load<Employee>(d.Assignee.Id);
                o.Description = d.Description;
                o.Due_Date = d.Due_Date;
                o.Title = d.Title;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static TaskBasic updateTask(TaskBasic p)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Task o = s.Load<AssignmentIntern.Models.Task>(p.Id);
                o.Description = p.Description;
                o.Due_Date = p.Due_Date;
                o.Title = p.Title;
                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        public static void deleteTask(int id)
        {
            try
            {
                ISession s = Middleware.GetSession();

                AssignmentIntern.Models.Task o = s.Load<AssignmentIntern.Models.Task>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion
     
    }
}
