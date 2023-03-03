using Cepdi.Models.Models;
using Cepdi.Models.Models.Pharmacies;

namespace Cepdi.Models.Interfaces.Pharmacies
{
    public interface IPharmaciesBussines
    {
        /// <summary>
        /// Obtiene una farmacia segun su identificador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Response<PharmaciesModel> Get(int id);
    }
}
