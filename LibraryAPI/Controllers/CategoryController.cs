using LibraryAPI.Data;
using LibraryAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("library/api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("/library/api/categories")]
        public ActionResult<List<Category>> Get()
        {
            return categoryRepository.GetAll();
        }

        [HttpGet]
        [Route("/library/api/categories/{id}")]
        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        [HttpPost]
        [Route("/library/api/categories")]
        public Category Add(Category category)
        {
            return categoryRepository.Add(category);
        }

        [HttpPatch]
        [Route("/library/api/categories/{id}")]
        public Category Update(Category category)
        {
            return categoryRepository.Update(category);
        }

        [HttpDelete]
        [Route("/library/api/categories/{id}")]
        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }
    }
}
