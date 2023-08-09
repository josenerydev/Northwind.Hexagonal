using Northwind.Domain.Production;

namespace Northwind.Application.Repositories
{
    public interface ICategoryWriteOnlyRepository
    {
        Task<string> Add(Category category);

        Task Update(Category category);

        Task Remove(Category category);
    }
}