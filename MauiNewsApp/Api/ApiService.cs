using MauiNewsApp.Api;
using MauiNewsApp.Helpers;
using MauiNewsApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiNewsApp.Api
{
    public class ApiService : IApiServiceManager
    {
        IApiService _apiService;

        public ApiService()
        {
            _apiService = RestService.For<IApiService>(Constants.BaseUrl);
        }

        public async Task<IEnumerable<Article>> GetNewsByCategory(string category, int limit = 10)
        {
            try
            {
                var response = await _apiService.GetNewsByCategory(Constants.ApiKey, category, limit);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<News>();

                    return data.articles.Select( x =>  new Article
                    {
                        title = x.title,
                        description = x.description,
                        content = x.content.Substring(0, x.content.IndexOf("[")),
                        url = x.url,
                        image = x.image,
                        publishedAt = x.publishedAt,
                        source = x.source
                    });
                }

                return default;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return default;
            }
        }

    }
}
