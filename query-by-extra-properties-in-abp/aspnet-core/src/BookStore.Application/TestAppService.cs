using System;
using System.Linq;
using System.Threading.Tasks;

using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace BookStore;

public class BookStoreUserAppService : BookStoreAppService, IBookStoreUserAppService
{
    public IBookStoreUserRepository UserRepository =>
        LazyServiceProvider.LazyGetRequiredService<IBookStoreUserRepository>();

    public async Task<IdentityUserDto> GetUserByGenderAsync()
    {
        var user = await UserRepository.GetUserByGenderAsync("Male");
        return ObjectMapper.Map<IdentityUser, IdentityUserDto>(user);
    }
}