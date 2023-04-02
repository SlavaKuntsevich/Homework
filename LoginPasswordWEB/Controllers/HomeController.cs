using LoginPasswordWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginPasswordWEB.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult LoginError()
		{
			return NotFound("Ошибка. Неправильно введен логин или пароль");
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public RedirectResult Login(string username, string password)
		{
			string startUsername = "admin";
			string startPassword = "abc123";
			if (startUsername.Equals(username) && startPassword.Equals(password))
			{
				return Redirect("~/Home/Index");
			}
			else return Redirect("~/Home/LoginError");
		}
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}