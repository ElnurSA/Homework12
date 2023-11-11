using System;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Services
{
    public class UserService : IUserService
    {
        public List<Products> GetAll()
        {
            return AppDbContext.Products();
        }

        public List<Products> Search(string searchText)
        {
            return AppDbContext.Products().Where(m => m.Name.Contains(searchText)).ToList();
        }

        List<Products> IUserService.Login(string login, string password)
        {
           List <Products> result = new List<Products>();
            var datas = AppDbContext.LoginData();
            foreach (var item in datas)
            {
                if (item.Email == login && item.Password == password)
                {
                    Console.WriteLine("Choose 1 or 2");
                    var input = Console.ReadLine().ToString();

                    if(input == "1")
                    {
                        result = GetAll();
                    }
                    else if(input == "2")
                    {
                        Console.WriteLine("Search products:");
                        var search = Console.ReadLine().ToString();

                        result = Search(search);
                    }
                    else
                    {
                        continue;
                    }

                    break;
                   
                    
                }
            }

            return result;

            //return AppDbContext.LoginData().Where(m => m.Email == login && m.Password == password).ToList();
        }
    }
}

