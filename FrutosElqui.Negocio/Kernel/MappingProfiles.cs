using AutoMapper;
using FrutosElqui.Core.Misc;

namespace FrutosElqui.Negocio.Kernel
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Comuna,Comuna>();
        }
    }
}
