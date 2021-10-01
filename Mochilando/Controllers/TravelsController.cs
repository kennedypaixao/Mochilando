using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mochilando.Service.Services.Travel;
using Mochilando.Tools.DTO.Travel;
using Mochilando.Tools.Repository.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mochilando.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TravelsController : ControllerBase
    {
        private readonly ILogger<TravelsController> _logger;
        private readonly ITravelRepository _travelRepository;
        private readonly TravelService _travelService;

        public TravelsController(ILogger<TravelsController> logger,
            ITravelRepository travelRepository)
        {
            _logger = logger;
            _travelRepository = travelRepository;
            _travelService = new TravelService(_travelRepository);
        }


        [HttpPost]
        public async Task<ActionResult<TravelDto>> PostAsync(TravelDto travel)
        {
            if (ModelState.IsValid)
            {
                await _travelService.Insert(travel);
                return Created($"/api/travels/{travel.UID}", travel);
            }

            return BadRequest(ModelState);
        }
    }
}
