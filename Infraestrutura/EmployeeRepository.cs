using dotnetCore7EmployeeAPI.Model;

namespace dotnetCore7EmployeeAPI.Infraestrutura;

public class EmployeeRepository: iEmployeeRepository
{
    private readonly ConnectionContext _context = new ConnectionContext();
    
    public void Add(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public List<Employee> Get()
    {
        return _context.Employees.ToList();
    }
}