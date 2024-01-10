using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentServices
{
    List<Department> dep = new List<Department>();
    public List<Department> GetEmployees()
    {
        return dep;
    }
    public void AddEmployees(Department department)
    {
        dep.Add(department);
    }
    public int CountEmployees()
    {
        int kol = 0;
        foreach (var item in dep)
        {
            kol++;
        }
        return kol;
    }
}
