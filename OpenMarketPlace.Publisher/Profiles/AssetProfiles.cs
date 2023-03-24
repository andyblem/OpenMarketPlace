using AutoMapper;
using Newtonsoft.Json;
using NuGet.Protocol;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;
using System.Text.Json;

namespace OpenMarketPlace.Publisher.Profiles
{
    public class AssetProfiles : Profile
    {
        public AssetProfiles()
        {
            CreateMap<CreateAssetDto, Asset>();
            CreateMap<UpdateAssetDescriptionDetailsDto, Asset>()
                .ForMember(dest => dest.Keywords,
                    m => m.MapFrom(src => JsonConvert.SerializeObject(src.Keywords))
                );
            CreateMap<UpdateAssetReleaseDetailsDto, Asset>().ForMember(dest => dest.EngineCompatibility,
                    m => m.MapFrom(src => JsonConvert.SerializeObject(src.EngineCompatibility))
                );
        }
    }
}
