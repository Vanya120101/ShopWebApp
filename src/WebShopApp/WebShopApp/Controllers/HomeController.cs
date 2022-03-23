using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using WebShopApp.Models;

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

		public IActionResult Cars()
		{
			var cars = new List<Car>();
			cars.Add(new Car { Id = 0, Name = "JuJu", Price = 555 });
			cars.Add(new Car { Id = 0, Name = "JuJu", Price = 555 });
			cars.Add(new Car { Id = 0, Name = "JuJu", Price = 555 });
			cars.Add(new Car { Id = 0, Name = "JuJu", Price = 555 });
			cars.Add(new Car { Id = 0, Name = "JuJu", Price = 555 });

			return View(cars);
		}

		public IActionResult Info()
		{
			foreach(var item in Request.Headers)
			{
				var str = item.ToString();
			}
			ViewBag.Ip = Request.HttpContext.Connection.LocalIpAddress;
			ViewBag.Browser = Request.Headers["User-Agent"].ToString();
			return View();
		}
	}
}
