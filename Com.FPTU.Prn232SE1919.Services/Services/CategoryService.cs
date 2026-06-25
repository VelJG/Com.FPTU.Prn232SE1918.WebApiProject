using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Repositories;
using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Services;
using Com.FPTU.Prn232SE1918.MssqlServer.Entity.Models;
using Com.FPTU.Prn232SE1919.Services.BaseServices;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Com.FPTU.Prn232SE1919.Services.Services;

public class CategoryService : DataServiceBase<Category>, ICategoryService
{
    public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public override async Task AddAsync(Category entity)
    {
        try
        {
            await UnitOfWork.BeginTransactionAsync();

            await UnitOfWork.Repository<Category>()
            .InsertAsync(entity);
            
            await UnitOfWork.CommitTransactionAsync();
        }
        catch (Exception ex)
        {
            await UnitOfWork.RollbackTransactionAsync();
            throw;
        }
    }

    public override Task DeleteAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public override Task DeleteAsync(Category entity)
    {
        throw new NotImplementedException();
    }

    public override async Task<IList<Category>> GetAllAsync()
      => await UnitOfWork.Repository<Category>()
            .Entities
            .ToListAsync<Category>();

    public override async Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>> predicate)
     => await UnitOfWork.Repository<Category>()
            .Entities
            .Where(predicate)
            .ToListAsync();

    public override async Task<Category> GetOneAsync(int? id)
      => await UnitOfWork.Repository<Category>()
                 .FindAsync(id);

    public override Task UpdateAsync(Category entity)
    {
        throw new NotImplementedException();
    }
}
