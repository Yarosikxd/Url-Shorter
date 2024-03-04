using Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.Interfaces
{
    public interface IRoleService
    {
        Task<bool> RoleExistsAsync(string roleName);
        Task<IdentityResult> CreateRoleAsync(AppRole role);
        IEnumerable<AppRole> GetRoles();
    }
}
