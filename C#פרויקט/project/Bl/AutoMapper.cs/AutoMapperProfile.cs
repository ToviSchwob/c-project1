using Bl.AutoMapper;
using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.AutoMapper.cs
{
    internal class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Dal.Models.Appointment, Appointment>().ReverseMap();
            CreateMap<Dal.Models.Branch, Branch>().ReverseMap();
            CreateMap<Dal.Models.Client, Client>().ReverseMap();
            CreateMap<Dal.Models.Worker, Worker>().ReverseMap();


        }
    }
}
