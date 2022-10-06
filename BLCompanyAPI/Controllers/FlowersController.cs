
using BLCompanyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLCompanyAPI.Controllers
{
    [Route("api/flower")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private readonly IFlowerRepo _flowerService;

        public FlowersController(IFlowerRepo flowerRepo)
        {
            _flowerService = flowerRepo;
        }

        [HttpGet]
       public IActionResult GetFlowers()
        {
            var myFlwer = _flowerService.AllFlowers();
            return Ok(myFlwer);
        }

      
    }
}
