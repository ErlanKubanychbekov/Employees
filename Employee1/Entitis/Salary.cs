namespace Employees.Employees.Domain.Entitis
{

    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public decimal Amount { get; set; }
        public Employee Employee { get; set; }
        public Position Position { get; set; }
    }
}
