using AutoMapper;
using TravelerGuideApp.API.DTOs;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.API.Profiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<LocationGetDto, Location>()
                .ForMember(l => l.Id, opt => opt.MapFrom(s => s.LocationId))
                .ForMember(l => l.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(l => l.Address, opt => opt.MapFrom(s => s.Address))
                .ForMember(l => l.LocationType, opt => opt.MapFrom(s => s.LocationType))
                .ForMember(l => l.Price, opt => opt.MapFrom(s => s.Price))
                .ForMember(l => l.Latitude, opt => opt.MapFrom(s => s.Latitude))
                .ForMember(l => l.Longitude, opt => opt.MapFrom(s => s.Longitude))
                .ForMember(l => l.TravelItineraries, opt => opt.MapFrom(s => s.TravelItineraries))
                .ReverseMap();
            CreateMap<LocationPutPostDto, Location>()
                .ForMember(l => l.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(l => l.Address, opt => opt.MapFrom(s => s.Address))
                .ForMember(l => l.LocationType, opt => opt.MapFrom(s => s.LocationType))
                .ForMember(l => l.Price, opt => opt.MapFrom(s => s.Price))
                .ForMember(l => l.Latitude, opt => opt.MapFrom(s => s.Latitude))
                .ForMember(l => l.Longitude, opt => opt.MapFrom(s => s.Longitude))
                .ReverseMap();
        }
    }
}
