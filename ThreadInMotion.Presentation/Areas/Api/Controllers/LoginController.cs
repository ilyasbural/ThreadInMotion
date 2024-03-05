namespace ThreadInMotion.Presentation.Areas.Api.Controllers
{
    using Core;
    using Newtonsoft.Json;
    using Microsoft.AspNetCore.Mvc;
    using ThreadInMotion.SmartGlove.Sdk.Models.Glove;
    using ThreadInMotion.SmartGlove.Sdk.Interfaces.Glove;

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
		readonly ICommonService CommonService;
		readonly IDisplayGenerator DisplayGenerator;
		readonly IScreenGenerator ScreenGenerator;

		public LoginController(ICommonService commonService, IDisplayGenerator displayGenerator, IScreenGenerator screenGenerator)
		{
			CommonService = commonService;
			DisplayGenerator = displayGenerator;
			ScreenGenerator = screenGenerator;
		}

		[HttpPost]
		public async Task<Response<Display>> Login([FromBody] LoginDto Model)
		{
			Response<Display> Response = new Response<Display>() { Data = new Display() };

			//string Session = await RedisService.GetValueAsync(Model.Email);

			//if (String.IsNullOrEmpty(Session))
			//{
			//    Response<User> User = await UserService.SelectEmailPasswordAsync(new UserSelectDto { Email = Model.Email, Password = Model.Password });

			//    if (User.Collection.Count > 0)
			//    {
			//        Response<UserDetail> UserDetail = await UserDetailService.SelectByUserDetail(new UserDetailSelectDto { UserId = User.Collection.FirstOrDefault()!.Id });
			//        if (User.Collection.Count > 0)
			//        {
			//            SetlirsSession setlirsSession = new SetlirsSession();
			//            setlirsSession.Session = Guid.NewGuid();
			//            setlirsSession.Id = User.Collection.FirstOrDefault()!.Id;
			//            setlirsSession.Email = User.Collection.FirstOrDefault()!.Email;
			//            setlirsSession.Password = User.Collection.FirstOrDefault()!.Password;
			//            setlirsSession.UserDetailId = UserDetail.Collection.FirstOrDefault()!.Id;
			//            await RedisService.SetValueAsync(Model.Email, JsonConvert.SerializeObject(setlirsSession));
			//            Response.Data = setlirsSession;
			//        }
			//    }
			//}
			//else Response.Data = JsonConvert.DeserializeObject<SetlirsSession>(Session)!;

			return new Response<Display>
			{
				Success = 1,
				Message = "Success",
				Data = Response.Data,
				IsValidationError = true,
			};
		}
	}
}