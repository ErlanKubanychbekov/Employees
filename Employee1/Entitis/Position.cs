namespace Employees.Employees.Domain.Entitis;

    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Salary> Salaries { get; set; }
        public Department Department { get; set; }

    }


