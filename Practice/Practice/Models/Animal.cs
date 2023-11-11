using System;
namespace Practice.Models
{
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual void Sound()
		{
			Console.WriteLine("Animal Sound");
		}
	}
}

