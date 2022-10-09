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
                .ForMember(des=> des.stocks,
                opt=>opt.MapFrom(src=>src.Stocks.Where(s=>s.FlowerId==src.flowerId)));
            CreateMap<CreateFlowerDTO, Flower>();
            CreateMap<UpdateFlowerDTO, Flower>(); 
        }
    }
}
