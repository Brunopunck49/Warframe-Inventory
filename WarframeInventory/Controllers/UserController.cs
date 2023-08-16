using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarframeInventory.Models;

namespace WarframeInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> SearchAllUsers()
        {
            return Ok();
        }
    }
}
