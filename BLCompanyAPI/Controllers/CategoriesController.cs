using AutoMapper;
using BLCompanyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLCompanyAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepo _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryRepo categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
    }
}
