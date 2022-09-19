namespace MauiNewsApp.ViewModels
{
    public partial class BaseVM : ObservableObject
    {

        [ObservableProperty]
         bool _isBusy;

        [ObservableProperty]
        string _title;

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
