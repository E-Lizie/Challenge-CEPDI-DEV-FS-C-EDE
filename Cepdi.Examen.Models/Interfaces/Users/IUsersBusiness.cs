using Cepdi.Models.Models;
using Cepdi.Models.Models.Users;

namespace Cepdi.Models.Interfaces.Users
{
    public interface IUsersBusiness
    {
        /// <summary>
        /// Verifica que el usuario tengo acceso
        /// </summary>
        /// <param name="loginRequest">Credenciales</param>
        /// <returns>Si el usuario tiene acceso</returns>
        Response<LoginResponse> Login(LoginRequest loginRequest);
    }
}
