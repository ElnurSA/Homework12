using System;
using Tasks.Services;

namespace Tasks.Controller
{
	public class UserController
	{
		private readonly IUserService _service;

		public UserController()
		{
			_service = new UserService();
		}

		public void Login()
		{
			Console.WriteLine("Enter your email:");
			var email = Console.ReadLine();
			Console.WriteLine("Enter your password");
			var password = Console.ReadLine();

			var datas = _service.Login(email, password);

			foreach (var item in datas)
			{
				Console.WriteLine(item.Name);
			}

			
		}

	}
}

