using Microsoft.AspNetCore.Mvc;

using Northwind.Application.Queries;

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
            return Ok(await _categoriesQueries.GetCategories());
        }
    }
}