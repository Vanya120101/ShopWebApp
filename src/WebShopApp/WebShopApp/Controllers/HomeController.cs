using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace WebShopApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult DownloadFile()
		{
			string path = Path.Combine(Environment.CurrentDirectory, "wwwroot", "001. Introduction.pdf");
			byte[] data = System.IO.File.ReadAllBytes(path);
			return File(data, "application/octet-stream", "lesson.pdf");
		}
	}
}
