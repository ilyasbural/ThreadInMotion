namespace ThreadInMotion.Presentation.Areas.User.Controllers
{
	using Core;
	using RestSharp;
	using Newtonsoft.Json;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Configuration;

	[Area("User")]
	public class MenuFourController : BaseController
	{
		public MenuFourController(IConfiguration configuration) : base(configuration) { }

		public IActionResult Index()
		{
			return View();
		}
	}
}