using AutoMapper;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.Profiles
{
    public class AssetProfiles : Profile
    {
        public AssetProfiles()
        {
            CreateMap<CreateAssetDto, Asset>();
        }
    }
}
