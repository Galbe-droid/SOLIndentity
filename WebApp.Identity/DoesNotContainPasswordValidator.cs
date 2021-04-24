using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Identity
{
    public class DoesNotContainPasswordValidator<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            var username = await manager.GetUserNameAsync(user);

            if(username == password)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Password cannot be the same as user name"});
            }
            if(password.Contains("password"))
            {
                return IdentityResult.Failed(new IdentityError { Description = "Password cannot be password" });
            }

            return IdentityResult.Success;
        }
    }
}
