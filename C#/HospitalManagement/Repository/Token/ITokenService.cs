using System.Security.Claims;
using HospitalManagement.Models;

namespace HospitalManagement.Repository.Token
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
