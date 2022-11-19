using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;
using System.Diagnostics;

namespace Stride3DMarketPlace.Persistance.Data
{
    public class ApplicationDbContext : IdentitySoftDeleteTimeStampDbContext<ApplicationUser>
    {
        public DbSet<Asset>? Assets { get; set; }
        public DbSet<AssetCategory>? AssetsCategories { get; set; }
        public DbSet<AssetDraft>? AssetDrafts { get; set; }
        public DbSet<AssetDraftReleaseState>? AssetDraftReleaseStates { get; set; }
        public DbSet<AssetDraftState>? AssetDraftStates { get; set; }
        public DbSet<AssetRating>? AssetRatings { get; set; }
        public DbSet<AssetReleaseState>? AssetReleaseStates { get; set; }
        public DbSet<AssetResource>? AssetResources { get; set; }
        public DbSet<AssetReview>? AssetReviews { get; set; }
        public DbSet<AssetTag>? AssetTags { get; set; }
        public DbSet<AssetType>? AssetTypes { get; set; }
        public DbSet<EngineVersion>? EngineVersions { get; set; }
        public DbSet<Publisher>? Publishers { get; set; }
        public DbSet<Tag>? Tags { get; set; }

        protected readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration, DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get data
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            Debug.WriteLine(connectionString);
            var serverVersion = ServerVersion.AutoDetect(connectionString);

            // set connection string
            optionsBuilder.UseMySql(connectionString,
                serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // asset-draft-release-state value conversions
            {
                modelBuilder
                    .Entity<Asset>()
                    .Property(e => e.AssetDraftReleaseStateId)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetDraftReleaseState>()
                    .Property(e => e.Id)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetDraftReleaseState>().HasData(
                        Enum.GetValues(typeof(AssetDraftReleaseStateEnums))
                            .Cast<AssetDraftReleaseStateEnums>()
                            .Select(e => new AssetDraftReleaseState()
                            {
                                Id = e,
                                Name = e.ToString()
                            }));
            }

            // asset-draft-state value conversions
            {
                modelBuilder
                    .Entity<Asset>()
                    .Property(e => e.AssetDraftId)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetDraftState>()
                    .Property(e => e.Id)
                    .HasConversion<int>();

                modelBuilder
                    .Entity<AssetDraftState>().HasData(
                        Enum.GetValues(typeof(AssetDraftStateEnums))
                            .Cast<AssetDraftStateEnums>()
                            .Select(e => new AssetDraftState()
                            {
                                Id = e,
                                Name = e.ToString()
                            }));
            }

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

            //modelBuilder.Entity<ApplicationUser>()
            //    .Property(a => a.PublisherId)
            //    .IsRequired(false);


            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.Publisher)
                .WithMany(p => p.ApplicationUsers);
        }
    }
}