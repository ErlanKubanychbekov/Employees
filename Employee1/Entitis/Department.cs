namespace Employees.Employees.Domain.Entitis;

public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Position> Positions { get; set; }
    }
