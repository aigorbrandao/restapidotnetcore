using ApiPmoIntel.Models;
using ApiPmoIntel.Security;
using ApiPmoIntel.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPmoIntel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _service;

        public LoginController(IUserService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public object Post([FromBody]AccessCredentials credentials)
        {
            if (credentials == null) return BadRequest();
            return _service.GetByLogin(credentials);
        }
    }
}
