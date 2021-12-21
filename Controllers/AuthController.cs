using System.Threading.Tasks;
using CoLearner.API.Data;
using CoLearner.API.DTOs;
using CoLearner.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoLearner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserDTOs userdto)
        {
            userdto.UserName= userdto.UserName.ToLower();
            if(await _repo.UserExist(userdto.UserName))
                return BadRequest("User Already Exist");

            var user=new User
            {
                UserName= userdto.UserName,
                Name=userdto.Name,
                Email = userdto.Email,
                Mobile = userdto.Mobile
            };
            var createdUser=await _repo.Register(user,userdto.Password);
            return StatusCode(201);
        }        
    }
}