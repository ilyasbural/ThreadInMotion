namespace ThreadInMotion.Service
{
    using Microsoft.Extensions.DependencyInjection;
    using ThreadInMotion.SmartGlove.Sdk.Services.Glove;
    using ThreadInMotion.SmartGlove.Sdk.Interfaces.Glove;

    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection Service)
        {
			//Service.AddScoped<IAlertGenerator, AlertGenerator>();
            Service.AddScoped<ICommonService, CommonService>();
            Service.AddScoped<IDisplayGenerator, DisplayGenerator>();
            Service.AddScoped<IScreenGenerator, ScreenGenerator>();

            return Service;
        }
    }
}