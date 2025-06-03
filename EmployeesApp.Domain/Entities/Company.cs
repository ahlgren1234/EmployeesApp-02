using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domain.Entities;

public class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public Employee[] Employees { get; set; } = null!;


}
