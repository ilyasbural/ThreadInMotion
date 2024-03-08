namespace ThreadInMotion.Presentation.Controllers
{
	using Core;
	using RestSharp;
	using Newtonsoft.Json;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Configuration;

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
			RestRequest.RequestFormat = DataFormat.Json;
			RestRequest.AddJsonBody(Model);
			RestResponse = RestClient.Execute(RestRequest);
			string a = RestResponse.Content!;
			//Response<SetlirsSession> Response = JsonConvert.DeserializeObject<Response<SetlirsSession>>(RestResponse.Content!)!;

			//if (Response.Data.Email == Model.Email && Response.Data.Password == Model.Password)
			//{
			//	//RestRequest = new RestRequest("api/userdetailsingle", Method.Get);
			//	//RestRequest.RequestFormat = DataFormat.Json;
			//	//RestRequest.AddQueryParameter("Id", Response.Data.UserDetailId);
			//	//RestResponse = RestClient.Execute(RestRequest);
			//	//Response<SetlirsSession> a = JsonConvert.DeserializeObject<Response<SetlirsSession>>(RestResponse.Content!)!;


			//	HttpContext.Session.SetString("Email", Model.Email);
			//	HttpContext.Session.SetString("Password", Model.Password);
			//	//HttpContext.Session.SetString("Name", a.Collection.FirstOrDefault()!.Name);
			//	//HttpContext.Session.SetString("Lastname", a.Collection.FirstOrDefault()!.Lastname);
			//	return RedirectToAction("Index", "Home", new { Area = "user" });
			//         }

			return RedirectToAction("Index", "Home", new { Area = "User" });
		}
	}
}