using HotelListing.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    public class CountryV2Controller : Controller
    {
        [ApiVersion("2.0")]
        [Route("api/{v:apiversion}/country")]
        [ApiController]
        public class CountryController : ControllerBase
        {
            private readonly DatabaseContext _context;

            public CountryController(DatabaseContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult GetCountries()
            {
                return Ok(_context.Countries);
            }
        }
    }
}
