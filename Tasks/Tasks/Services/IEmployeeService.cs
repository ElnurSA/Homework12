using System;
using Tasks.Models;

namespace Tasks.Services
{
	public interface IEmployeeService
	{
		List<Employee> GetEmployees();
		List<Employee> RangeOfBirhtday(DateTime startDate, DateTime endDate);
		List<Employee> RangeOfSalary();
	}
}

