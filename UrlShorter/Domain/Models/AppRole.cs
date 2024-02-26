using Microsoft.AspNetCore.Identity;


namespace Domain.Models
{
    public class AppRole : IdentityRole<string>
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
