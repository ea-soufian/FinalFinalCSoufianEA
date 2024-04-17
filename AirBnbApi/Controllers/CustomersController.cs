using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;

namespace AirBnbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public CustomersController(ISearchService searchService)
        {
            _searchService = searchService;
        }


        // GET: api/Customers
        /// <summary>
        /// This method retrieves all customers from the database
        /// </summary>
        /// <response code="200">Customers from the database</response>
        /// <response code="404">No customers found in the database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersAsync(CancellationToken cancellationToken)
        {
            var customers = await _searchService.GetAllCustomersAsync(cancellationToken);
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }


        // GET: api/Customers/5
        /// <summary>
        /// This method retrieves a customer based on ID
        /// </summary>
        /// <param name="id">This is the database ID of the customer</param>
        /// <response code="200">A customer from the database</response>
        /// <response code="404">The customer is unknown in the database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomerAsync(int id, CancellationToken cancellationToken)
        {
            var customer = await _searchService.GetCustomerByIdAsync(id, cancellationToken);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

    }
}
