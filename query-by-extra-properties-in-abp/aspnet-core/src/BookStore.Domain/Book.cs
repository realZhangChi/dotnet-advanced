using System;

using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace BookStore;

public class Book : AggregateRoot<Guid>
{
    public string Name { get; set; }

    private Book() { }

    public Book(
        string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }
}