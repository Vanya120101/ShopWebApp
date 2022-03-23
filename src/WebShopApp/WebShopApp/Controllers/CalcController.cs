using Microsoft.AspNetCore.Mvc;

namespace WebShopApp.Controllers
{
	public class CalcController : Controller
	{
		public int Add(int x, int y)
		{
			return x + y;
		}

		public int Mul(int a, int b)
		{
			return a * b;
		}

		public int Div(int a, int b)
		{
			return a / b;
		}

		public int Sub(int a, int b)
		{
			return a - b;
		}

		public int Use(int x, int y, string operation)
		{
			if(operation == "+")
			{
				return Add(x, y);
			}
			if(operation == "-")
			{
				return Sub(x, y);
			}
			if(operation == "*")
			{
				return Mul(x, y);
			}
			if(operation == "/")
			{
				return Div(x, y);
			}
			return 0;
		}


		public IActionResult ViewCalc()
		{
			return View("Show");
		}
	}
}
