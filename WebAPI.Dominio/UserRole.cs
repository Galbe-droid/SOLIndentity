using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Dominio
{
    public class UserRole : IdentityUserRole<int>
    {
        public User user { get; set; }
        public Role role { get; set; }
    }
}
