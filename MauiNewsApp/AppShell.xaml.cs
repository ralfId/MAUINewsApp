using MauiNewsApp.Views;

namespace MauiNewsApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NewsDetailPage), typeof(NewsDetailPage));
	}
}
