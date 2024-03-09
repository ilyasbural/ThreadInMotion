namespace ThreadInMotion.Presentation.Controllers
{
	using Core;
	using RestSharp;
	using Newtonsoft.Json;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Configuration;
	using ThreadInMotion.SmartGlove.Sdk.Models.Glove;

	public class LoginController : BaseController
	{
		public LoginController(IConfiguration configuration) : base(configuration) { }

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(LoginViewModel Model)
		{
			RestRequest = new RestRequest("api/login", Method.Post);
			RestRequest.AddJsonBody(Model);
			RestRequest.RequestFormat = DataFormat.Json;
			RestResponse = RestClient.Execute(RestRequest);
			Response<Display> Response = JsonConvert.DeserializeObject<Response<Display>>(RestResponse.Content!)!;

			if (Response.Success == 1) return RedirectToAction("Index", "Home", new { Area = "User" });
			else return RedirectToAction("Index", "Home");
		}
	}
}