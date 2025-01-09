using AutoMapper;
using DefendersDeck.Domain.Constants;
using DefendersDeck.Domain.DTOs;
using DefendersDeck.Domain.Entities;

namespace DefendersDeck.Business.Profiles
{
    public class ModelsProfile : Profile
    {
        public ModelsProfile()
        {
            CreateMap<CardDto, Card>().ReverseMap();

            CreateMap<Card, CardForMarketDto>()
                .ForMember(dest => dest.Card, opt => opt.MapFrom(src => src))
                .ForMember(
                    dest => dest.InDeck, 
                    opt => opt.MapFrom(
                        (src, dest, _, context) => (bool)context.Items[BaseConstants.InDeckKey]
                    )
                );
        }
    }
}
