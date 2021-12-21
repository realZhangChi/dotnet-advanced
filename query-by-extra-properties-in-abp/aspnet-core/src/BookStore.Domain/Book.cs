using System;

using Volo.Abp.Domain.Entities;

namespace BookStore;

public class BookStore : AggregateRoot<Guid>
{
    public string Name { get; set; }
}