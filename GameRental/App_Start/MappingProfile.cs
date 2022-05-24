using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using GameRental.Dtos;
using GameRental.Models;

namespace GameRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<Game, GameDto>();
            Mapper.CreateMap<GameDto, Game>().ForMember(g => g.Id, opt => opt.Ignore());
            Mapper.CreateMap<Genre, GenreDto>();
        }
    }
}