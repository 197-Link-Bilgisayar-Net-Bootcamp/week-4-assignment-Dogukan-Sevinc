using AutoMapper;
using System;
using System.Collections.Generic;
using System.Core.DTOs;
using System.Core.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
