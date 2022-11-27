using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stride3dMarketplace.Persistance.Enums;
using Stride3dMarketplace.Persistance.Models;
using System.Diagnostics;

namespace Stride3dMarketplace.Persistance.Data
{
    public class ApplicationDbContext : IdentitySoftDeleteTimeStampDbContext<ApplicationUser>
    {
        public DbSet<Asset>? Assets { get; set; }
        public DbSet<AssetCategory>? AssetsCategories { get; set; }
        public DbSet<AssetDraft>? AssetDrafts { get; set; }
        public DbSet<AssetDraftStatus>? AssetDraftStatuses { get; set; }
        public DbSet<AssetRating>? AssetRatings { get; set; }
        public DbSet<AssetDownloadLink>? AssetResources { get; set; }
        public DbSet<AssetStatus>? AssetReleaseStates { get; set; }
        public DbSet<AssetReview>? AssetReviews { get; set; }
        public DbSet<AssetTag>? AssetTags { get; set; }
        public DbSet<EngineVersion>? EngineVersions { get; set; }
        public DbSet<Publisher>? Publishers { get; set; }
        public DbSet<Tag>? Tags { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // asset-draft-status value conversions
            {
                modelBuilder
                    .Entity<Asset>()
                    .Property(e => e.AssetStatusId)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetStatus>()
                    .Property(e => e.Id)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetStatus>().HasData(
                        Enum.GetValues(typeof(AssetStatusEnums))
                            .Cast<AssetStatusEnums>()
                            .Select(e => new AssetStatus()
                            {
                                Id = e,
                                Name = e.ToString()
                            }));
            }

            // asset-draft-status value conversions
            {
                modelBuilder
                    .Entity<AssetDraft>()
                    .Property(e => e.AssetDraftStatusId)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetDraftStatus>()
                    .Property(e => e.Id)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetDraftStatus>().HasData(
                        Enum.GetValues(typeof(AssetDraftStatusEnums))
                            .Cast<AssetDraftStatusEnums>()
                            .Select(e => new AssetDraftStatus()
                            {
                                Id = e,
                                Name = e.ToString()
                            }));
            }

            //// asset-release-state value conversions
            //{
            //    modelBuilder
            //        .Entity<Asset>()
            //        .Property(e => e.AssetStatusId)
            //        .HasConversion<int>();

            //    modelBuilder
            //        .Entity<AssetStatus>()
            //        .Property(e => e.Id)
            //        .HasConversion<int>();

            //    modelBuilder
            //        .Entity<AssetStatus>().HasData(
            //            Enum.GetValues(typeof(AssetStatusEnums))
            //                .Cast<AssetStatusEnums>()
            //                .Select(e => new AssetStatus()
            //                {
            //                    Id = e,
            //                    Name = e.ToString()
            //                }));
            //}

            //modelBuilder.Entity<ApplicationUser>()
            //    .Property(a => a.PublisherId)
            //    .IsRequired(false);


            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.Publisher)
                .WithMany(p => p.ApplicationUsers);
        }
    }
}