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
            var command = new CreateLocationCommand
            {
                CityId = location.CityId,
                Name = location.Name,
                Address = location.Address,
                LocationType = location.LocationType,
                Price = location.Price,
                Latitude = location.Latitude,
                Longitude = location.Longitude
            };
            var result = await _mediator.Send(command);
            var mappedResult = _mapper.Map<LocationGetDto>(result);
            return CreatedAtAction(nameof(GetById), new { locationId = mappedResult.LocationId }, mappedResult);
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

    }
}
