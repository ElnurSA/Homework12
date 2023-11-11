using System;
namespace Practice.Services
{
	internal interface IProductService
	{
		List<Product> GetAll();
		Product GetById(int id);
		List<Product> GetAllByDescending();
	}
}

