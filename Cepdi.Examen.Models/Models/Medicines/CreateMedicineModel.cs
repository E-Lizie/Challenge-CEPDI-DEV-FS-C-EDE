
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Modelo para crear un medicamento
/// </summary>
namespace Cepdi.Models.Models.Medicines
{
    public class CreateMedicineModel
    {
        /// <summary>
        /// Nombre del medicamento
        /// </summary>
        [Required(ErrorMessage ="EL campo nombre es requerido")]
        public string Nombre { get; set; }
        /// <summary>
        /// Concentracion del medicamento
        /// </summary>
        [Required(ErrorMessage = "EL campo Concentracion es requerido")]
        public string Concentracion { get; set; }
        /// <summary>
        /// Id del farmaceutio
        /// </summary>
        [Required(ErrorMessage = "EL campo IdFarmaceutica es requerido")]
        public int IdFarmaceutica { get; set; }
        /// <summary>
        /// Precio del medicamento
        /// </summary>
        [Required(ErrorMessage = "EL campo Precio es requerido")]
        public decimal Precio { get; set; }
        /// <summary>
        /// Cantidad disponibles del medicamento
        /// </summary>
        [Required(ErrorMessage = "EL campo Stock es requerido")]
        public int Stock { get; set; }
        /// <summary>
        /// Presentacion del medicamento
        /// </summary>
        [Required(ErrorMessage = "EL campo Presentacion es requerido")]
        public string Presentacion { get; set; }
        /// <summary>
        /// SI esta habilitado o no el medicamento
        /// </summary>
        [Required(ErrorMessage = "EL campo BHabilitado es requerido")]
        public byte Habilitado { get; set; }

    }
}
