using System;
using System.Collections.Generic;
using AutoMapper;
using DTO;
using Model;

namespace Profiles
{
    public class PhotosProfile : Profile
    {
        public PhotosProfile()
        {
            CreateMap<Model.Photos, PhotosDto>()
            .ForMember(dest => dest.PhotosId, opt => opt.MapFrom(src => src.PhotosId))
           .ForMember(dest => dest.PhotosName, opt => opt.MapFrom(src => src.PhotosName)).ForMember(dest => dest.PhotographerEmail, opt => opt.MapFrom(src => src.PhotographerEmail));
            CreateMap<PhotosDto, Model.Photos>();



















        }

    }
}