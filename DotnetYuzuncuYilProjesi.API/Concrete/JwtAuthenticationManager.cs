using DotnetYuzuncuYilProjesi.API.Abstraction;
using DotnetYuzuncuYilProjesi.Core.DTOs;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DotnetYuzuncuYilProjesi.API.Concrete
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        public readonly string _tokenKey;

        public JwtAuthenticationManager(string tokenKey)
        {
            _tokenKey = tokenKey;
        }

        public AuthResponseDto Authenticate(string songName, string singer)
        {
            AuthResponseDto authResponse = new AuthResponseDto();

            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_tokenKey);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Expires = DateTime.UtcNow.AddHours(1),
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, songName),
                    }),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                authResponse.Token = tokenHandler.WriteToken(token);

                return authResponse;
            }
            catch (Exception)
            {

                return authResponse;
            }
        }
    }
}
