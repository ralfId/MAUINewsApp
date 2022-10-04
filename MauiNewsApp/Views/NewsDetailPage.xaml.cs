using MauiNewsApp.ViewModels;

namespace MauiNewsApp.Views;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailPageVM vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}
