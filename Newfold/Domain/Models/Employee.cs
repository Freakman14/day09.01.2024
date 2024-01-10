namespace Domain.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salsry { get; set; }
    public Department Department { get; set; }
}
