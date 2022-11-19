using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;

namespace Stride3DMarketPlace.Seller.Data
{
    public class SellerDbContext : IdentitySoftDeleteTimeStampDbContext<ApplicationUser>
    {
        public DbSet<Asset>? Assets { get; set; }
        public DbSet<AssetCategory>? AssetsCategories { get; set; }
        public DbSet<AssetResource>? AssetResources { get; set; }
        public DbSet<AssetType>? AssetTypes { get; set; }
        public DbSet<Publisher>? Publishers { get; set; }


        public SellerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // application user publisher
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.Publisher)
                .WithMany(p => p.ApplicationUsers);
        }
    }
}
