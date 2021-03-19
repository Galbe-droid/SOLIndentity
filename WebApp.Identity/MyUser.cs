using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Identity
{
    public class MyUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        //Totalmente maiusculo
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
