using DigitalAssetManager.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;

namespace DigitalAssetManager.Api.Interfaces
{
    public interface IDigitalAssetManagerDbContext
    {
        DbSet<DigitalAsset> DigitalAssets { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
