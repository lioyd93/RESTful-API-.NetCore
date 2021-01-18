using AutoMapper;
using RESTful_API_.Models;
using RESTful_API_.Models.Dtos;
using RESTful_API_.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API_.NetCore.Mapper
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
            CreateMap<Trail, TrailDto>().ReverseMap();
            CreateMap<Trail, TrailCreateDto>().ReverseMap();
            CreateMap<Trail, TrailUpdateDto>().ReverseMap();
        }
    }
}
