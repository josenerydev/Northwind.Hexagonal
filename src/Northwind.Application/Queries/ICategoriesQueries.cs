using Northwind.Domain.Production;

namespace Northwind.Application.Queries
{
    public interface ICategoriesQueries
    {
        Task<List<Category>> GetCategories();
    }
}