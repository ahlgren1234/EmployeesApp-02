using EmployeesApp.Infrastructure.Persistance;
using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class EmployeeRepository(ApplicationContext context) : IEmployeeRepository
    {
        public async Task AddAsync(Employee employee)
        {
           await context.Employees.AddAsync(employee);
           await context.SaveChangesAsync(); // Inte glömma!
        }

        //Classic C# syntax for GetAll()
        //public async Task<Employee[]> GetAllAsync() => [.. context.Employees];

        public async Task<Employee[]> GetAllAsync()
        {
            var query = context.Employees
                .AsNoTracking()
                .Include(o => o.Company);
            return await query.ToArrayAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id) => await context.Employees
            .FindAsync(id);
    }
}