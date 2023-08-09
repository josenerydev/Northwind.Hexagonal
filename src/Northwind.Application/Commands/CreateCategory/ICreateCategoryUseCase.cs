using Northwind.Domain.Production;

namespace Northwind.Application.Commands.CreateCategory
{
    public interface ICreateCategoryUseCase
    {
        Task<CategoryResult> Execute(Category category);
    }
}