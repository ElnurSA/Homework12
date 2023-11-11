using System;
using Tasks.Models;

namespace Tasks.Services
{
	public interface IAuthorService
	{
		List<Author> GetAll();
		List<Author> OlderThan40();
	}
}

