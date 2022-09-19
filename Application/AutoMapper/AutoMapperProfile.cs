using Application.ViewModels;
using AutoMapper;
using Domain.Commands.Requests;
using Domain;

namespace Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<RequestUsuarioViewModel, CreateUsuarioRequest>().ReverseMap();
            CreateMap<RequestUsuarioViewModel, UpdateUsuarioRequest>().ReverseMap();
            
            CreateMap<ResponseUsuarioViewModel, UsuarioResponse>().ReverseMap();
        }
    }
}
