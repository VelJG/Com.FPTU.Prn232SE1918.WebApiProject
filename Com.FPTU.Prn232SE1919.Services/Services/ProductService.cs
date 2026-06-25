
using Com.FPTU.Prn232SE1819.Api.Caching;
using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Repositories;
using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Services;
using Com.FPTU.Prn232SE1918.MssqlServer.Entity.Models;
using Com.FPTU.Prn232SE1919.Services.BaseServices;
using System.Linq.Expressions;

namespace Com.FPTU.Prn232SE1919.Services.Services;

public class ProductService : DataServiceBase<Product>, IProductService
{
    private readonly IDataCached dataCached;

    public ProductService(IUnitOfWork unitOfWork, IDataCached dataCached) : base(unitOfWork)
    {
        this.dataCached = dataCached;
    }

    public override Task AddAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public override Task DeleteAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public override Task DeleteAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public override Task<IList<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<Product> GetOneAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }
}
