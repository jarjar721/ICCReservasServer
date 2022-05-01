using Entities.Models;
using ICCReservasServer.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ICCReservasServer.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<IdentityResult> UserAccountUnlock(ApplicationUser user, UserAccountDTO unlockAccount);

        String CreateToken(ApplicationUser user);
    }
}
