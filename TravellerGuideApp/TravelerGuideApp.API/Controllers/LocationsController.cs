using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelerGuideApp.API.DTOs;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Queries;

namespace TravelerGuideApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public LocationsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation([FromBody] LocationPutPostDto location)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = await _mediator.Send(_mapper.Map<CreateLocationCommand>(location));
            var mappedResult = _mapper.Map<LocationGetDto>(created);
            return CreatedAtAction(nameof(GetById), new { Id = mappedResult.LocationId }, mappedResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetLocationsForCityQuery());
            var mappedResult = _mapper.Map<List<LocationGetDto>>(result);
            return Ok(mappedResult);
        }

        [HttpGet]
        [Route("{locationId}")]
        public async Task<IActionResult> GetById(int locationId)
        {
            var result = await _mediator.Send(new GetLocationByIdQuery { Id = locationId });
            if (result == null)
                return NotFound();
            var mappedResult = _mapper.Map<LocationGetDto>(result);
            return Ok(mappedResult);
        }

        [HttpPut]
        [Route("{locationId}")]
        public async Task<IActionResult> UpdateLocation(int locationId, [FromBody] LocationPutPostDto updatedLocation)
        {
            var command = new UpdateLocationCommand
            {
                Id = locationId,
                Name = updatedLocation.Name,
                Address = updatedLocation.Address,
                LocationType = updatedLocation.LocationType,
                Price = updatedLocation.Price,
                Latitude = updatedLocation.Latitude,
                Longitude = updatedLocation.Longitude,
                CityId = updatedLocation.CityId
            };
            var result = await _mediator.Send(command);
            if (result == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete]
        [Route("{locationId}")]
        public async Task<IActionResult> DeleteLocation(int locationId)
        {
            var result = await _mediator.Send(new DeleteLocationCommand { Id = locationId });
            if (result == null)
                return NotFound();
            return NoContent();
        }

        [HttpPost]
        [Route("{cityId}/locations/{locationId}")]
        public async Task<IActionResult> AddLocationToCity(int cityId, int locationId)
        {
            var command = new AddLocationToCity
            {
                LocationId = locationId,
                CityId = cityId
            };

            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{cityId}/locations/{locationId}")]
        public async Task<IActionResult> RemoveLocationFromCity(int cityId, int locationId)
        {
            var command = new RemoveLocationFromCity() { CityId = cityId, LocationId = locationId };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
