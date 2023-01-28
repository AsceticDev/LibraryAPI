using System.Security.Claims;

namespace LibraryAPI.Contracts
{
    public interface ITokenRepository
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
