using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLB.Server.Models.Database;
using NLB.Server.Repos;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.TransactionResources;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransactionsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ITransactionRepo transactionRepo;
        private readonly IMapper mapper;

        public TransactionsController(IUnitOfWork unitOfWork, ITransactionRepo transactionRepo, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.transactionRepo = transactionRepo;
            this.mapper = mapper;
        }

        // GET: api/<TransactionsController>
        [HttpGet]
        public IAsyncEnumerable<SelectTransactionResource> Get([FromQuery] TransactionQueryResource queryResurce)
        {
            return transactionRepo.GetTransactionsAsync(queryResurce);
        }

        // GET api/<TransactionsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var transaction = await transactionRepo.GetTransactionAsync(id);

            if(transaction == null)
                return NotFound();

            return Ok(mapper.Map<SelectTransactionResource>(transaction));
        }

        // POST api/<TransactionsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UpdateTransactionResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var transaction= mapper.Map<Transaction>(resource);
            await transactionRepo.CreateTransactionAsync(transaction);
            await unitOfWork.SaveChangesAsync();

            //Get the transaction from the database, for getting the transaction customer row with it
            transaction = await transactionRepo.GetTransactionAsync(transaction.Id);

            return Ok(mapper.Map<SelectTransactionResource>(transaction));
        }

        // PUT api/<TransactionsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateTransactionResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var transaction = await transactionRepo.GetTransactionAsync(id);

            if (transaction == null)
                return NotFound();

            mapper.Map(resource, transaction);
            await unitOfWork.SaveChangesAsync();

            //Get the transaction from the database, for getting the transaction customer row with it
            transaction = await transactionRepo.GetTransactionAsync(id);

            return Ok(mapper.Map<SelectTransactionResource>(transaction));
        }

        // DELETE api/<TransactionsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var transaction = await transactionRepo.GetTransactionAsync(id);

            if (transaction == null)
                return NotFound();

            transactionRepo.RemoveTransaction(transaction);
            await unitOfWork.SaveChangesAsync();

            return Ok(mapper.Map<SelectTransactionResource>(transaction));
        }
    }
}
