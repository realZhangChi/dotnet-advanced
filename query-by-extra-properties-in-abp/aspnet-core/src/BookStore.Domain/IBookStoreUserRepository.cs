using System;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace BookStore;

public interface IBookStoreUserRepository : IRepository<IdentityUser, Guid>
{
    Task<IdentityUser> GetUserByGenderAsync(string gender);
}