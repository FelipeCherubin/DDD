using System.Net;
using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (loginDto == null)
                return BadRequest();

            try
            {
                var result = await _service.FindByLogin(loginDto);
                if (result != null)
                    return Ok(result);
                else
                    return NotFound();
            }
            catch (ArgumentNullException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }
    }
}
