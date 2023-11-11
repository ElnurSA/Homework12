using System;
namespace Tasks.Models
{
	public class Employee
	{
		public double Salary { get; set; }
		public DateTime BirthDay { get; set; } = new DateTime();
		public string FullName { get; set; }
	}
}

