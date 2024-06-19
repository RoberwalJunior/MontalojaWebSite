using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Loja;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;

namespace MontalojaWebSite.Bibliotecas.Dominio.Profiles;

public class LojaProfile : Profile
{
    public LojaProfile()
    {
        CreateMap<CreateLojaDto, Loja>();
        CreateMap<Loja, ReadLojaDto>();
        CreateMap<UpdateLojaDto, Loja>();
    }
}
