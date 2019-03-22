using AutoMapper;
using Diego.Dtos.Catalogos;
using Diego.Models.Catalogos;

namespace Diego.Helpers
{
    public class AuthoMapperProfiles : Profile
    {
        public AuthoMapperProfiles()
        {
           CreateMap<Producto, ProductoToReturnDTO>();
        }
        
    }
}