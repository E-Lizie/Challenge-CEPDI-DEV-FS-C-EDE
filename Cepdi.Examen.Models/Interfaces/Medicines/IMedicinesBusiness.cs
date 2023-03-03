using Cepdi.Models.DTOs.Medicines;
using Cepdi.Models.Models;
using Cepdi.Models.Models.Medicines;
using Cepdi.Models.Models.Paginatores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.Interfaces.Medicines
{
    public interface IMedicinesBusiness
    {
        /// <summary>
        /// Obtiene un medicamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un la informacion del medicamento</returns>
        Task<Response<MedicineDTo>> Get(int id);

        /// <summary>
        /// Obtiene todos los medicamentos
        /// </summary>
        /// <returns>Retorna la informacion de todos los medicamentos</returns>
        Task<Paginator<MedicineDTo>> GetAll(ShowTableMedicinesModel model);

        /// <summary>
        /// Crear un medicamento
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Retorna un true si creo el modelo</returns>
        Task<Response<bool>> Create(CreateMedicineModel model);


        /// <summary>
        /// Actualiza un medicamento
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Retorna el modelo con la nueva informacion que se actualizo</returns>
        Task<Response<bool>> Update(MedicineDTo model);

        /// <summary>
        /// Elimina un medicamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returna true si eliino el medicamento</returns>
        Task<Response<bool>> Delete(int id);
    }
}
