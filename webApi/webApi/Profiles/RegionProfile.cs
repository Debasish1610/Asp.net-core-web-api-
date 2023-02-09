using AutoMapper;
using webApi.Models.Domain;
using webApi.Models.DTO;

namespace webApi.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile() {
            CreateMap<Region, RegionDto>().ReverseMap();
        }
    }
}
