using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeServices : Employee
{
    List<Employee> emp = new List<Employee>();
    public List<Employee> GetEmployees()
    {
        return emp;
    }
    public void AddEmployees(Employee employee)
    {
        emp.Add(employee);
    }
    public int CountEmployees()
    {
        int kol = 0;
        foreach (var item in emp)
        {
            kol++;
        }
        return kol;
    }

}
