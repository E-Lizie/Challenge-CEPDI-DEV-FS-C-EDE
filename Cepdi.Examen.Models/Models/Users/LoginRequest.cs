using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.Models.Users
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "El valor usuario es requerido")]
        public string User { get; set; }

        [Required(ErrorMessage = "El valor Contraseña es requerido")]
        public string Password { get; set; }
    }
}
