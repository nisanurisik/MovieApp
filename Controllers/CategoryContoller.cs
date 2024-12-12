using Microsoft.AspNetCore.Mvc;
using MovieApp.DataAccess.Abstracts;

namespace MovieApp.Controllers
{
    public class CategoryContoller : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryContoller(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            var ctg = await _categoryRepository.GetAllCategoriesAsync();
            return View();
        }

       
    }
}
