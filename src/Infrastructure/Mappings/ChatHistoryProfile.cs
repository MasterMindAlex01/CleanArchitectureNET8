using AutoMapper;
using Application.Interfaces.Chat;
using Application.Models.Chat;
using Infrastructure.Models.Identity;

namespace Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}