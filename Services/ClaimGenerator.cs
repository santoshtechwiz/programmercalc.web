using programmercalc.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programmercalc.web.Services
{
    public static class ClaimGenerator
    {
        private static List<CustomClaims> _list = new List<CustomClaims>();
        public static List<CustomClaims> DefaultClaims()
        {

            _list.Add(new CustomClaims { Type = "GivenName", Value = "John" });
            _list.Add(new CustomClaims { Type = "Surname", Value = "Smith" });
            _list.Add(new CustomClaims { Type = "Email", Value = "exampl@domain.com" });
            _list.Add(new CustomClaims { Type = "Role", Value = "Admin" });
            _list.Add(new CustomClaims { Type = "Role", Value = "Moderator" });

            return _list;
            
        }
        public static void AddClaim(CustomClaims claim)
        {
            _list.Add(claim);
        }
    }
}
