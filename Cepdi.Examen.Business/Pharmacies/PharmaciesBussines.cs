using AutoMapper;
using Cepdi.Models.Interfaces.Pharmacies;
using Cepdi.Models.Models;
using Cepdi.Models.Models.Pharmacies;
using System;

namespace Cepdi.Business.Pharmacies
{
    public class PharmaciesBussines : IPharmaciesBussines
    {
        private IPharmaciesData _pharmaciesData;
        private readonly IMapper _mapper;

        public PharmaciesBussines(IPharmaciesData pharmaciesData, IMapper mapper)
        {
            _pharmaciesData = pharmaciesData;
            _mapper = mapper;
        }
        /// <summary>
        /// Consulta medicamento por ID
        /// </summary>
        /// <param name="id">Identificadors</param>
        /// <returns>Farmacia</returns>
        public Response<PharmaciesModel> Get(int id)
        {
            try
            {
                var result = _pharmaciesData.Get(id);


                return new Response<PharmaciesModel>() { 
                    Success = (result != null), 
                    Data = result,
                    Message = (result != null) ? string.Empty : "No se encuentran las farmacias"
                };
            }
            catch (Exception ex)
            {

                return new Response<PharmaciesModel>()
                {
                    Errors = new Errors
                    {
                        MethodName = $"Error en {nameof(Get)}",
                        PublicMessage = ex.Message,
                        TechnicalMessage = ex.StackTrace

                    }
                };
            }
        }
    }
}
