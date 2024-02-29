using Domain.Models;

namespace Domain.Repository.Interfaces
{
    public interface IOriginalUrlRepository
    {
        Task<List<OriginalUrl>> GetAllOriginalUrlsAsync();
        Task<bool> AddNewOriginalUrlsAsync(OriginalUrl OriginalUrl);
        Task<OriginalUrl> GetOriginalUrlsByIdAsync(int id);
        Task<bool> UpdateOriginalUrlsContentAsync(OriginalUrl OriginalUrl);
        Task<bool> DeleteOriginalUrlsAsync(OriginalUrl OriginalUrl);
        Task<bool> GenerateShortNamesAsync();
    }
}
