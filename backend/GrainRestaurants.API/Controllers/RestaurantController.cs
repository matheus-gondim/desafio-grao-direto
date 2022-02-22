using GrainRestaurants.API.Util;
using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Paginated;
using GrainRestaurants.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrainRestaurants.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize("Bearer")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;


        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        [ProducesResponseType(201, Type = typeof(ResponseObject<Page<Restaurant>>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public IActionResult FindRestaurantWithFilter([FromQuery] FilterRestaurantRequestDto dto)
        {
            var page = _restaurantService.FindRestaurantWithFilter(dto);
            return Ok(new ResponseObject<Page<Restaurant>>(page));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(201, Type = typeof(ResponseObject<Restaurant>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public IActionResult FindRestaurantById(long id)
        {
            var restaurant = _restaurantService.FindRestaurantById(id);
            return Ok(new ResponseObject<Restaurant>(restaurant));
        }
    }
}
