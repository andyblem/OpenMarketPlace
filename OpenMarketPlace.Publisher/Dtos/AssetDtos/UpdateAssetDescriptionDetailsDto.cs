namespace OpenMarketPlace.Publisher.Dtos.AssetDtos
{
    public class UpdateAssetDescriptionDetailsDto
    {
        public int AssetCategoryId { get; set; }
        public int Id { get; set; }

        public string? Description { get; set; }
        public string? Name { get; set; }

        public List<string?> Keywords { get; set; }

    }
}
