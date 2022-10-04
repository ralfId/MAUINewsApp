using MauiNewsApp.Api;
using MauiNewsApp.Services;
using MauiNewsApp.ViewModels;
using MauiNewsApp.Views;
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
				fonts.AddFont("boxicons.ttf", "BI");
			});

		//register services
		builder.Services.AddSingleton<INavigationService, MauiNavigationService>();
		builder.Services.AddSingleton<IApiServiceManager, ApiService>();

		//registere view models
		builder.Services.AddSingleton<BaseVM>();
		builder.Services.AddSingleton<MainPageVM>();
		builder.Services.AddSingleton<NewsDetailPageVM>();

        //register pages
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<NewsDetailPage>();


        return builder.Build();
	}
}
