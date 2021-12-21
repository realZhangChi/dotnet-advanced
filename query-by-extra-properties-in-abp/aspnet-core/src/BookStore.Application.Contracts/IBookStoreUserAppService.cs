using System.Threading.Tasks;

using Volo.Abp.Identity;

namespace BookStore;

public interface IBookStoreUserAppService
{
    Task<IdentityUserDto> GetUserByGenderAsync();
}