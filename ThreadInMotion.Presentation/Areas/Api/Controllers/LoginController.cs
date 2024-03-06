namespace ThreadInMotion.Presentation.Areas.Api.Controllers
{
    using Core;
	using NuGet.Protocol;
    using Microsoft.AspNetCore.Mvc;
    using ThreadInMotion.SmartGlove.Sdk.Models.Glove;
    using ThreadInMotion.SmartGlove.Sdk.Interfaces.Glove;

	[ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
		readonly ILogin LoginManager;
		readonly ICommonService CommonService;
		readonly IDisplayGenerator DisplayGenerator;
		readonly IScreenGenerator ScreenGenerator;

		public LoginController(ILogin login, ICommonService commonService, IDisplayGenerator displayGenerator, IScreenGenerator screenGenerator)
		{
			LoginManager = login;
			CommonService = commonService;
			DisplayGenerator = displayGenerator;
			ScreenGenerator = screenGenerator;
		}

		[HttpPost]
		public async Task<Response<Display>> Login([FromBody] LoginDto Model)
		{
			int success = 0; string successMessage = String.Empty;		
			Response<Display> Response = new Response<Display>() { Data = new Display() };

			if (Model.Username == "ThreadInMotion" && Model.Password == "02129099846")
			{
				success = 1;
				successMessage = "Succesfully login";
				Response = await LoginManager.Login();
				Response.Data.ToJson();
			}

			else
			{
				success = 0;
				successMessage = "Username or Password is not correct!";
			}

			return new Response<Display>
			{
				Success = success,
				Message = successMessage,
				Data = Response.Data,
				IsValidationError = false,
			};
		}
	}
}