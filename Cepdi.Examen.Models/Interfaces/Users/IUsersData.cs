using Cepdi.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.Interfaces.Users
{
    public  interface IUsersData
    {
        /// <summary>
        /// Obtiene el usuario que se esta identificando
        /// </summary>
        /// <param name="loginRequest">Credenciales</param>
        /// <returns>Modelo con la informacion del usuario</returns>
        UsersModel Get(LoginRequest loginRequest);
    }
}
