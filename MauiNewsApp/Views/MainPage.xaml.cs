using MauiNewsApp.ViewModels;

namespace MauiNewsApp;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageVM vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}

}

