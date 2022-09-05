using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLB.Server.Repos;
using NLB.Server.Services;
using NLB.Shared.Resources.UserResources;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetUpController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public SetUpController(IUnitOfWork unitOfWork,IUserService userService, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.userService = userService;
            this.mapper = mapper;
        }

        // POST api/<SetUpController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if((await userService.CountAsync())>0)
                return BadRequest("The software was seted up before!");

            var user=await userService.RegisterUserAsync(resource);

            await unitOfWork.SaveChangesAsync();

            return Ok(mapper.Map<SelectUserResource>(user));
        }
    }
}
