using dotnetCore7EmployeeAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore7EmployeeAPI.Infraestrutura;

public class ConnectionContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=employeeapi" +
            "User Id=postgres;" +
            "Password=postgres;"
            );
}