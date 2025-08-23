using AutoMapper;
using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using BNP.CMM.Domain.DTO;
using BNP.CMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.CMM.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FunctionManualMovementsResult, GetManualMovementsResponse>().ReverseMap();
        }
    }
}
