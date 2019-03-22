using AutoMapper;
using Diego.Dtos.Catalogos;
using Diego.Models.Catalogos;

namespace Diego.Helpers
{
    public class AuthoMapperProfiles : Profile
    {
        public AuthoMapperProfiles()
        {
           CreateMap<Producto, ProductoToReturnDTO>()
           .ForMember(dest => dest.Clasificacion, opt => {
                    opt.MapFrom(src => src.Clasificacion.Descripcion);
                    
                });
        }
        
    }
}