using AutoMapper;
using Stride3DMarketPlace.Persistance.Models;
using Stride3DMarketPlace.Seller.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Seller.Profiles
{
    public class AssetProfiles : Profile
    {
        public AssetProfiles()
        {
            CreateMap<CreateAssetDto, Asset>();
        }
    }
}
