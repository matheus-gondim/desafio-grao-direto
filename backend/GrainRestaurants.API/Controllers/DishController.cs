using GrainRestaurants.API.Util;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrainRestaurants.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpGet("restaurant/{restaurantId}")]
        [ProducesResponseType(201, Type = typeof(ResponseObject<List<Dish>>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public IActionResult FindDishByRestaurantId(long restaurantId)
        {
            var dish = _dishService.FindDishByRestaurantId(restaurantId);
            return Ok(new ResponseObject<List<Dish>>(dish));
        }
    }
}
