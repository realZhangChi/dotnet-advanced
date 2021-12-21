using System;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;

namespace BookStore.EntityFrameworkCore;

public class BookStoreUserRepository : EfCoreRepository<BookStoreDbContext, IdentityUser, Guid>, IBookStoreUserRepository
{
    public BookStoreUserRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

public async Task<IdentityUser> GetUserByGenderAsync(string gender)
{
    
    return await (await GetDbSetAsync())
        .FromSqlRaw($"select * from AbpUsers where Gender == '{gender}'")
        .FirstOrDefaultAsync();
}
}