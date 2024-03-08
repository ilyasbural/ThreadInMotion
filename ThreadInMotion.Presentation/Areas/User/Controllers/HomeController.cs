namespace ThreadInMotion.Presentation.Areas.User.Controllers
{
	using Core;
	using RestSharp;
	using Newtonsoft.Json;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Configuration;

	[Area("User")]
	public class HomeController : BaseController
	{
		public HomeController(IConfiguration configuration) : base(configuration) { }

		public IActionResult Index()
		{
			

			return View();
		}
	}
}