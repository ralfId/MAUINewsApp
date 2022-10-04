using System;
namespace MauiNewsApp.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);
        Task GoBackAsync();
    }
}

