using Microsoft.AspNetCore.Mvc;

using Northwind.Application.Commands.CreateCategory;
using Northwind.Domain.Production;
using Northwind.WebApi.Model;

namespace Northwind.WebApi.UseCases.CreateCategory
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICreateCategoryUseCase _createCategoryUseCase;

        public CategoriesController(ICreateCategoryUseCase createCategoryUseCase)
        {
            _createCategoryUseCase = createCategoryUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryRequest request)
        {
            var category = new Category(request.Name, request.Description);

            CategoryResult result = await _createCategoryUseCase.Execute(category);

            //return StatusCode(StatusCodes.Status201Created);
            return Ok(new CategoryModel(result.Id, result.Name, result.Description));
        }
    }
}