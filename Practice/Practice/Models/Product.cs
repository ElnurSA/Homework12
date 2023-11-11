using System;
using Practice.Models;

namespace Practice
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}
}

