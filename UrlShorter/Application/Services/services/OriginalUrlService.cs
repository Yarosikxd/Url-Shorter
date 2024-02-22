using Application.Services.Interfaces;
using Domain.Context;
using Domain.Models;
using Domain.Repository;
using Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.services
{
    public class OriginalUrlService : IOriginalUrlService
    {
        private readonly IOriginalUrlRepository _repository;
        public OriginalUrlService(IOriginalUrlRepository repository)
        {
            _repository = repository;
        }
      
        public async Task<bool> AddNewOriginalUrlsAsync(OriginalUrl originalUrl)
        {
           return await _repository.AddNewOriginalUrlsAsync(originalUrl);
        }
        public async Task<bool> DeleteOriginalUrlsAsync(OriginalUrl originalUrl)
        {
            return await _repository.DeleteOriginalUrlsAsync(originalUrl);
        }

        public async Task<List<OriginalUrl>> GetAllOriginalUrlsAsync()
        {
            return await _repository.GetAllOriginalUrlsAsync();
        }

        public async Task<OriginalUrl> GetOriginalUrlsByIdAsync(int id)
        {
            return await _repository.GetOriginalUrlsByIdAsync(id);
        }

        public async Task<bool> UpdateOriginalUrlsContentAsync(OriginalUrl originalUrl)
        {
            return await _repository.UpdateOriginalUrlsContentAsync(originalUrl);
        }
    }
}
