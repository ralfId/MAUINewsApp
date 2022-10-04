using MauiNewsApp.Api;
using MauiNewsApp.Helpers;
using MauiNewsApp.Models;
using MauiNewsApp.Models.AppModels;
using System.Collections.ObjectModel;
using static Microsoft.Maui.Controls.Internals.Profile;

namespace MauiNewsApp.ViewModels
{
    public partial class MainPageVM : BaseVM
    {
        private IApiServiceManager _apiService;
        public MainPageVM(IApiServiceManager apiService)
        {
            _apiService = apiService;
            Init();
        }

        private async void Init()
        {
            LoadCategoriesSources();
            await GetNewsCommand.ExecuteAsync(Ob_Categories.FirstOrDefault());
        }

        public List<Category> CategoriesLst = new List<Category>();

        [ObservableProperty]
        ObservableCollection<Category> ob_Categories;

        [ObservableProperty]
        ObservableCollection<Article> ob_News;

        [ObservableProperty]
        bool _isCategoryOrSource;

        [ObservableProperty]
        Article _articleNews;

        [ObservableProperty]
        string _selectedCategory;

        public void LoadCategoriesSources()
        {

            CategoriesLst = OptionsList.GetCategories();
            CategoriesLst[0].IsSelected = true;
            Ob_Categories = new ObservableCollection<Category>(CategoriesLst);
        }


        [RelayCommand]
        public async Task GetNews(Category category)
        {
            SetSegmentedControl(category);
            


            var newsData = await _apiService.GetNewsByCategory(category.name);
            var data = newsData.ToList();

            ArticleNews = data.FirstOrDefault();
            data.RemoveAt(0);
            Ob_News = new ObservableCollection<Article>(data);

        }

        private void SetSegmentedControl(Category category)
        {
            var oldCateg = Ob_Categories.Where(x => x.IsSelected == true).FirstOrDefault();

            var oldSelecction = oldCateg;
            oldSelecction.IsSelected = false;

            var newSelecction = category;
            newSelecction.IsSelected = true;

            Ob_Categories[Ob_Categories.IndexOf(oldCateg)] = oldSelecction;
            Ob_Categories[Ob_Categories.IndexOf(category)] = newSelecction;

        }
    }
}
