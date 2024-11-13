namespace CRUD_ApplicationforStudentANDEmployee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} , {Name} , {Salary}";
        }
    }
}
