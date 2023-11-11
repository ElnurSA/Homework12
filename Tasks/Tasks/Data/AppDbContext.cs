using System;
using Tasks.Models;

namespace Tasks.Data
{
	public class AppDbContext
	{
		public static List<Author> Authors()
		{
			return new List<Author>()
			{
				new Author
				{
					Age = 55,
					FullName = "Aleksandr Pushkin"
				},

                new Author
                {
                    Age = 45,
                    FullName = "Mark Twain"
                },

                new Author
                {
                    Age = 35,
                    FullName = "Fedor Dostoyevskiy"
                },
            };
		}

		public static List<Employee> Employees()
		{
			return new List<Employee>()
			{
				new Employee
				{
					BirthDay = new DateTime(1996, 06, 12),
					Salary = 1000,
					FullName = "Toghrul Alakbarov"
				},
                new Employee
                {
                    BirthDay = new DateTime(1986, 07, 22),
                    Salary = 6000,
                    FullName = "Ali Jafarov"
                },
                new Employee
                {
                    BirthDay = new DateTime(2003, 10, 02),
                    Salary = 10000,
                    FullName = "Mehemmed Akhundov"
                },
            };
		
		}

		public static List<User> LoginData()
		{
			return new List<User>()
			{
				new User
				{
					Email = "elnurms@code.edu.az",
					Password = "123"
				},
                new User
                {
                    Email = "togrulms@code.edu.az",
                    Password = "123"
                },
                new User
                {
                    Email = "alims@code.edu.az",
                    Password = "123"
                }
            };
		}

        public static List<Products> Products()
        {
            return new List<Products>()
            {
                new Products
                {
                    Name = "Iphone",
                    Price = 3000
                },

                new Products
                {
                    Name = "Samsung",
                    Price = 2000
                },

                new Products
                {
                    Name = "Nokia",
                    Price = 300
                }
            };
        }
	}
}

