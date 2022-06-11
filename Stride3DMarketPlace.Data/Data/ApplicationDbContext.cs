using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;

namespace Stride3DMarketPlace.Persistance.Data
{
    public class ApplicationDbContext : IdentitySoftDeleteTimeStampDbContext<ApplicationUser>
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetRating> AssetRatings { get; set; }
        public DbSet<AssetReleaseState> AssetReleaseStates { get; set; }
        public DbSet<AssetResource> AssetResources { get; set; }
        public DbSet<AssetReview> AssetReviews { get; set; }
        public DbSet<AssetTag> AssetTags { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // asset-release-state value conversions
            {
                modelBuilder
                    .Entity<Asset>()
                    .Property(e => e.AssetReleaseStateId)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetReleaseState>()
                    .Property(e => e.Id)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetReleaseState>().HasData(
                        Enum.GetValues(typeof(AssetReleaseStateEnums))
                            .Cast<AssetReleaseStateEnums>()
                            .Select(e => new AssetReleaseState()
                            {
                                Id = e,
                                Name = e.ToString()
                            }));
            }

            // asset-type value conversions
            {
                modelBuilder
                    .Entity<Asset>()
                    .Property(e => e.AssetTypeId)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetType>()
                    .Property(e => e.Id)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetType>().HasData(
                        Enum.GetValues(typeof(AssetTypeEnum))
                            .Cast<AssetTypeEnum>()
                            .Select(e => new AssetType()
                            {
                                Id = e,
                                Name = e.ToString()
                            }));
            }
        }
    }
}