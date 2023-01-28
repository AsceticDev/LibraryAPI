using LibraryAPI.Contracts;
using LibraryAPI.Entities.Dto;
using LibraryAPI.Entities.Models;
using LibraryAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LibraryAPI.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly ITokenRepository _tokenRepository;
        public AuthController(RepositoryContext repositoryContext, ITokenRepository tokenRepository)
        {
            _repositoryContext = repositoryContext ?? throw new ArgumentNullException(nameof(repositoryContext));
            _tokenRepository = tokenRepository ?? throw new ArgumentNullException(nameof(tokenRepository));
        }
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            if (loginModel is null)
            {
                return BadRequest("Invalid client request");
            }
            var user = _repositoryContext.LoginModels.FirstOrDefault(u => 
                (u.UserName == loginModel.UserName) && (u.Password == loginModel.Password));
            if (user is null)
                return Unauthorized();
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.UserName),
                new Claim(ClaimTypes.Role, "Manager")
            };
            var accessToken = _tokenRepository.GenerateAccessToken(claims);
            var refreshToken = _tokenRepository.GenerateRefreshToken();
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            _repositoryContext.SaveChanges();
            return Ok(new AuthenticatedResponseDto
            {
                Token = accessToken,
                RefreshToken = refreshToken
            });
        }
    }
}
