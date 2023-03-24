using AutoMapper;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDownLoadLinkDtos;

namespace OpenMarketPlace.Publisher.Profiles
{
    public class AssetDownloadLinkProfiles : Profile
    {

        public AssetDownloadLinkProfiles()
        {
            CreateMap<CreateAssetDownloadLinkDto, AssetDownloadLink>();
        }
    }
}
