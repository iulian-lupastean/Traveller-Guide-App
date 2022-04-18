using AutoMapper;
using TravelerGuideApp.API.DTOs;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserGetDto, User>()
                .ForMember(u => u.Id, opt => opt.MapFrom(s => s.UserId))
                .ForMember(u => u.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(u => u.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(u => u.Email, opt => opt.MapFrom(s => s.Email))
                .ForMember(u => u.UserType, opt => opt.MapFrom(s => s.UserType))
                .ForMember(u => u.TravelItineraries, opt => opt.MapFrom(s => s.TravelItineraries))
                .ReverseMap();
            CreateMap<UserPutPostDto, User>()
                .ForMember(u => u.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(u => u.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(u => u.Email, opt => opt.MapFrom(s => s.Email))
                .ForMember(u => u.Password, opt => opt.MapFrom(s => s.Password))
                .ForMember(u => u.UserType, opt => opt.MapFrom(s => s.UserType))
                .ReverseMap();

        }
    }
}
