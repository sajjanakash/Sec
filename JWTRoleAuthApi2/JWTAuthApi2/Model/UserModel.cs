using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthApi2.Model
{
    public class UserModel
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String EmailAddress { get; set; }
        public String RoleModel { get; set; }
    }
}
