using AutoMapper;
using Cepdi.Models.DTOs.Medicines;
using Cepdi.Models.Models.Medicines;

namespace Cepdi.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MedicineModel, MedicineDTo>()
                .ForMember(x => x.IdMedicamento, y => y.MapFrom( m => m.IIDMedicamento))
                .ForMember(x => x.IdFarmacia, y => y.MapFrom(m => m.IIdFarmaFarmaceutica))
                .ForMember(x => x.Habilitado, y => y.MapFrom(m => m.BHabilitado))
                .ReverseMap();
        }
    }
}
