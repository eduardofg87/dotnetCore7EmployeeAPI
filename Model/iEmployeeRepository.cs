namespace dotnetCore7EmployeeAPI.Model;

public interface iEmployeeRepository
{
    void Add(Employee employee);

    List<Employee> Get();
}