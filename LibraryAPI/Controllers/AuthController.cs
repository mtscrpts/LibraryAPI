using LibraryAPI.Data;
using LibraryAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    public class AuthController: ControllerBase
    {
        private readonly IJwtTokenManager _jwtTokenManager;
        private readonly IUserRepository userRepository;
        public AuthController(IJwtTokenManager jwtTokenManager, IUserRepository userRepository)
        {
            _jwtTokenManager = jwtTokenManager;
            this.userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("/library/api/login")]
        public IActionResult Login([FromBody] User userCredentials)
        {
            var user = userRepository.ValidateUser(userCredentials.Name, userCredentials.Password);
            if (user != null)
            {
                var token = _jwtTokenManager.Authenticate(userCredentials.Name, userCredentials.Password);
                return Ok(new { token = token });
            }
            return Unauthorized();
        }

        //[AllowAnonymous]
        //[HttpPost("/library/api/logout")]
        //public void Logout()
        //{
        //    userRepository.Dispose();
        //}
    }
}
