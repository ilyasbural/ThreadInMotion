namespace ThreadInMotion.Service
{
	using Core;
	using Newtonsoft.Json;
	using System.Threading.Tasks;
	using ThreadInMotion.SmartGlove.Sdk.Models.Glove;
	using ThreadInMotion.SmartGlove.Sdk.Models.Glove.Interfaces;

	public class LoginManager : ILogin
	{
		public LoginManager()
		{

		}

		public async Task<Response<Display>> Login()
		{
			//string json = @"{""indicator"":{},""mode"":5,""sleep"":0,""screen"":{""state"":""login"",""header"":""Login"",""body"":[[],[],[{""type"":""text"",""value"":""Username"",""font_no"": 2,""align"":""center""}],[{""type"":""input"",""id"":""username"",""font_no"":2,""align"":""center""}],[{""type"":""text"",""value"":""Password"",""font_no"":2,""align"":""center""}],[{""type"":""input"",""id"":""password"",""font_no"":2,""align"":""center""}],[],[{""type"":""button"",""id"":""changelang"",""name"":""Change Language"",""font_no"":2,""align"":""right"",""url"":""/api/login/languages""}]],""url"":""/api/login/authenticate""}}";

			//string json = @"{""indicator"":{},""mode"":5,""sleep"":0,""screen"":{""state"":""login"",""header"":""Login"",""body"":[[],[],[{""type"":""text"",""value"":""Username"",""font_no"": 2,""align"":""center""}],[{""type"":""input"",""id"":""username"",""font_no"":2,""align"":""center""}],[{""type"":""text"",""value"":""Password"",""font_no"":2,""align"":""center""}],[{""type"":""input"",""id"":""password"",""font_no"":2,""align"":""center""}],[],[{""type"":""button"",""id"":""changelang"",""name"":""Change Language"",""font_no"":2,""align"":""right"",""url"":""/api/login/languages""}]],""url"":""/api/login/authenticate""}}";

			Screen screen = new Screen();
			screen.State = "login";
			screen.Header = "Login";
			//screen.Body = new List<List<SmartGlove.Sdk.Models.Glove.Interfaces.IFormItem>> {			  };

			//IFormItem a;
			

			Display display = new Display();
			display.Mode = 5;
			display.Sleep = 0;
			display.Screen = screen;
			

			//Display b = JsonConvert.DeserializeObject<Display>(json)!;

			//Display b = JsonConvert.DeserializeObject<Display>(json)!;



			string a = JsonConvert.SerializeObject(display);



			Response<Display> response = new Response<Display>();
			response.Data = display;



			return response;
		}
	}
}