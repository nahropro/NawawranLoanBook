using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLB.Server.Extensions;
using NLB.Server.Repos;
using NLB.Server.Services;
using NLB.Shared.Resources.UserResources;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLB.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UserManagerController : ControllerBase
{
    private readonly IUserService userService;
    private readonly ITokenService tokenService;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UserManagerController(IUserService userService,
        ITokenService tokenService,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        this.userService = userService;
        this.tokenService = tokenService;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    // POST api/<UserManagerController>
    [HttpPost("Login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user=await userService.CheckCredentialsAsync(resource);

        if (user is null)
            return BadRequest();

        var toke= tokenService.GenerateJwtToken(user);

        return Ok(toke);
    }

    [HttpPost("ChangeUserName")]
    public async Task<IActionResult> ChangeUserName([FromBody] ChangeUserNameResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await userService.ChangeUserNameAsync(this.GetUserId(),resource);

        if (user is null)
            return BadRequest();

        await unitOfWork.SaveChangesAsync();

        return Ok(mapper.Map<SelectUserResource>(user));
    }

    [HttpPost("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await userService.ChangePasswordAsync(this.GetUserId(), resource);

        if (user is null)
            return BadRequest();

        await unitOfWork.SaveChangesAsync();

        return Ok(mapper.Map<SelectUserResource>(user));
    }
}
