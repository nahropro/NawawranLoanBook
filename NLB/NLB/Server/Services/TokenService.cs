using Microsoft.IdentityModel.Tokens;
using NLB.Server.Models.Database;
using NLB.Shared.Resources.UserResources;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NLB.Server.Services;

public class TokenService : ITokenService
{
    private readonly IConfiguration configuration;

    public TokenService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public TokenResource GenerateJwtToken(User user, int expireAfterDays = 30)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["AuthSettings:Key"]));

        var token = new JwtSecurityToken(
            issuer: configuration["AuthSettings:Issuer"],
            audience: configuration["AuthSettings:Audience"],
            claims: claims,
            expires: DateTime.Now.AddDays(expireAfterDays),
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

        string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return new TokenResource
        {
            Token = tokenString,
            ExpireDate = token.ValidTo,
            UserName = user.UserName,
            UserId = user.Id
        };
    }
}
