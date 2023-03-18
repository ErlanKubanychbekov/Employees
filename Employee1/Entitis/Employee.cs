namespace Employees.Employees.Domain.Entitis;

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public List<Salary> Salaries { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
    }


