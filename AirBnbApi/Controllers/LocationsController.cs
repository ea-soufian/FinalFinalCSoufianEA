using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;
using AutoMapper;
using AirBnbApi.Model.DTO;
using Asp.Versioning;

namespace AirBnbApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public LocationsController(ISearchService searchService, IReservationService reservationService, IMapper mapper)
        {
            _searchService = searchService;
            _reservationService = reservationService;
            _mapper = mapper;
        }

        // GET: api/Locations
        /// <summary>
        /// This method returns locations in the form of a DTO
        /// </summary>
        /// <response code="200">Locations from the database</response>
        /// <response code="404">there are no locations in the database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LocationDto>>> GetLocationsAsync(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetLocationsAsync(cancellationToken);
            if(locations == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<LocationDto>>(locations));
        }

        // GET: api/Locations/GetAll
        /// <summary>
        /// This method gives all locations back from the database
        /// </summary>
        /// <response code="200">Locations from the database</response>
        /// <response code="404">there are no locations in the database</response>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocationsAsync(cancellationToken);
            if(locations == null)
            {
                return NotFound();
            }
            return Ok(locations);
        }

        // GET: api/Locations/5
        /// <summary>
        /// This method retrieves a location based on its ID
        /// </summary>
        /// <param name="id">this is the database ID of the location</param>
        /// <response code="200">A location from the database</response>
        /// <response code="404">the location is unknown in the database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Location>> GetLocationAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _searchService.GetLocationByIdAsync(id, cancellationToken);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }
        // POST: api/Locations/Search
        /// <summary>
        /// This method returns locations in the form of a DTO based on a set of search terms
        /// </summary>
        /// <response code="200">Locations from the database</response>
        /// <response code="404">No locations found in the database with these search terms</response>
        [HttpPost("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<AirBnbApi.Model.DTO.v2.LocationDto>>> Search([FromBody] SearchRequestDto searchRequestDto, CancellationToken cancellationToken)
        {
            var locations = await _searchService.SearchLocationsAsync(searchRequestDto, cancellationToken);
            if (locations == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<AirBnbApi.Model.DTO.v2.LocationDto>>(locations));
        }

        // GET: api/Locations/GetMaxPrice
        /// <summary>
        /// This method returns the highest price of all locations in the database
        /// </summary>
        /// <response code="200">The highest price</response>
        [HttpGet("GetMaxPrice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MaxPriceResponseDto>> GetMaxPrice(CancellationToken cancellationToken)
        {
            int maxPrice = await _searchService.GetMaxPriceAsync(cancellationToken);
            return Ok(new MaxPriceResponseDto { Price = maxPrice });
        }


        // GET: api/Locations/GetDetails/{id}
        /// <summary>
        /// This method retrieves details of a location based on ID
        /// </summary>
        /// <response code="200">Details of the location</response>
        /// <response code="404">Location does not exist</response>
        [HttpGet("GetDetails/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LocationDetailsDto>> GetDetails(int id, CancellationToken cancellationToken)
        {
            var locationDetails = await _searchService.GetLocationDetailsAsync(id, cancellationToken);

            if (locationDetails == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<LocationDetailsDto>(locationDetails));
        }


        // GET: api/Locations/UnAvailableDates/{id}
        /// <summary>
        /// This method returns all dates on which the location is not available
        /// </summary>
        /// <response code="200">Dates when the location is not available</response>
        /// <response code="404">Location does not exist</response>
        [HttpGet("UnAvailableDates/{locationId}")]
        public async Task<ActionResult<UnavailableDatesResponse>> GetUnavailableDates(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _reservationService.GetUnavailableDatesAsync(locationId, cancellationToken);
            if (unavailableDates == null)
            {
                return NotFound();
            }

            return new UnavailableDatesResponse { UnavailableDates = unavailableDates.ToList() };
        }
    }
}
