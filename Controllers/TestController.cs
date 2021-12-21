using System.Linq;
using CoLearner.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoLearner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController : ControllerBase
    {
        private readonly DBEntity dbEntity;

        public TestController(DBEntity dbEntity)
        {
            this.dbEntity = dbEntity;
        }
        
        [HttpGet]
        public IActionResult DatafromDB()
        {
            var menu=dbEntity.Menus.ToList();
            return Ok(menu);
        }
        [HttpGet("{id}")]
        public IActionResult MenuByID(int id)
        {
            var _menu=dbEntity.Menus.FirstOrDefault(x=>x.MenuId==id);
            return Ok(_menu);
        }
        
    }
}