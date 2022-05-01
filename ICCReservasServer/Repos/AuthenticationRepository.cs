using Entities.Models;
using ICCReservasServer.DTOs;
using ICCReservasServer.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ICCReservasServer.Repos
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationSettings _appSettings;

        public AuthenticationRepository(UserManager<ApplicationUser> userManager, IOptions<ApplicationSettings> appSettings)
        {
            this._userManager = userManager;
            _appSettings = appSettings.Value;
        }

        public async Task<IdentityResult> UserAccountUnlock(ApplicationUser user, UserAccountDTO unlockAccount)
        {
            await _userManager.AddPasswordAsync(user, unlockAccount.Password);

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return await _userManager.ConfirmEmailAsync(user, token);
        }

        public String CreateToken(ApplicationUser user)
        {
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString())
                    }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
