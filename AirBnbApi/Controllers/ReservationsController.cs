using AirBnbApi.Model;
using AirBnbApi.Model.DTO;
using AirBnbApi.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Asp.Versioning;

namespace AirBnbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        // GET: api/Reservations
        /// <summary>
        /// This method first checks if the user already exists, if not, it creates one. Then it verifies if the location is available; if so, it creates a reservation.
        /// </summary>
        /// <response code="200">Reservatie confirmation</response>
        /// <response code="400">Reservation request is not correct</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] ReservationRequestDto reservationRequest, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var reservationResponse = await _reservationService.CreateReservationAsync(reservationRequest, cancellationToken);
                return Ok(reservationResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
