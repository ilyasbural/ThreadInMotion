namespace ThreadInMotion.Service
{
	using Core;
	using Microsoft.Extensions.DependencyInjection;
    using ThreadInMotion.SmartGlove.Sdk.Services.Glove;
    using ThreadInMotion.SmartGlove.Sdk.Interfaces.Glove;

	public static class ServiceExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection Service)
        {
            Service.AddScoped<ICommonService, CommonService>();
            Service.AddScoped<IDisplayGenerator, DisplayGenerator>();
            Service.AddScoped<IScreenGenerator, ScreenGenerator>();
			Service.AddScoped<ILogin, LoginManager>();
			return Service;
        }
    }
}