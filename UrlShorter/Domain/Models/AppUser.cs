using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Domain.Models
{
    public class AppUser : IdentityUser<string>
    {
     
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
