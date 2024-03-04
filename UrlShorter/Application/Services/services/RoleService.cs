using Application.Services.Interfaces;
using Domain.Models;
using Domain.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<IdentityResult> CreateRoleAsync(AppRole role)
        {
            return await _roleRepository.CreateRoleAsync(role);
        }

        public IEnumerable<AppRole> GetRoles()
        {
            return _roleRepository.GetRoles();
        }

        public async Task<bool> RoleExistsAsync(string roleName)
        {
            return await _roleRepository.RoleExistsAsync(roleName);
        }
    }
}
