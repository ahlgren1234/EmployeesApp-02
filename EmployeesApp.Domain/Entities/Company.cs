﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domain.Entities;

public class Company
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }

    public string CompanyName { get; set; } = null!;

    public List<Employee> Employees { get; set; } = null!;


}
