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
    public class CitiesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CitiesController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity([FromBody] CityPutPostDto city)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreateCityCommand
            {
                Name = city.Name,
                Country = city.Country
            };
            var result = _mediator.Send(command);
            var mappedResult = _mapper.Map<CityGetDto>(result);
            return CreatedAtAction(nameof(GetById), new { Id = mappedResult.Id }, mappedResult);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetCityByIdQuery { Id = id });
            if (result == null)
                return NotFound();
            var mappedResult = _mapper.Map<CityGetDto>(result);
            return Ok(mappedResult);

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetCitiesListQuery();
            var result = await _mediator.Send(query);
            var mappedResult = _mapper.Map<List<CityGetDto>>(result);
            return Ok(mappedResult);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateCity(int id, [FromBody] CityPutPostDto updatedCity)
        {
            var command = new UpdateCityCommand()
            {
                Id = id,
                Name = updatedCity.Name,
                Country = updatedCity.Country,

            };
            var result = await _mediator.Send(command);
            if (result == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var result = await _mediator.Send(new DeleteCityCommand { Id = id });
            if (result == null)
                return NotFound();
            return NoContent();
        }
    }
}
