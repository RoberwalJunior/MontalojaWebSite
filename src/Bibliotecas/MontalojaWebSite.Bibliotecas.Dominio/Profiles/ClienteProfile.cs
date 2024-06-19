using AutoMapper;
using MontalojaWebSite.Bibliotecas.Dominio.Dtos.Cliente;
using MontalojaWebSite.Bibliotecas.Dominio.Modelos;

namespace MontalojaWebSite.Bibliotecas.Dominio.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
        CreateMap<Cliente, ReadClienteDto>();
        CreateMap<UpdateClienteDto, Cliente>();
    }
}
