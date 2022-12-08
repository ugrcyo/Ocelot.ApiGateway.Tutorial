using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserApi.Data;
using UserApi.Models;

namespace UserApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult<List<GetUserResponseModel>> Get()
        {
            var users=DataHelper.GetUsers();    
            return Ok(users);
        }
    }
}
