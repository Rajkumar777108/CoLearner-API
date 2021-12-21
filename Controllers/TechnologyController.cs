using System.Linq;
using CoLearner.API.Data;
using Microsoft.AspNetCore.Mvc;
namespace CoLearner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TechnologyController : ControllerBase
    {
        private readonly DBEntity dbEntity;

        public TechnologyController(DBEntity dbEntity)
        {
            this.dbEntity = dbEntity;
        }
        [HttpGet]
        public IActionResult GetTechnologies()
        {
            var tech= this.dbEntity.Teches.ToList();
            return Ok(tech);
        }
    }
}