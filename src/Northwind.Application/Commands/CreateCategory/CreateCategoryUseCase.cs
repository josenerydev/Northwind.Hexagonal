using Northwind.Application.Repositories;
using Northwind.Domain.Production;

namespace Northwind.Application.Commands.CreateCategory
{
    public class CreateCategoryUseCase : ICreateCategoryUseCase
    {
        private readonly ICategoryWriteOnlyRepository _categoryWriteOnlyRepository;

        public CreateCategoryUseCase(ICategoryWriteOnlyRepository categoryWriteOnlyRepository)
        {
            _categoryWriteOnlyRepository = categoryWriteOnlyRepository;
        }

        public async Task<CategoryResult> Execute(Category category)
        {
            var categoryId = await _categoryWriteOnlyRepository.Add(category);

            var result = new CategoryResult(categoryId, category.Name, category.Description);

            return result;
        }
    }
}