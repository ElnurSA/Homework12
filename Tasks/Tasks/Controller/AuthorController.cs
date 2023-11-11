using System;
using Tasks.Data;
using Tasks.Services;

namespace Tasks.Controller
{
	public class AuthorController
	{
		private readonly IAuthorService _service;

		public AuthorController()
		{
			_service = new AuthorService();
		}

		public void GetOlderThan40()
		{
			var datas = _service.OlderThan40();

			foreach (var item in datas)
			{
				Console.WriteLine(item.FullName);
			}
		}
	}
}

