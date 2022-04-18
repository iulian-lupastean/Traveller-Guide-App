using AutoMapper;
using TravelerGuideApp.API.DTOs;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.API.Profiles
{
    public class TravelItineraryProfile : Profile
    {
        public TravelItineraryProfile()
        {
            CreateMap<TravelItineraryGetDto, TravelItinerary>()
                .ForMember(ti => ti.Id, opt => opt.MapFrom(s => s.TravelId))
                .ForMember(ti => ti.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(ti => ti.Status, opt => opt.MapFrom(s => s.Status))
                .ForMember(ti => ti.TravelDate, opt => opt.MapFrom(s => s.TravelDate))
                .ForMember(ti => ti.Locations, opt => opt.MapFrom(s => s.Locations))
                .ReverseMap();
            CreateMap<TravelItineraryPutPostDto, TravelItinerary>()
                .ForMember(ti => ti.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(ti => ti.Status, opt => opt.MapFrom(s => s.Status))
                .ForMember(ti => ti.TravelDate, opt => opt.MapFrom(s => s.TravelDate))
                .ReverseMap();

        }
    }
}
