using Cepdi.Models.Interfaces.Users;
using Cepdi.Models.Models;
using Cepdi.Models.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cepdi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersBusiness _usersBusiness;

        public UsersController(IUsersBusiness usersBusiness)
        {
            _usersBusiness = usersBusiness;
        }

        /// <summary>
        /// verifique el login
        /// </summary>
        /// <param name="value">Modelo con las credenciales</param>
        /// <returns>Si tienen acceso</returns>
        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Response<LoginResponse> Post([FromBody] LoginRequest value)
        {
           return _usersBusiness.Login(value);
        }

    }
}
