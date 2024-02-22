using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Domain.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {   
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-68LLRBR;Initial Catalog=UrlShorter;Integrated Security=True;Trust Server Certificate=True;Encrypt=False");
        }

        public DbSet<OriginalUrl> OriginalUrls { get; set; }
        public DbSet<ShortUrl> ShortUrls { get; set; }
    }
}
