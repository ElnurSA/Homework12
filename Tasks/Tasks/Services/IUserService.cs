using System;
using Tasks.Models;

namespace Tasks.Services
{
	public interface IUserService
	{
        List<Products> Login(string login, string password);
        List<Products> GetAll();
        List<Products> Search(string searchText);

    }
}

