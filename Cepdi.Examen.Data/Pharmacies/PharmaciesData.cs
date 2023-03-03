using Cepdi.Models.Interfaces.Pharmacies;
using Cepdi.Models.Models.Pharmacies;
using Cepdi.Tools.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Data.Pharmacy
{
    public class PharmaciesData: IPharmaciesData
    {
        /// <summary>
        /// Insumos
        /// </summary>
        private readonly IConfiguration _configuration;

        public PharmaciesData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Obtiene framacia
        /// </summary>
        /// <param name="id">Id farmacia</param>
        /// <returns>El modelo con la informacion de la farmacia</returns>
        public PharmaciesModel Get(int id)
        {
            List<PharmaciesModel> listRestul = new List<PharmaciesModel>();
            var lines = Helpers.OpenFile(_configuration["FilePaths:Pharmacy"]);

            foreach(var line in lines)
            {
                string[] words = line.Split('|');
                PharmaciesModel item = new PharmaciesModel()
                {
                    IIdFormaFarmaceutica = Convert.ToInt32(words[0]),
                    Nombre = words[1],
                    BHabilitado = Convert.ToByte(words[2])
                };
                listRestul.Add(item);
            }

            var result = listRestul.Find(x => x.IIdFormaFarmaceutica.Equals(id));
            
            return result;
        }

    }
}
