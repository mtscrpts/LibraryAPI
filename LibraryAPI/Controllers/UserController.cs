using System.Security.Claims;

using LibraryAPI.Data;
using LibraryAPI.Repositories;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;

namespace LibraryAPI.Controllers
{
    [Authorize]
    [Route("/library/api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [Authorize]
        [HttpGet]
        [Route("/library/api/user/name")]
        public IActionResult GetUserName()
        {
            //var identity = (ClaimsIdentity)User.Identity;
            var userName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Ok(new { name = userName });
        }
    }
}
