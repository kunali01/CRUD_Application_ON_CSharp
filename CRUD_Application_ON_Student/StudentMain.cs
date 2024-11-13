using CRUD_Application_ON_Student;
using System;
using System.Collections.Generic;

namespace CRUD_ApplicationforStudentANDEmployee
{
    internal class StudentMain
    {
        static void Main(string[] args)
        {
            StudentCRUD crud = new StudentCRUD();
            try
            {
                int a = 1;
                do
                {
                    Console.WriteLine("1.Student List");
                    Console.WriteLine("2.Add Student");
                    Console.WriteLine("3.Modify Student");
                    Console.WriteLine("4.Delete Student");
                    Console.WriteLine("5.Get Student By Id");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Student> students = crud.StudentList();
                            Console.WriteLine("Id    Name    Marks");
                            foreach (var student in students) // Renamed to 'student'
                            {
                                Console.WriteLine(student);
                            }
                            break;
                        case 2:
                            Student s1 = new Student();
                            Console.WriteLine("Enter Id");
                            s1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            s1.Name = Console.ReadLine();
                            Console.WriteLine("Enter Marks");
                            s1.Marks = Convert.ToInt32(Console.ReadLine());
                            crud.AddStudent(s1);
                            Console.WriteLine("Added the student");
                            break;
                        case 3:
                            Student s2 = new Student();
                            Console.WriteLine("Enter existing Id");
                            s2.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name");
                            s2.Name = Console.ReadLine();
                            Console.WriteLine("Enter new Marks");
                            s2.Marks = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyStudent(s2);
                            Console.WriteLine("Updated the student");
                            break;
                        case 4:
                            Console.WriteLine("Enter existing Id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteStudent(id);
                            Console.WriteLine("Deleted the student");
                            break;
                        case 5:
                            Console.WriteLine("Enter existing Id");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Student studentById = crud.GetStudentById(id2);
                            if (studentById != null)
                                Console.WriteLine(studentById);
                            else
                                Console.WriteLine("Student not found.");
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
