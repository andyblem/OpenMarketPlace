using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarketPlace.Persistance.Seeders
{
    public class IdentityRolesSeeder
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager, List<IdentityRole> identityRoles)
        {
            foreach(IdentityRole identityRole in identityRoles)
            {
                await SeedRoleAsync(roleManager, identityRole);
            }
        }

        private static async Task<IdentityRole> SeedRoleAsync(RoleManager<IdentityRole> roleManager, IdentityRole identityRole)
        {
            //check if the role already exists
            bool roleCheck = await roleManager.RoleExistsAsync(identityRole.Name);

            //create the role if it doesn't exist
            IdentityResult identityResult = null;
            if (!roleCheck)
            {
                //create the role in the database and capture the result
                identityResult = await roleManager.CreateAsync(identityRole);

                //if creating the identity role is successful then return it
                //else return nothing
                if (identityResult.Succeeded)
                    return identityRole;
                else
                    return null;
            }
            else
            {
                //get the identity role from the database
                identityRole = await roleManager.FindByNameAsync(identityRole.Name);

                //return the result
                if (identityRole != null)
                    return identityRole;
                else
                    return null;
            }
        }
    }
}
