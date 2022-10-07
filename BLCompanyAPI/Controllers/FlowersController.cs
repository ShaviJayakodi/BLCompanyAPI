using BLCompanyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLCompanyAPI.Services.Model;
using AutoMapper;

namespace BLCompanyAPI.Controllers
{
    [Route("api/flower")]
    [ApiController]
   
    public class FlowersController : ControllerBase
    {
        private readonly IFlowerRepo _flowerService;
        private readonly IMapper _mapper;

        public FlowersController(IFlowerRepo flowerRepo,IMapper mapper)
        {
            _flowerService = flowerRepo;
            _mapper = mapper;
           
        }

        [HttpGet]
        public ActionResult<ICollection<FlowerDTO>> GetAllFowers()
        {
            var flowers = _flowerService.AllFlowers();

          var mapped=  _mapper.Map<ICollection<FlowerDTO>>(flowers);
            return Ok(mapped);
        }

        [HttpGet("{flowerId}")]
        public ActionResult<FlowerDTO> GetFlower(int flowerId)
        {
            var flower = _flowerService.GetFlower(flowerId);
            if (flower == null)
            {
                return NotFound();
            }
            var mappedFlower= _mapper.Map<FlowerDTO>(flower);
            return Ok(mappedFlower);
        }
      
    }
}
