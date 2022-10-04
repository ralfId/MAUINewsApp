using System;
using MauiNewsApp.Models;
using MauiNewsApp.Services;

namespace MauiNewsApp.ViewModels
{
    [QueryProperty(nameof(Article), nameof(article))]
    public partial class NewsDetailPageVM : BaseVM
    {
        private readonly INavigationService _navigationService;

        public NewsDetailPageVM(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [ObservableProperty]
        Article article;
    }
}

