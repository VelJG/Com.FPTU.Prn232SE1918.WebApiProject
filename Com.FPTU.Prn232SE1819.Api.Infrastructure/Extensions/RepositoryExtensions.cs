using Com.FPTU.Prn232SE1918.Api.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Com.FPTU.Prn232SE1819.Api.Infrastructure.Extensions;

public static class RepositoryExtensions
{
    /*
     1. Ham loc ra cac doi tuong thoa man mot tieu chi nao do
     */
    public static IQueryable<T> Where<T>(this IRepository<T> repository, 
        Expression<Func<T, bool>> predicate) where T : class
       => repository.Entities.Where(predicate);

    /*
    * 2. ToListAsync
    */
    public static Task<List<T>> ToListAsync<T>(this IRepository<T> repository) where T : class
       => repository.Entities.ToListAsync();

    public static Task<List<T>> ToListAsync<T>(this IRepository<T> repository, Expression<Func<T, bool>> predicate) where T : class
      => repository.Entities.Where(predicate).ToListAsync();
}
