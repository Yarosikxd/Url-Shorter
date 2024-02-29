using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class OriginalUrl
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public DateTime DateCreate { get; set; }
        public string NameUserCreated { get; set; }
       
        [NotMapped]
        public int UserId { get; set; }
    }
}
