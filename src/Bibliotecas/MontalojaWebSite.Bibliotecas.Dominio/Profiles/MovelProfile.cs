using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Movel;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;

namespace MontalojaWebSite.Bibliotecas.Dominio.Profiles;

public class MovelProfile : Profile
{
    public MovelProfile()
    {
        CreateMap<CreateMovelDto, Movel>();
        CreateMap<Movel, ReadMovelDto>();
        CreateMap<UpdateMovelDto, Movel>();
    }
}
