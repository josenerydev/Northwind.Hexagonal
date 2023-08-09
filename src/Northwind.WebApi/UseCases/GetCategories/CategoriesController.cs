using Microsoft.AspNetCore.Mvc;

using Northwind.Application.Queries;
using Northwind.WebApi.Model;

namespace Northwind.WebApi.UseCases.GetCategories
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesQueries _categoriesQueries;

        public CategoriesController(ICategoriesQueries categoriesQueries)
        {
            _categoriesQueries = categoriesQueries;
        }

        [HttpGet(Name = "GetCategories")]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoriesQueries.GetCategories();

            var categoryModels = categories.Select(category =>
                new CategoryModel(
                    category.Id,
                    category.Name.ToString(),
                    category.Description.ToString()
                )
            ).ToList();

            var responseModel = new Model(categoryModels);

            return Ok(responseModel);
        }
    }
}