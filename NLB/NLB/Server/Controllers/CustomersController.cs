using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLB.Server.Models.Database;
using NLB.Server.Repos;
using NLB.Shared.Resources.CustomerResources;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICustomerRepo customerRepo;
        private readonly IMapper mapper;

        public CustomersController(IUnitOfWork unitOfWork, ICustomerRepo customerRepo, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.customerRepo = customerRepo;
            this.mapper = mapper;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public IAsyncEnumerable<SelectCustomerResource> Get(string? s=null)
        {
            return customerRepo.GetCustomersAsync(s);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customer=await customerRepo.GetCustomerAsync(id);
            if (customer is null)
                return NotFound();

            var selectCustomer=mapper.Map<SelectCustomerResource>(customer);
            return Ok(selectCustomer);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UpdateCustomerResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customer = mapper.Map<Customer>(resource);
            await customerRepo.CreateCustomerAsync(customer);
            await unitOfWork.SaveChangesAsync();

            var selectCustomer=mapper.Map<SelectCustomerResource>(customer);

            return Ok(selectCustomer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateCustomerResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customer = await customerRepo.GetCustomerAsync(id);
            if (customer is null)
                return NotFound();

            customer = mapper.Map(resource, customer);
            await unitOfWork.SaveChangesAsync();

            var selectCustomer = mapper.Map<SelectCustomerResource>(customer);

            return Ok(selectCustomer);

        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await customerRepo.GetCustomerAsync(id);
            if (customer is null)
                return NotFound();

            customerRepo.RemoveCustomer(customer);
            await unitOfWork.SaveChangesAsync();

            var selectCustomer = mapper.Map<SelectCustomerResource>(customer);

            return Ok(selectCustomer);
        }
    }
}
