using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCategoryITI_API.Models;
using ProductCategoryITI_API.Repositories;

namespace ProductCategoryITI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo categoryRepo;

        public CategoryController(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Category> categories = categoryRepo.GetAll();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Category category = categoryRepo.GetById(id);
            if (category != null)
            {
                return Ok(category);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryRepo.AddCategory(category);
            categoryRepo.Save();
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateCategory(int id , Category Newcategory)
        {
            Category DbCategory = categoryRepo.GetById(id);
            if (DbCategory != null)
            {
                DbCategory.Name = Newcategory.Name;
                categoryRepo.UpdateCategory(DbCategory);
                categoryRepo.Save();
                return NoContent();

            }
            return NotFound();
            
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            Category DbCategory = categoryRepo.GetById(id);
            if (DbCategory != null)
            {
                categoryRepo.DeleteCategory(DbCategory);
                categoryRepo.Save();
                return NoContent();

            }
            return NotFound();
        }
    }
}
