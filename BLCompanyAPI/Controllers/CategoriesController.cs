using AutoMapper;
using BLCompanyAPI.Models;
using BLCompanyAPI.Services;
using BLCompanyAPI.Services.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

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

        [HttpGet]
        public ActionResult<ICollection<CategoryDTO>> GetAllCategories()
        {
            var categories = _categoryService.GetCategories();
            var mappedCategories = _mapper.Map<ICollection<CategoryDTO>>(categories);
            return Ok(mappedCategories);
        }


        [HttpGet("{categoryId}" ,Name = "GetCategoryById")]
        public ActionResult<CategoryDTO> GetCategoryById(int categoryId)
        {
            var category = _categoryService.GetCategory(categoryId);
            if (category == null)
            {
                return NotFound();
            }
            var mappedCategory = _mapper.Map<CategoryDTO>(category);
            return Ok(mappedCategory);
        }

        [HttpPost]
        public ActionResult<CategoryDTO> createCategory(CreateCategoryDTO category)
        {
            var newCategory = _mapper.Map<Category>(category);
            var categoryEntity = _categoryService.AddCategory(newCategory);
            var CategoryForReturn = _mapper.Map<CategoryDTO>(categoryEntity);
            //return CreatedAtRoute("GetCategoty", new { categoryId = CategoryForReturn.categoryId });
            return CreatedAtRoute("GetCategoryById", new { categoryId = CategoryForReturn.categoryId }, CategoryForReturn);
           
            }
        
    }
}
