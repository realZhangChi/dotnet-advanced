using System;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;

namespace BookStore;

public interface IBookRepository : IRepository<Book, Guid>
{
    Task<Book> GetByAuthorAsync(string authorName);
}