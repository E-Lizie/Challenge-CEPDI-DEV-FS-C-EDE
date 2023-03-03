using Cepdi.Models.Interfaces.Users;
using Cepdi.Models.Models.Users;
using Cepdi.Tools.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Data.Users
{
    public  class UsersData : IUsersData
    {
        /// <summary>
        /// Insumos
        /// </summary>
        private readonly IConfiguration _configuration;

        public UsersData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// User
        /// </summary>
        /// <param name="loginRequest">Credenciales</param>
        /// <returns>Información de user</returns>
        public UsersModel Get(LoginRequest loginRequest) {
            List<UsersModel> listRestul = new List<UsersModel>();
            var lines = Helpers.OpenFile(_configuration["FilePaths:Users"]);

            foreach (var line in lines) 
            {
                string[] words = line.Split('|');
                UsersModel model = new UsersModel() { 
                    IdUsuario = Convert.ToInt32(words[0]),
                    Nombre = Convert.ToString(words[1]),
                    FechaCreacion = DateTime.Parse(words[2]),
                    Usuario = words[3],
                    Password = words[4],
                    IdPerfil = Convert.ToInt32(words[5]),
                    Estatus = Convert.ToByte(words[6])
                };

                listRestul.Add(model);
            }

            var getItem = listRestul.Find(x => x.Usuario.Equals(loginRequest.User) && x.Password.Equals(loginRequest.Password));

            return getItem;
        }
    }
}
