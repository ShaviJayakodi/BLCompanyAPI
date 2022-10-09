using BLCompanyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLCompanyAPI.Services.Model;
using AutoMapper;
using BLCompanyAPI.Models;
using BLCompanyAPI.Services.Orders;

namespace BLCompanyAPI.Controllers
{
    [Route("api/flower")]
    [ApiController]

    public class FlowersController : ControllerBase
    {
        private readonly IFlowerRepo _flowerService;
        private readonly IMapper _mapper;

        public FlowersController(IFlowerRepo flowerRepo, IMapper mapper)
        {
            _flowerService = flowerRepo;
            _mapper = mapper;

        }


        [HttpGet]
        public ActionResult<ICollection<FlowerDTO>> GetAllFowers()
        {
            var flowers = _flowerService.AllFlowers();

            var mapped = _mapper.Map<ICollection<FlowerDTO>>(flowers);
            return Ok(mapped);
        }

        [HttpGet("{flowerId}", Name = "GetFlowerById")]
        public ActionResult<FlowerDTO> GetFlowerById(int flowerId)
        {
            var flower = _flowerService.GetFlower(flowerId);
            if (flower == null)
            {
                return NotFound();
            }
            var mappedFlower = _mapper.Map<FlowerDTO>(flower);
            return Ok(mappedFlower);
        }

        [HttpGet("/getByCategoryId/{categoryId}")]
        public ActionResult<ICollection<FlowerDTO>> GetFlowerByCategoryId(int categoryId)
        {
            var flower = _flowerService.GetFlowerByCategoryId(categoryId);
            if (flower == null)
            {
                return NotFound();
            }
            var mapped = _mapper.Map<ICollection<FlowerDTO>>(flower);
            return Ok(mapped);
        }
        [HttpPost]
        public ActionResult<FlowerDTO> addNewFlower(CreateFlowerDTO flower)
        {
            var flowerEntity = _mapper.Map<Flower>(flower);
            var newFlower = _flowerService.addNewFlower(flowerEntity);
            var flowerForReturn = _mapper.Map<FlowerDTO>(newFlower);
            return CreatedAtRoute("GetFlowerById", new { flowerId = flowerForReturn.flowerId }, flowerForReturn);

        }

        [HttpPut("{flowerId}", Name = "UpdateByFlowerId")]
        public ActionResult UpdateByFlowerId(int flowerId, UpdateFlowerDTO flower)

        {
            var updateFlower = _flowerService.GetFlower(flowerId);
            if (updateFlower == null)
            {
                return NotFound();
            }
            var mappedFlower = _mapper.Map(flower, updateFlower);
            _flowerService.UpdateFlower(mappedFlower);
            return NoContent();

        }


        [HttpDelete("{flowerId}",Name = "DeleteFlowerById")]
        public ActionResult DeleteFlowerById(int flowerId)
        {
            var deleteFlower = _flowerService.GetFlower(flowerId);
            //var haveStock = _stockService.GetStocksByFlowerID(flowerId);
            if (deleteFlower == null)
            {
                return NotFound();
            }
            
            _flowerService.DeleteFlower(deleteFlower);
            return NoContent();

        }




    }
}
