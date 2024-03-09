namespace ThreadInMotion.Service
{
	using Core;
	using Newtonsoft.Json;
	using System.Threading.Tasks;
	using ThreadInMotion.SmartGlove.Sdk.Models.Glove;

	public class LoginManager : ILogin
	{
		public LoginManager()
		{

		}

		public async Task<Response<Display>> Login()
		{
			string json = @"{""indicator"":{},""mode"":5,""sleep"":0, ""url"": ""/api/login/authenticate"",""screen"":{""state"":""login"", ""header"":""Login""}, ""body"":[[],[],[{""type"":""text"",""value"":""Username"",""font_no"": 2,""align"":""center""}],[{""type"":""input"",""id"":""username"",""font_no"":2,""align"":""center""}],[{""type"":""text"",""value"":""Password"",""font_no"":2,""align"":""center""}],[{""type"":""input"",""id"":""password"",""font_no"":2,""align"":""center""}],[],[{""type"":""button"",""id"":""changelang"",""name"":""Change Language"",""font_no"":2,""align"":""right"",""url"":""/api/login/languages""}]]}";
			Display dataSource = JsonConvert.DeserializeObject<Display>(json)!;
			return new Response<Display>
			{
				Data = dataSource,
				IsValidationError = false,
			};
		}
	}
}