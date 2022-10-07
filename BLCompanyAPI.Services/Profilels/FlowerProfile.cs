using AutoMapper;
using BLCompanyAPI.Models;
using BLCompanyAPI.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCompanyAPI.Services.Profilels
{
    public class FlowerProfile:Profile
    {
        public FlowerProfile()
        {
            CreateMap<Flower, FlowerDTO>()
                .ForMember(dest => dest.stock,
                opt => opt.MapFrom(src => src.flowerId))
                .ForMember(dest=> dest.category,
                opt=>opt.MapFrom(src=>src.Stock.quientity));
            CreateMap<CreateFlowerDTO, Flower>();
        }
    }
}
