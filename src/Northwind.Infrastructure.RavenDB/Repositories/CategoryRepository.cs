using Northwind.Application.Repositories;
using Northwind.Domain.Production;

using Raven.Client.Documents;

namespace Northwind.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryReadOnlyRepository, ICategoryWriteOnlyRepository
    {
        private readonly IDocumentStore _documentStore;

        public CategoryRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        public async Task<string> Add(Category category)
        {
            using var session = _documentStore.OpenAsyncSession();
            Entities.Category categoryEntity = new Entities.Category
            {
                Name = category.Name.ToString(),
                Description = category.Description.ToString()
            };

            await session.StoreAsync(categoryEntity);
            await session.SaveChangesAsync();

            return categoryEntity.Id;
        }

        public Task<Category> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Category category)
        {
            throw new NotImplementedException();
        }

        public Task Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}