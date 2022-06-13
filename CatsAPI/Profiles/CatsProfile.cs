using AutoMapper;
using CatsAPI.Dtos;
using CatsAPI.Models;

namespace CatsAPI.Profiles
{
    public class CatsProfile : Profile
    {
        public CatsProfile()
        {
            CreateMap<Cat, CatReadDto>();
            CreateMap<CatCreateDto, Cat>();
        }
    }
}