using AutoMapper;
using CarAuctionSite.AuctionService.Data;
using CarAuctionSite.AuctionService.DTOS;
using CarAuctionSite.AuctionService.Entities;

namespace CarAuctionSite.AuctionService.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
            CreateMap<Item, AuctionDto>();
            CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
            CreateMap<CreateAuctionDto, Item>();
        }
    }
}