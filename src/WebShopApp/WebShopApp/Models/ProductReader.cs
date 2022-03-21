using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WebShopApp
{
	public class ProductReader
	{
		private readonly string path = "AppData/data.txt";
		public ProductReader()
		{
		}

		public IEnumerable<Product> ReadFromFile()
		{
			string[] lines = File.ReadAllLines(path);

			List<Product> products = new List<Product>();

			foreach(var line in lines)
			{
				string[] items = line.Split(',');

				Product product = new Product();
				product.Id = Convert.ToInt32(items[0].Trim());
				product.Name = Convert.ToString(items[1].Trim());
				product.Price = Convert.ToDouble(items[2].Trim());
				product.Description = Convert.ToString(items[3].Trim());
				product.Count = Convert.ToInt32(items[4].Trim());
				product.Category = Convert.ToString(items[5].Trim());

				products.Add(product);
			}

			return products;
		}
	}
}