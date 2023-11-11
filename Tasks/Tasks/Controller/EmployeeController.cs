using System;
using Tasks.Services;

namespace Tasks.Controller
{
	public class EmployeeController
	{
		private readonly IEmployeeService _serivce;
		public EmployeeController()
		{
			_serivce = new EmployeeService();

		}

		public void GetByBirthdayRange(DateTime startDate, DateTime endDate)
		{
			var datas = _serivce.RangeOfBirhtday(startDate, endDate);
			int count = 0;
			foreach (var item in datas)
			{
				count++;
			}
			Console.WriteLine(count);
		}

		public void GetBySalary()
		{
			var datas = _serivce.RangeOfSalary();
			int count = 0;
			foreach (var item in datas)
			{
				count++;
			}
			Console.WriteLine(count);
		}
	}
}

