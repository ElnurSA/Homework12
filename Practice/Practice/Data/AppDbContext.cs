 Lusing System;
namespace Practice.Data
{
	public static class AppDbContext
	{
        public static List<Product> products()
		{
			return new List<Product>()
			{
				new Product
				{
					Id = 1,
					Name = "Nokia",
					Price = 300
				},

                new Product
                {
                    Id = 2,
                    Name = "Samsung",
                    Price = 2000
                },

                new Product
                {
                    Id = 3,
                    Name = "iPhone",
                    Price = 3000
                }
            };

		}
	}
}

