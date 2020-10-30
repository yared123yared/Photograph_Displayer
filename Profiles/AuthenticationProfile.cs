using AutoMapper;
using DTO;

namespace Profiles
{
    public class AuthenticationProfile : Profile
    {
        public AuthenticationProfile()
        {
            CreateMap<Model.Photographer, AuthenticationDto>()
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));
            CreateMap<AuthenticationDto, Model.Photographer>();



















        }

    }
}