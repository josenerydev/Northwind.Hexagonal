using Northwind.Application.Queries;
using Northwind.Domain.Production;

using Raven.Client.Documents;
using Raven.Client.Documents.Session;

namespace Northwind.Infrastructure.Queries
{
    public class CategoriesQueries : ICategoriesQueries
    {
        private readonly IDocumentStore _documentStore;

        public CategoriesQueries(IDocumentStore documentStore)
        {
            _documentStore = documentStore ?? throw new ArgumentNullException(nameof(documentStore));
        }

        public async Task<List<Category>> GetCategories()
        {
            using (IAsyncDocumentSession session = _documentStore.OpenAsyncSession())
            {
                return await session.Query<Category>().ToListAsync();
            }
        }
    }
}