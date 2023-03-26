namespace OpenMarketPlace.Publisher.Dtos.AssetDownLoadLinkDtos
{
    public class UpdateAssetDownloadLinkDto
    {
        public bool IsActive { get; set; }

        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Url { get; set; }

        public string? ModifiedById { get; set; }
    }
}
