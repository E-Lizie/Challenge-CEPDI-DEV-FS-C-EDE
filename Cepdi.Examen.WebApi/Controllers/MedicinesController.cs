using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Cepdi.Models.Interfaces.Medicines;
using System.Threading.Tasks;
using Cepdi.Models.Models.Medicines;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Cepdi.Models.DTOs.Medicines;
using Cepdi.Models.Models.Paginatores;
using Cepdi.Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cepdi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private IMedicinesBusiness _medicinesBusiness;
    

        public MedicinesController(IMedicinesBusiness medicinesBusiness)
        {
            this._medicinesBusiness = medicinesBusiness;
        }

        /// <summary>
        /// Obtiene los registros para la tabla
        /// </summary>
        /// <param name="current"></param>
        /// <param name="record"></param>
        /// <returns></returns>
        [HttpGet("{current}/{record}")]       
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Paginator<MedicineDTo>> GetAll(int current, int record ) 
            => await _medicinesBusiness.GetAll(new ShowTableMedicinesModel() { Currentpage = current, RecordPorPage = record });

        
        /// <summary>
        /// Obtiene un registro por identificador
        /// </summary>
        /// <param name="id">identificar del medicamento</param>
        /// <returns>La informacion del medicamento</returns>
        [HttpGet("{id}")]
        public async Task<Response<MedicineDTo>> Get(int id)
        => await _medicinesBusiness.Get(id);



        /// <summary>
        /// Crea un nuevo medicamento
        /// </summary>
        /// <param name="model">La informacion para crear un medicamento</param>
        /// <returns>Si se creo el medicamento</returns>
        [HttpPost]
        [Route("Create")]
        public async Task<Response<bool>> Post([FromBody] CreateMedicineModel model)
        => await _medicinesBusiness.Create(model);

        /// <summary>
        /// Actualiza un medicamento
        /// </summary>
        /// <param name="id">Identificador del medicamento</param>
        /// <param name="model">Modelo con la informacion del medicamento</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<Response<bool>> Put(int id, [FromBody] MedicineDTo model)
        {
            model.IdMedicamento = id;
            return await _medicinesBusiness.Update(model);
        }

        /// <summary>
        /// Deshabilita un medicamento
        /// </summary>
        /// <param name="id">Identificador del medicamento</param>
        /// <returns>Si deshabilito un medicamento </returns>
        [HttpDelete("{id}")]
        public async Task<Response<bool>> Delete(int id)
        => await _medicinesBusiness.Delete(id);
    }
}
