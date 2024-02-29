using Domain.Context;
using Domain.Models;
using Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Domain.Repository
{
    public class OriginalUrlRepository : IOriginalUrlRepository
    {
        private readonly AppDbContext _context;

        public OriginalUrlRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddNewOriginalUrlsAsync(OriginalUrl originalUrl)
        {
           
            originalUrl.DateCreate = DateTime.Now;
            await _context.OriginalUrls.AddAsync(originalUrl);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteOriginalUrlsAsync(OriginalUrl originalUrl)
        {
            if (originalUrl == null)
                throw new ArgumentNullException(nameof(originalUrl));

            _context.OriginalUrls.Remove(originalUrl);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> GenerateShortNamesAsync()
        {
            try
            {
                var originalUrls = await _context.OriginalUrls.ToListAsync(); // Отримуємо всі посилання
                foreach (var originalUrl in originalUrls)
                {
                    // Генеруємо коротке ім'я на основі повного імені (можете змінити логіку генерації за своїми потребами)
                    originalUrl.ShortName = ReduceFullName(originalUrl.FullName);
                }
                await _context.SaveChangesAsync(); // Зберігаємо зміни у базі даних
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private string ReduceFullName(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                return string.Empty;

            return fullName.Substring(0, Math.Min(fullName.Length, 6));
        }


        public async Task<List<OriginalUrl>> GetAllOriginalUrlsAsync()
        {
            return await _context.OriginalUrls.ToListAsync();
        }

        public async Task<OriginalUrl> GetOriginalUrlsByIdAsync(int id)
        {
            return await _context.OriginalUrls.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateOriginalUrlsContentAsync(OriginalUrl originalUrl)
        {
            if (originalUrl == null)
                throw new ArgumentNullException(nameof(originalUrl));

            _context.OriginalUrls.Update(originalUrl);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
