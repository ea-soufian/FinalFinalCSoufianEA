using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;

namespace AirBnbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public LandlordsController(ISearchService searchService)
        {
            _searchService = searchService;
        }


        // GET: api/Landlords
        /// <summary>
        /// This method retrieves all landlords from the database
        /// </summary>
        /// <response code="200">Landlords from the database</response>
        /// <response code="404">No landlords found in the database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlordsAsync(CancellationToken cancellationToken)
        {
            var landlords = await _searchService.GetAllLandlordsAsync(cancellationToken);
            if (landlords == null)
            {
                return NotFound();
            }
            return Ok(landlords);
        }


        // GET: api/Landlords/5
        /// <summary>
        /// This method retrieves a landlord based on ID
        /// </summary>
        /// <param name="id">This is the database ID of the landlord</param>
        /// <response code="200">A landlord from the database</response>
        /// <response code="404">The landlord is unknown in the database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlordAsync(int id, CancellationToken cancellationToken)
        {
            var landlord = await _searchService.GetLandlordByIdAsync(id, cancellationToken);
            
            if (landlord == null)
            {
                return NotFound();
            }

            return Ok(landlord);
        }

        // GET: api/Landlords/5/Locations
        /// <summary>
        /// This method retrieves all locations based on landlord ID
        /// </summary>
        /// <param name="id">This is the database ID of the landlord</param>
        /// <response code="200">All locations of the landlord</response>
        /// <response code="404">The landlord has no locations or the landlord does not exist</response>
        [HttpGet("{id}/Locations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocationsAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _searchService.GetAllLocationsAsync(id, cancellationToken);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }
        
    }
}
