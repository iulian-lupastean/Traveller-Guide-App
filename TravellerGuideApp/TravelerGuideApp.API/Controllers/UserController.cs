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
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserPutPostDto user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = await _mediator.Send(_mapper.Map<CreateUserCommand>(user));
            var mappedResult = _mapper.Map<UserGetDto>(created);
            return CreatedAtAction(nameof(GetById), new { Id = mappedResult.UserId }, mappedResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetUsersQuery());
            var mappedResult = _mapper.Map<List<UserGetDto>>(result);
            return Ok(mappedResult);
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetById(int userid)
        {
            var result = await _mediator.Send(new GetUserByIdQuery { Id = userid });
            if (result == null)
                return NotFound();
            var mappedResult = _mapper.Map<UserGetDto>(result);
            return Ok(mappedResult);
        }

        [HttpPut]
        [Route("{userId}")]
        public async Task<IActionResult> UpdateUser(int userId, [FromBody] UserPutPostDto updatedUser)
        {
            var command = new UpdateUserCommand
            {
                Id = userId,
                FirstName = updatedUser.FirstName,
                LastName = updatedUser.LastName,
                Email = updatedUser.Email,
                Password = updatedUser.Password,
                UserType = updatedUser.UserType
            };
            var result = await _mediator.Send(command);
            if (result == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete]
        [Route("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var result = await _mediator.Send(new DeleteUserCommand { Id = userId });
            if (result == null)
                return NotFound();
            return NoContent();
        }
    }
}
