using Microsoft.EntityFrameworkCore;
using TaskMaster.Data.Entities;
namespace TaskMaster.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Tarea> Tareas { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
