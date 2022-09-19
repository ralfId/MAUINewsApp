using Refit;

namespace MauiNewsApp.Api
{
    public interface IApiService
    {
        [Get("/top-headlines?token={apiKey}&lang=en&max=10&topic={category}")]
        Task<HttpResponseMessage> GetNewsByCategory(string apiKey, string category, int limit = 10);

    }
}
