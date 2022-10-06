using BLCompanyAPI.Model;
using BLCompanyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLCompanyAPI.Controllers
{
    [Route("api/flower")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private FlowerService _flowerService;

        public FlowersController()
        {
            _flowerService = new FlowerService();
        }

        [HttpGet]
       public IActionResult GetFlowers()
        {
            var myFlwer = _flowerService.AllFlowers();
            return Ok(myFlwer);
        }

      
    }
}
