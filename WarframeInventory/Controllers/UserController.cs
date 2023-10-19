using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarframeInventory.Models;
using WarframeInventory.Repositories.Interfaces;

namespace WarframeInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> SearchAllUsers()
        {
            List<UserModel> users = await _userRepository.SearchAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> SearchById(int id)
        {
            UserModel user = await _userRepository.SearchById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> Register([FromBody] UserModel userModel)
        {
            UserModel user = await _userRepository.AddUser(userModel);
            return Ok(user);
        }
    }
}
