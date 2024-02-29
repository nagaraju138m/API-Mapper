using apiSample.Models;
using AutoMapper;
using Repository.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<sBooks, sbookDto>().ReverseMap();
            CreateMap<book, bookDto>().ReverseMap();    
        }
    }
}
