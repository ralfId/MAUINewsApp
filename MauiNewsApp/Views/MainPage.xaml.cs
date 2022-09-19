using MauiNewsApp.ViewModels;

namespace MauiNewsApp;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageVM viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}

