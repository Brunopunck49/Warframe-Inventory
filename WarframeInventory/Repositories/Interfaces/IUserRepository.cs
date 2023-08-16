using WarframeInventory.Models;

namespace WarframeInventory.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> SearchAllUsers();
        Task<UserModel> AddUser(UserModel user);
        Task<UserModel> SearchById(int id);
        Task<UserModel> UpdateUser(UserModel user, int id);
        Task<bool> DeleteUser(int id);
    }
}
