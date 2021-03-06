﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace MIS442_Store.Models
{
    public class ApplicationRole : IdentityRole
    {
        public async Task<IdentityResult> GenerateRoleAsync(RoleManager<ApplicationRole> manager)
        {
            var roleIdentity = await manager.CreateAsync(this);
            return roleIdentity;
        }
    }
}