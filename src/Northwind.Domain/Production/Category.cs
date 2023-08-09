namespace Northwind.Domain.Production
{
    public class Category : AggregateRoot
    {
        public Description Description { get; private set; }
        public Name Name { get; private set; }

        public Category(Description description, Name name)
        {
            Description = description;
            Name = name;
        }

        public static Category Load(string id, Description description, Name name)
        {
            var category = new Category(description, name);
            category.Id = id;
            return category;
        }
    }
}