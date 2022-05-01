using ICCReservasServer.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ICCReservasServer.Middleware.Models;
using ICCReservasServer.Interfaces;

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
        private readonly IUnitOfWork _uow;

        public AuthenticationController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IOptions<ApplicationSettings> appSettings,
            IUnitOfWork uow)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _appSettings = appSettings.Value;
            _uow = uow;

        }
        
        [HttpPost]
        [Route("AccountUnlock")] // POST --> api/AuthenticationController/AccountUnlock
        public async Task<IActionResult> UserAccountUnlock(UserAccountDTO unlockAccount)
        {

            var user = await _userManager.FindByEmailAsync(unlockAccount.Email);

            if (user != null)
            {
                if (user.EmailConfirmed) 
                {
                    throw new RegisteredEmailException("Ya existe un usuario registrado con este email");
                }
                else
                {
                    return Ok(await _uow.AuthenticationRepository.UserAccountUnlock(user, unlockAccount));
                }
            }
            else
            {
                throw new UnauthorizedEmailException("El email ingresado no está autorizado");
            }
            

        }

        [HttpPost]
        [Route("UserLogin")] // POST --> api/AuthenticationController/Login
        public async Task<IActionResult> UserLogin(UserAccountDTO userAccount)
        {
            var user = await _userManager.FindByEmailAsync(userAccount.Email);

            if (user == null)
            {
                throw new EmailNotFoundException("Email ingresado no existe");
            }

            if (user != null && await _userManager.CheckPasswordAsync(user, userAccount.Password))
            {
                
                var token = _uow.AuthenticationRepository.CreateToken(user);

                var responseUser = new ApplicationUserDTO { 
                    ID = user.Id,
                    Names = user.Names,
                    LastNames = user.LastNames,
                    Email = user.Email,
                    UserName = user.UserName
                };

                return Ok(new { token, responseUser });
            }
            else
            {
                throw new FailedLoginException("Email o Password incorrecto");
            }

        }

    }
}
