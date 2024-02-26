using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class UserRole
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }

        public string RoleId { get; set; }
        public AppRole Role { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
