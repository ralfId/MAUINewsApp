using MauiNewsApp.Api;
using MauiNewsApp.ViewModels;
using Refit;

namespace MauiNewsApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();


		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//register services
		builder.Services.AddSingleton<IApiServiceManager, ApiService>();

		//registere view models
		builder.Services.AddSingleton<BaseVM>();
		builder.Services.AddSingleton<MainPageVM>();

		//register pages
		builder.Services.AddSingleton<MainPage>();


		return builder.Build();
	}
}
