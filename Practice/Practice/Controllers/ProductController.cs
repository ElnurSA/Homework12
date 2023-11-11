Iusing System;
using Practice.Services;

namespace Practice.Controllers
{
	public class ProductController
	{
		private readonly IProductService _service;
		public ProductController()
		{
			_service = new ProductService();
		}
		public void GetAll()
		{
			var datas = _service.GetAll();

			foreach (var item in datas)
			{
				Console.WriteLine(item.Name + " - " + item.Price);
			}
		}

		public void GetById()
		{
			var data = _service.GetById(2);
			Console.WriteLine(data.Name + " - " + data.Price);
		}

		public void Sorting()
		{
            var datas = _service.GetAllByDescending();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + " - " + item.Price);
            }
        }
	}
}

