using System;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Services
{
	public class EmployeeService : IEmployeeService
	{
        
		

        List<Employee> IEmployeeService.GetEmployees()
        {
            return AppDbContext.Employees();
        }

        List<Employee> IEmployeeService.RangeOfBirhtday(DateTime startDate, DateTime endDate)
        {
            return AppDbContext.Employees().Where(m => m.BirthDay > startDate && m.BirthDay < endDate).ToList();
        }

        List<Employee> IEmployeeService.RangeOfSalary()
        {
            return AppDbContext.Employees().Where(m => m.Salary > 2000).ToList();
        }
    }
}

