using Northwind.Domain.Production;

namespace Northwind.Application.Commands.CreateCategory
{
    public sealed class CategoryResult
    {
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }

        public CategoryResult(string id, Name name, Description description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}