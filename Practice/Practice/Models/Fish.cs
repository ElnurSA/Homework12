using System;
namespace Practice.Models
{
	public class Fish : Animal
	{
		public string Scale { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Fish sound=");
        }
    }
}

