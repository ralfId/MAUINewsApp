using MauiNewsApp.Models;

namespace MauiNewsApp.Api
{
    public interface IApiServiceManager
    {
        Task<IEnumerable<Article>> GetNewsByCategory(string category, int limit = 10);
    }
}
