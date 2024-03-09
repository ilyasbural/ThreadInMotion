namespace ThreadInMotion.Presentation.Areas.Api.Controllers
{
    using Core;
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
			Response<Display> Response = new Response<Display>() { Data = new Display() };

			if (Model.Username == "ThreadInMotion" && Model.Password == "02129099846")
			{
				Response = await LoginManager.Login();
				Response.Success = 1;
				Response.Message = "Succesfully login";
			}

			else
			{
				Response.Success = 0;
				Response.Message = "Username or Password is not correct!";
			}

			return new Response<Display>
			{
				Success = Response.Success,
				Message = Response.Message,
				Data = Response.Data,
				IsValidationError = false,
			};
		}
	}
}