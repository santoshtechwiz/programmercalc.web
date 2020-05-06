using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace programmercalc.web.Models
{
    public class CustomClaims
    {
  
        public string Type { get; set; }
        [Required]
        public string Value { get; set; }
    }

    public  class JWTInput
    {

        [Required]
       
        public string Key { get; set; }
        public string Algorithm { get; set; }
        public List<SelectListItem> DDLClaims { get; set; }
        public JWTInput()
        {
            Claims = new List<CustomClaims> {
            new CustomClaims { Type = "GivenName", Value = "John" },
            new CustomClaims { Type = "Surname", Value = "Smith" },
            new CustomClaims { Type = "Role", Value = "Admin" }
            };
        }
        public List<CustomClaims> Claims { get; set; }
        [JsonProperty("iss")]
        public string Iss { get; set; }

        [JsonProperty("iat")]
        public long Iat { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("aud")]
        public string Aud { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("GivenName")]
        public string GivenName { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Role")]
        public string[] Role { get; set; }
    }
}
