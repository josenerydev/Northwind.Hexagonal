using Northwind.Domain.Production;

namespace Northwind.Application.Repositories
{
    public interface ICategoryReadOnlyRepository
    {
        Task<Category> Get(string id);
    }
}