using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShopApp.Controllers
{
	public class ProductsController : Controller
	{
		private ProductReader _reader;

		public ProductsController()
		{
			_reader = new ProductReader();
		}

		public IActionResult Products()
		{
			var products = _reader.ReadFromFile();

			return View(products);
		}

		public IActionResult Details(int id)
		{
			var products = _reader.ReadFromFile();
			var product = products.Where(p=>p.Id == id).FirstOrDefault();

			if(product == null)
			{
				return NotFound();
			}

			return View(product);
		}
	}
}
