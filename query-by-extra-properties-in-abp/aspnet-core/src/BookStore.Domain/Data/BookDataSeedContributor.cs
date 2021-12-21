using System.Threading.Tasks;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace BookStore.Data;

public class BookDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IBookRepository _bookRepository;

    public BookDataSeedContributor(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [UnitOfWork]
    public async Task SeedAsync(DataSeedContext context)
    {
        var book1 = new Book("book1");
        var book2 = new Book("book2");
        book1.SetProperty(BookStoreConsts.BookAuthorPropertyName, "author1");
        book1.SetProperty(BookStoreConsts.BookDescriptionPropertyName, "description1");
        book2.SetProperty(BookStoreConsts.BookAuthorPropertyName, "author2");
        book2.SetProperty(BookStoreConsts.BookDescriptionPropertyName, "description2");

        if (!await _bookRepository.AnyAsync(b => b.Name == book1.Name))
        {
            await _bookRepository.InsertAsync(book1);
        }
        if (!await _bookRepository.AnyAsync(b => b.Name == book2.Name))
        {
            await _bookRepository.InsertAsync(book2);
        }
    }
}