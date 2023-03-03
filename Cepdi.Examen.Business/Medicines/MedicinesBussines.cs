
using AutoMapper;
using Cepdi.Business.Medicines.Validations;
using Cepdi.Models.DTOs.Medicines;
using Cepdi.Models.Interfaces.Medicines;
using Cepdi.Models.Interfaces.Pharmacies;
using Cepdi.Models.Models;
using Cepdi.Models.Models.Medicines;
using Cepdi.Models.Models.Paginatores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cepdi.Business.Medicines
{
    public class MedicinesBussines : IMedicinesBusiness
    {
        private IMedicinesData _medicinesData;
        private readonly IMapper _mapper;
        private IPharmaciesBussines _pharmaciesBussines;

        public MedicinesBussines(IMedicinesData medicinesData, IMapper mapper, IPharmaciesBussines pharmaciesBussines)
        {
            this._medicinesData = medicinesData;
            this._mapper = mapper;
            this._pharmaciesBussines = pharmaciesBussines;
        }

        /// <summary>
        /// Endpoint que permite crear un medicamento
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Return true == Correct</returns>
        public async Task<Response<bool>> Create(CreateMedicineModel model)
        {
            try
            {
                model.Habilitado = 1;
                var validatinPharmacy = _pharmaciesBussines.Get(model.IdFarmaceutica);
                if (validatinPharmacy == null)
                {
                    return new Response<bool> { Message = "Farmacia no válida. Verificar." };
                }

                var validation = HelperValidations.CreationValidation(model);

                

                if (!validation.Success)
                {
                    return new Response<bool> { Success = true, Message = validation.Message };
                }

                var create = await _medicinesData.Create(model);
                return new Response<bool> { Success = true, Data = create, Message = "Medicamento dado de alta correctamente"};
            }
            catch (System.Exception ex)
            {


                return new Response<bool>()
                {
                    Errors = new Errors
                    {
                        MethodName = $"Error en {nameof(Create)}",
                        PublicMessage = ex.Message,
                        TechnicalMessage = ex.StackTrace

                    }
                };
            }
        }

        /// <summary>
        /// Elimina medicamentos por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return   true == correct</returns>
        public async Task<Response<bool>> Delete(int id)
        {
            try
            {
                var result = await _medicinesData.Delete(id);
                return new Response<bool> { Success = true, Data = result, Message =  result ? string.Empty : "No se puedo eliminar el medicamento"+ id };
            }
            catch (System.Exception ex)
            {

                return new Response<bool>()
                {
                    Errors = new Errors
                    {
                        MethodName = $"Error en {nameof(Delete)}",
                        PublicMessage = ex.Message,
                        TechnicalMessage = ex.StackTrace

                    }
                };
            }
        }

        /// <summary>
        /// Consulta información de medicamento pot id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Información</returns>
        public async Task<Response<MedicineDTo>> Get(int id)
        {            
            try
            {
                var result = await _medicinesData.Get(id);
                return new Response<MedicineDTo>() 
                {
                    Success = true,
                    Data = _mapper.Map<MedicineDTo>(result)
                };
            }
            catch (System.Exception ex)
            {

                return new Response<MedicineDTo>()
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

        /// <summary>
        /// Se obtienen todos los medicamentos
        /// </summary>
        /// <returns>Informacion de todos los medicamentos</returns>
        public async Task<Paginator<MedicineDTo>> GetAll(ShowTableMedicinesModel model)
        {
            var result = await _medicinesData.GetAll(model);

            var listdDto = _mapper.Map<List<MedicineDTo>>(result.registers);

            return new Paginator<MedicineDTo>()
            {
                Records = listdDto,
                TotalRecords = result.totalRecord,
                CurrentPage = model.Currentpage,
                RecordsPage = model.RecordPorPage
            };
        }

        /// <summary>
        /// Actualiza medicamento
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Medicamento actualizado</returns>
        public async Task<Response<bool>> Update(MedicineDTo model)
        {
            try
            {
                var MedicineDTo = _mapper.Map<MedicineModel>(model);
                var result = await _medicinesData.Update(MedicineDTo);

                return new Response<bool> { Success = true, Data = result, Message = result ? string.Empty : "Ocurrio un error al actualizar medicamento:"+MedicineDTo.Nombre};
            }
            catch (System.Exception ex)
            {

                return new Response<bool>()
                {
                    Errors = new Errors
                    {
                        MethodName = $"Error en {nameof(Update)}",
                        PublicMessage = ex.Message,
                        TechnicalMessage = ex.StackTrace

                    }
                };
            }
            
        }
    }
}
