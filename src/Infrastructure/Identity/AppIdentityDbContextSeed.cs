using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));

            var demoUser = new ApplicationUser()
            {
                UserName = "demouser@example.com",
                Email = "demouser@example.com",
                EmailConfirmed = true
            };
            await userManager.CreateAsync(demoUser, "P@ssword1");

            var adminUser = new ApplicationUser()
            {
                UserName = "admin@example.com",
                Email = "admin@example.com",
                EmailConfirmed = true
            };
            await userManager.CreateAsync(adminUser, "P@ssword1");
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }
}
