using AutoMapper;
using CaseItau.API.src.Application.DTOs;
using CaseItau.API.src.Domain.Entities;

namespace CaseItau.API.src.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fundo, FundoDTO>().ReverseMap();
        }
    }
}
