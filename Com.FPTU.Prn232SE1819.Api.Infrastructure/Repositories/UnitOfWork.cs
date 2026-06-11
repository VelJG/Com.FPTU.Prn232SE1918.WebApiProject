using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Common;
using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace Com.FPTU.Prn232SE1819.Api.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    //1. Thuộc tính or field để lưu trữ instance của ApplicationDbContext
    //Cau truc se luu cac repository tuong ung voi moi entity (customers => CustomerRepo,...)
    private Dictionary<string, Object> Repositories { get; }
    private IDbContextTransaction _transaction;
    private IsolationLevel? _isolationLevel;

    /*
     * private set: chỉ có thể set giá trị cho ApplicationDbContext bên trong lớp UnitOfWork,
                    bên ngoài không thể set được
     */
    public IApplicationDbContext ApplicationDbContext{ get; private set; } 
    //2. Constructors
    public UnitOfWork(IApplicationDbContext applicationDbContext)
    {
        ApplicationDbContext = applicationDbContext;
        Repositories = new Dictionary<string, dynamic>();

    }


    public IRepository<T> Repository<T>() where T : class
    {
        throw new NotImplementedException();
    }

    public async Task BeginTransactionAsync()
    {
        if (_transaction == null)
        {
            _transaction = _isolationLevel.HasValue ?
                await ApplicationDbContext.DbContext.Database.BeginTransactionAsync(_isolationLevel.GetValueOrDefault()) :
                await ApplicationDbContext.DbContext.Database.BeginTransactionAsync();
        }
    }

    public Task CommitTransactionAsync()
    {
        throw new NotImplementedException();
    }

    public Task RollbackTransactionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
