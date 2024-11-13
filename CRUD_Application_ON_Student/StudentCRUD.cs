using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application_ON_Student
{
    public class StudentCRUD
    {
        List<Student> Students;

        public StudentCRUD()
        {
            Students = new List<Student>(); // Initialize an empty list of students
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void ModifyStudent(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == student.Id)
                {
                    Students[i].Name = student.Name;
                    Students[i].Marks = student.Marks;
                    break;
                }
            }
        }

        public void DeleteStudent(int id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == id)
                {
                    Students.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Student> StudentList()
        {
            return Students;
        }

        public Student GetStudentById(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

    }
}
