using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Database.Models;

namespace Stride3DMarketPlace.Database.Data
{
    public class ApplicationDbContext : IdentitySoftDeleteTimeStampDbContext<ApplicationUser>
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetResource> AssetResources { get; set; }
        public DbSet<AssetReview> AssetReviews { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}