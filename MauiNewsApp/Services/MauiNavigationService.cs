using System;

namespace MauiNewsApp.Services
{
    public class MauiNavigationService : INavigationService
    {
        
        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            return routeParameters != null
                ? Shell.Current.GoToAsync(route, routeParameters)
                : Shell.Current.GoToAsync(route);
        }

        public Task GoBackAsync()
        {
            return Shell.Current.GoToAsync("..");
        }

    }
}

