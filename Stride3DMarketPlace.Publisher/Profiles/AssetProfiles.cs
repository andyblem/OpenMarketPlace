using AutoMapper;
using Stride3dMarketplace.Persistance.Models;
using Stride3dMarketplace.Publisher.Dtos.AssetDtos;

namespace Stride3dMarketplace.Publisher.Profiles
{
    public class AssetProfiles : Profile
    {
        public AssetProfiles()
        {
            CreateMap<CreateAssetDto, Asset>();
        }
    }
}
