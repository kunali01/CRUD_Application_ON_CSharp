using System;
using System.Collections.Generic;

namespace CRUD_ApplicationforStudentANDEmployee
{
    internal class EmployeeMain
    {
        static void Main(string[] args)
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            try
            {
                int a = 1;
                do
                {
                    Console.WriteLine("1.Employee List");
                    Console.WriteLine("2.Add Employee");
                    Console.WriteLine("3.Modify Employee");
                    Console.WriteLine("4.Delete Employee");
                    Console.WriteLine("5.Get Employee By Id");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Employee> employees = crud.EmployeeList();
                            Console.WriteLine("Id    Name    Salary");
                            foreach (var employee in employees)  // Renamed to 'employee'
                            {
                                Console.WriteLine(employee);
                            }
                            break;
                        case 2:
                            Employee e1 = new Employee();
                            Console.WriteLine("Enter Id");
                            e1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            e1.Name = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            e1.Salary = Convert.ToInt32(Console.ReadLine());
                            crud.AddEmployee(e1);
                            Console.WriteLine("Added the employee");
                            break;
                        case 3:
                            Employee e2 = new Employee();
                            Console.WriteLine("Enter existing Id");
                            e2.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name");
                            e2.Name = Console.ReadLine();
                            Console.WriteLine("Enter new Salary");
                            e2.Salary = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyEmployee(e2);
                            Console.WriteLine("Updated the employee");
                            break;
                        case 4:
                            Console.WriteLine("Enter existing Id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteEmployee(id);
                            Console.WriteLine("Deleted the employee");
                            break;
                        case 5:
                            Console.WriteLine("Enter existing Id");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Employee employeeById = crud.GetEmployeeById(id2); 
                            if (employeeById != null)
                                Console.WriteLine(employeeById);
                            else
                                Console.WriteLine("Employee not found.");
                            break;
                    }
                    Console.WriteLine("Press 1 to continue or 0 to exit");
                    a = Convert.ToInt32(Console.ReadLine());
                } while (a == 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
