
namespace Domain.Models
{
    public class ShortUrl
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public OriginalUrl OriginalUrl { get; set; }
        DateTime DataCreate {  get; set; }
    }
}
