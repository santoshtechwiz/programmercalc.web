
using Microsoft.IdentityModel.Tokens;
using programmercalc.web.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace programmercalc.web.Services
{
    public static class TokenService
    {
        public static string Create(string algo = "HS256")
        {
            switch (algo)
            {
                case "HS256":
                    return SecurityAlgorithms.HmacSha256Signature;

                case "HS512":
                    return SecurityAlgorithms.HmacSha512Signature;

                case "HS384":
                    return SecurityAlgorithms.HmacSha384Signature;

                default:
                    return SecurityAlgorithms.HmacSha256Signature;
            }
        }

        public static string Authenticate(JWTInput input)
        {

            List<Claim> claims = new List<Claim>();
            if (input.Claims.Count() > 0)
            {
                input.Claims?.ForEach(x => claims.Add(new Claim(x.Type, x.Value)));

            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(input.Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                IssuedAt = DateTime.Now,
                Issuer = input.Iss,
                Audience = input.Aud,

                Subject = new ClaimsIdentity(claims.ToArray()),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), Create(input.Algorithm))
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var result = tokenHandler.WriteToken(token);

            return result;
        }
    }
}
