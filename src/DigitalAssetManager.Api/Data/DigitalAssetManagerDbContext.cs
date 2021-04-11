using DigitalAssetManager.Api.Models;
using DigitalAssetManager.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigitalAssetManager.Api.Data
{
    public class DigitalAssetManagerDbContext : DbContext, IDigitalAssetManagerDbContext
    {
        public DbSet<DigitalAsset> DigitalAssets { get; private set; }
        public DigitalAssetManagerDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DigitalAssetManagerDbContext).Assembly);
        }

    }
}
