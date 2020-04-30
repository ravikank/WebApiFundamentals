using AutoMapper;
using Microsoft.Ajax.Utilities;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(m => m.Venue, opt => opt.MapFrom(m => m.Location.VenueName))
                .ReverseMap();

            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(x => x.Speaker, opt => opt.Ignore())
                .ForMember(c => c.Camp, opt => opt.Ignore());
        }
    }
}