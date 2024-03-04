
using Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Domain.Repository.Interfaces
{
    public interface IRoleRepository
    {
        Task<bool> RoleExistsAsync(string roleName);
        Task<IdentityResult> CreateRoleAsync(AppRole role);
        IEnumerable<AppRole> GetRoles();
    }
}
