using CargoConnect.Application.DTOs.Booking;
using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        //GET: api/bookings
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var bookings = await _bookingService.GetAllAsync();
            return Ok(bookings);
        }

        //GET :api/bookings/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var booking = await _bookingService.GetByIdAsync(id);
            if (booking == null)
                return NotFound("Booking not found");
            return Ok(booking);
        }


        //POST : api/bookings
        [HttpPost]
         public async Task<IActionResult> Create([FromBody] BookingCreateDTO bookingCreateDto)
            {
            if (ModelState.IsValid)
            {
                var result = await _bookingService.CreateAsync(bookingCreateDto);
                return Ok(result);
            }

            return BadRequest(ModelState);
        }

        //PUT : api/bookings
        [HttpPut]
            public async Task<IActionResult> Update([FromBody] BookingUpdateDTO bookingUpdateDto)
            {
                if (ModelState.IsValid)
                {
                    var result = await _bookingService.UpdateAsync(bookingUpdateDto);
                    if (result)
                        return Ok("Booking updated successfully");
                    return BadRequest("Failed to update booking");
                }
    
                return BadRequest(ModelState);
            }

        //DELETE : api/bookings/{id}
        [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(Guid id)
            {
                var result = await _bookingService.DeleteAsync(id);
                if (result)
                    return Ok("Booking deleted successfully");
                return NotFound("Booking not found");
        }
    }
}
