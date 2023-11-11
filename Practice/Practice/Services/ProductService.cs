using System;
using Practice.Data;

namespace Practice.Services
{
	public class ProductService : IProductService
	{
        public List<Product> GetAllByDescending()
        {
            return AppDbContext.products().OrderByDescending(m => m.Price).ToList();
        }

        List<Product> IProductService.GetAll()
        {
            return AppDbContext.products();
        }

        Product IProductService.GetById(int id)
        {
            return AppDbContext.products().FirstOrDefault(m=>m.Id == id);
        }
    }
}