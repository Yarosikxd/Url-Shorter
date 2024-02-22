using Domain.Models;

namespace Application.Services.Interfaces
{
    public interface IOriginalUrlService
    {
        Task<List<OriginalUrl>> GetAllOriginalUrlsAsync();
        Task<bool> AddNewOriginalUrlsAsync(OriginalUrl OriginalUrl);
        Task<OriginalUrl> GetOriginalUrlsByIdAsync(int id);
        Task<bool> UpdateOriginalUrlsContentAsync(OriginalUrl OriginalUrl);
        Task<bool> DeleteOriginalUrlsAsync(OriginalUrl OriginalUrl);
    }
}
