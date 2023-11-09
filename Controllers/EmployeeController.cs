using dotnetCore7EmployeeAPI.Model;
using dotnetCore7EmployeeAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dotnetCore7EmployeeAPI.Controllers;

[ApiController]
[Route("api/v1/empoyee")]
public class EmployeeController : ControllerBase
{
    private readonly iEmployeeRepository _employeeRepository;

    public EmployeeController(iEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository ?? throw new ArgumentNullException();
    }

    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {
        var employee = new Employee(employeeViewModel.Name, employeeViewModel.Age, null);
        _employeeRepository.Add(employee);
        return Ok();
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        var employees = _employeeRepository.Get();
        return Ok(employees);
    }
    
}