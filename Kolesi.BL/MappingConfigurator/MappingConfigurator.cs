using AutoMapper;
using Kolesi.BL.Dto;
using Kolesi.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kolesi.BL.MappingConfigurator
{
    public class MappingConfigurator : Profile
    {
        public MappingConfigurator() {
            CreateMap<UserRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
                .ReverseMap();
            CreateMap<User, UserRegistrationDto>()
                .ForMember(u => u.Email, opt => opt.MapFrom(x => x.UserName))
                .ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(u => u.Email, opt => opt.MapFrom(x => x.UserName))
                .ReverseMap();
            CreateMap<UserDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
                .ReverseMap();
            /*CreateMap<User, UserRegistrationDto>();
            CreateMap<UserRegistrationDto, User>();*/
        }
    }
}
