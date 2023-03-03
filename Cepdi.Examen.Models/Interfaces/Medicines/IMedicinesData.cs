using Cepdi.Models.Models.Medicines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.Interfaces.Medicines
{
    public  interface IMedicinesData
    {
        /// <summary>
        /// Obtiene un medicamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un la informacion del medicamento</returns>
        Task<MedicineModel> Get(int id);

        /// <summary>
        /// Obtiene los registros por paginacion
        /// </summary>
        /// <param name="model">Modelo con el request</param>
        /// <returns>los registros y el total</returns>
        Task<(int totalRecord, IEnumerable<MedicineModel> registers)> GetAll(ShowTableMedicinesModel model);

        /// <summary>
        /// Crear un medicamento
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Retorna un true si creo el modelo</returns>
        Task<bool> Create(CreateMedicineModel model);


        /// <summary>
        /// Actualiza un medicamento
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Retorna el modelo con la nueva informacion que se actualizo</returns>
        Task<bool> Update(MedicineModel model);

        /// <summary>
        /// Elimina un medicamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returna true si eliino el medicamento</returns>
        Task<bool> Delete(int id);
       
    }
}
