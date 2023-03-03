/// <summary>
/// Modelo para medicinas
/// </summary>
namespace Cepdi.Models.Models.Medicines
{
    public  class MedicineModel
    {
        /// <summary>
        /// Obtiene el id del medicamento
        /// </summary>
        public int IIDMedicamento { get; set; }
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
        public int IIdFarmaFarmaceutica { get; set; }
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
        public byte BHabilitado { get; set; }
    }
}
