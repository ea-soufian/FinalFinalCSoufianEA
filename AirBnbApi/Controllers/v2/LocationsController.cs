using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;
using AutoMapper;
using Asp.Versioning;
using LocationDto = AirBnbApi.Model.DTO.v2.LocationDto;

namespace AirBnbApi.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly IMapper _mapper;

        public LocationsController(ISearchService searchService, IMapper mapper)
        {
            _searchService = searchService;
            _mapper = mapper;
        }

        // GET: api/Locations
        /// <summary>
        /// This method returns locations in the form of a DTO
        /// </summary>
        /// <response code="200">Locations from the database</response>
        /// <response code="404">No locations found in the database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<LocationDto>> GetLocations()
        {
            var locations = _searchService.GetLocations();
            if(locations == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<LocationDto>>(locations));
        }

        // GET: api/Locations/GetAll
        /// <summary>
        /// This method retrieves all locations from the database
        /// </summary>
        /// <response code="200">Locations from the database</response>
        /// <response code="404">No locations found in the database</response>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Location>> GetAllLocations()
        {
            var locations = _searchService.GetAllLocations();
            if(locations == null)
            {
                return NotFound();
            }
            return Ok(locations);
        }


        // GET: api/Locations/5
        /// <summary>
        /// This method retrieves a location based on ID
        /// </summary>
        /// <param name="id">This is the database ID of the location</param>
        /// <response code="200">A location from the database</response>
        /// <response code="404">The location is unknown in the database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Location> GetLocation(int id)
        {
            var location = _searchService.GetLocationById(id);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

    }
}
