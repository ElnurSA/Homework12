using System;
namespace Practice.Exceptions
{
	public class LessThanZero : Exception
	{
		public LessThanZero() : this("Cannot be less than zero!")
		{

		}
		public LessThanZero(string msj) : base(msj)
		{

		}
	}
}

