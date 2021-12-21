using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BookStore.EntityFrameworkCore;

public class BookRepository : EfCoreRepository<BookStoreDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<Book> GetByAuthorAsync(string authorName)
    {
        throw new NotImplementedException();
    }
}