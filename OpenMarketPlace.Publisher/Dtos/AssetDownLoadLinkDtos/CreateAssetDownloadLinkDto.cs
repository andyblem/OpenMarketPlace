namespace OpenMarketPlace.Publisher.Dtos.AssetDownLoadLinkDtos
{
    public class CreateAssetDownloadLinkDto
    {
        public int AssetId { get; set; }

        public string? Name { get; set; }
        public string? Url { get; set; }

        public string? CreatedById { get; set; }
    }
}
