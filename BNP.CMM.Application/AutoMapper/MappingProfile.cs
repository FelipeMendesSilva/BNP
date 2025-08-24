using AutoMapper;
using BNP.CMM.Application.Responses;
using BNP.CMM.Domain.DTO;

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
