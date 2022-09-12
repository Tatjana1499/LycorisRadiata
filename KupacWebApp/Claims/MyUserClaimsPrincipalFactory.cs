using Domen;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KupacWebApp.Claims
{
    public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<Osoba, IdentityRole<int>>
    {


        public MyUserClaimsPrincipalFactory(UserManager<Osoba> userManager, RoleManager<IdentityRole<int>> roleManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, roleManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(Osoba user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("Ime", user.Ime));
            identity.AddClaim(new Claim("Prezime", user.Prezime));
            identity.AddClaim(new Claim("PhoneNumber", user.PhoneNumber));
            return identity;
        }
    }
}
