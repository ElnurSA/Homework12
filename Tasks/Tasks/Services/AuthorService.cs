using System;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Services
{
	public class AuthorService : IAuthorService
	{
		

        public List<Author> GetAll()
        {
            return AppDbContext.Authors();
        }

        public List<Author> OlderThan40()
        {
            return AppDbContext.Authors().Where(m => m.Age >= 40).ToList();
        }
    }
}

