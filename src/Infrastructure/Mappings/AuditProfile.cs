using AutoMapper;
using Infrastructure.Models.Audit;
using Application.Responses.Audit;

namespace Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}