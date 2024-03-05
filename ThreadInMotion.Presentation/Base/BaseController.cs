namespace ThreadInMotion.Presentation
{
	using Core;
	using RestSharp;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Microsoft.AspNetCore.Mvc;

	public class BaseController : Controller
	{
		protected IConfiguration Configuration { get; set; }
		protected RestClient RestClient { get; set; } = null!;
		protected RestRequest RestRequest { get; set; } = null!;
		protected RestResponse RestResponse { get; set; } = null!;
		protected JObject JsonList { get; set; } = null!;

		public BaseController(IConfiguration configuration)
        {
			Configuration = configuration;
			RestClient = new RestClient(Configuration.GetSection("RestSettings").Get<RestSettings>()!.Path);
		}
	}
}