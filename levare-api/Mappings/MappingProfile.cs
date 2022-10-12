using AutoMapper;
using Levare.Data.Entities;
using Levare.Dtos;

namespace Levare.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Report, ReportDto>().ReverseMap();
        CreateMap<Report, ReportCreateDto>().ReverseMap();
        CreateMap<Report, ReportUpdateDto>().ReverseMap();
    }
}