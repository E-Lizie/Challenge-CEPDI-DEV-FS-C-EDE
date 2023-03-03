using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Models.DTOs.Medicines
{
    public class MedicineDTo
    {
        /// <summary>
        /// Obtiene el id del medicamento
        /// </summary>
        public int IdMedicamento { get; set; }
        /// <summary>
        /// Nombre del medicamento
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Concentracion del medicamento
        /// </summary>
        public string Concentracion { get; set; }
        /// <summary>
        /// Id del farmaceutio
        /// </summary>
        public int IdFarmacia { get; set; }
        /// <summary>
        /// Precio del medicamento
        /// </summary>
        public decimal Precio { get; set; }
        /// <summary>
        /// Cantidad disponibles del medicamento
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Presentacion del medicamento
        /// </summary>
        public string Presentacion { get; set; }
        /// <summary>
        /// SI esta habilitado o no el medicamento
        /// </summary>
        public byte Habilitado { get; set; }
    }
}
