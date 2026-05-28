using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Common;
using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Com.FPTU.Prn232SE1819.Api.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    public DbSet<T> Entities => throw new NotImplementedException();

    public IApplicationDbContext ApplicationDbContext => throw new NotImplementedException();

    public Task DeleteAsync(T entity, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }

    public T Find(params object[] keyValues)
    {
        throw new NotImplementedException();
    }

    public Task<T> FindAsync(params object[] keyValues)
    {
        throw new NotImplementedException();
    }

    public Task<IList<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(T entity, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }

    public Task InsertRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
    {
        throw new NotImplementedException();
    }
}
