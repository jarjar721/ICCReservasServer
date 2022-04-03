using ICCReservasServer.DTOs;
using ICCReservasServer.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class AuthenticationController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationSettings _appSettings;

        public AuthenticationController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IOptions<ApplicationSettings> appSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _appSettings = appSettings.Value;

        }
        
        [HttpPost]
        [Route("AccountUnlock")] // POST --> api/AuthenticationController/AccountUnlock
        public async Task<object> UserAccountUnlock(UserAccountDTO unlockAccount)
        {

            try
            {
                var user = await _userManager.FindByEmailAsync(unlockAccount.Email);

                if (user != null)
                {
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var result = await _userManager.ConfirmEmailAsync(user, token);

                    await _userManager.AddPasswordAsync(user, unlockAccount.Password);

                    return Ok(result);
                }
                else
                {
                    return BadRequest( new { code = "UserNotFound", message = "No existe un usuario registrado con ese email." });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("UserLogin")] // POST --> api/AuthenticationController/Login
        public async Task<IActionResult> UserLogin(UserAccountDTO userAccount)
        {
            var user = await _userManager.FindByEmailAsync(userAccount.Email);

            if (user != null && await _userManager.CheckPasswordAsync(user, userAccount.Password))
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

                var responseUser = new { 
                    userID = user.Id,
                    firstName = user.FirstName,
                    middleName = user.MiddleName,
                    lastName = user.LastName,
                    secondLastName = user.SecondLastName,
                    email = user.Email,
                    userName = user.UserName
                };

                return Ok(new { token = token, user = responseUser });
            }
            else
            {
                return BadRequest(new { code = "IncorrectCredentials", message = "Email o contraseña incorrectas." });
            }

        }

    }
}
