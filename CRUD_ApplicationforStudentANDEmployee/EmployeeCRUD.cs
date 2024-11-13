using System.Collections.Generic;

namespace CRUD_ApplicationforStudentANDEmployee
{
    public class EmployeeCRUD
    {
        private List<Employee> Employees;

        public EmployeeCRUD()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void ModifyEmployee(Employee emp)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == emp.Id)
                {
                    Employees[i].Name = emp.Name;
                    Employees[i].Salary = emp.Salary;
                    break;
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == id)
                {
                    Employees.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Employee> EmployeeList()
        {
            return Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (var emp in Employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
