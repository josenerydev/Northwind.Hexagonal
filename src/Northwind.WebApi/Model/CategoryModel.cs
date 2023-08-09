namespace Northwind.WebApi.Model
{
    public sealed class CategoryModel
    {
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }

        public CategoryModel(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}