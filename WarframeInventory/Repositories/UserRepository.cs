using Microsoft.EntityFrameworkCore;
using WarframeInventory.Data;
using WarframeInventory.Models;
using WarframeInventory.Repositories.Interfaces;

namespace WarframeInventory.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SystemTasksDbContext _dbContext;
        public UserRepository(SystemTasksDbContext systemTasksDbContext) 
        { 
            _dbContext = systemTasksDbContext;
        }
        public async Task<List<UserModel>> SearchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<UserModel> AddUser(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<UserModel> SearchById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<UserModel> UpdateUser(UserModel user, int id)
        {
            UserModel userById = await SearchById(id);
            
            if(userById == null) 
            {
                throw new Exception($"User by ID: {id} Not Found.");
            }

            userById.Name = user.Name;
            userById.MasteryRank = user.MasteryRank;

            _dbContext.Users.Update(userById);
            await _dbContext.SaveChangesAsync();

            return userById;
        }
        public async Task<bool> DeleteUser(int id)
        {
            UserModel userById = await SearchById(id);

            if (userById == null)
            {
                throw new Exception($"User by ID: {id} Not Found.");
            }

            _dbContext.Users.Remove(userById);
            await _dbContext.SaveChangesAsync(true);

            return true;
        }

        

        

        
    }
}
