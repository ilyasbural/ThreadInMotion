namespace ThreadInMotion.Core
{
    public interface ILogin
    {
		Task<Response<SmartGlove.Sdk.Models.Glove.Display>> Login();
	}
}