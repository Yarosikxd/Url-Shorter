using Domain.Context;
using Domain.Models;
using Domain.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Domain.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleRepository(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
        }
        public async Task<IdentityResult> CreateRoleAsync(AppRole role)
        {
            return await _roleManager.CreateAsync(role);
        }

        public IEnumerable<AppRole> GetRoles()
        {
            return _roleManager.Roles.ToList();
        }

        public async Task<bool> RoleExistsAsync(string roleName)
        {
            return await _roleManager.RoleExistsAsync(roleName);
        }
    }
}
