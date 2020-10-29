using AutoMapper;
using DTO;

namespace Profiles
{
    public class PhotographerProfile : Profile
    {
        public PhotographerProfile()
        {
            CreateMap<Model.Photographer, PhotographerDto>()
            .ForMember(dest => dest.PhotographerId, opt => opt.MapFrom(src => src.PhotographerId))
           .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FName))
           .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LName))
           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.WorkTitle, opt => opt.MapFrom(src => src.WorkTitle))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
            .ForMember(dest => dest.ProfilePictureName, opt => opt.MapFrom(src => src.ProfilePictureName))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender));
            CreateMap<PhotographerDto, Model.Photographer>();








        }

    }
}