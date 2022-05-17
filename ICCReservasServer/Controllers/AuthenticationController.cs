using ICCReservasServer.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ICCReservasServer.Middleware.Models;
using ICCReservasServer.Interfaces;
using EmailService;
using EmailService.Interfaces;
using Microsoft.AspNetCore.WebUtilities;

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
        private IEmailSenderRepository _emailSender;

        public AuthenticationController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IOptions<ApplicationSettings> appSettings,
            IUnitOfWork uow,
            IEmailSenderRepository emailSender
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _appSettings = appSettings.Value;
            _uow = uow;
            _emailSender = emailSender;

        }

        // POST: Authentication/AccountUnlock
        [HttpPost("AccountUnlock")]
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

        // POST: Authentication/UserLogin
        [HttpPost("UserLogin")]
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

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByEmailAsync(forgotPasswordDTO.Email);
            if (user == null)
                return BadRequest("Invalid Request");

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var param = new Dictionary<string, string>
            {
                {"token", token },
                {"email", forgotPasswordDTO.Email }
            };

            var callback = QueryHelpers.AddQueryString(forgotPasswordDTO.ClientURI, param);

            var message = new Message(new string[] { user.Email }, "Reset password token", callback, null);
            await _emailSender.SendEmailAsync(message);

            return Ok();
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDTO resetPasswordDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByEmailAsync(resetPasswordDTO.Email);
            if (user == null)
                return BadRequest("Invalid Request");

            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordDTO.Token, resetPasswordDTO.Password);
            if (!resetPassResult.Succeeded)
            {
                var errors = resetPassResult.Errors.Select(e => e.Description);

                return BadRequest(new { Errors = errors });
            }

            return Ok();
        }

    }
}
