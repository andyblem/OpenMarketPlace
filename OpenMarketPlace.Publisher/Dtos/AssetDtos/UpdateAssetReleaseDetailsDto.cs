namespace OpenMarketPlace.Publisher.Dtos.AssetDtos
{
    public class UpdateAssetReleaseDetailsDto
    {
        public int Id { get; set; }

        public string License { get; set; }
        public string ReleaseNotes { get; set; }
        public string Version { get; set; }

        public List<string?> EngineCompatibility { get; set; }
    }
}
