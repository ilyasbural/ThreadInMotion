namespace ThreadInMotion.Presentation.Areas.User.Controllers
{
	using Core;
	using RestSharp;
	using Newtonsoft.Json;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Configuration;

	[Area("User")]
	public class MenuTwoController : BaseController
	{
		public MenuTwoController(IConfiguration configuration) : base(configuration) { }

		public IActionResult Index()
		{
			return View();
		}
	}
}