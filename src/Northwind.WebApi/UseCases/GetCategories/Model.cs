using Northwind.WebApi.Model;

namespace Northwind.WebApi.UseCases.GetCategories
{
    public sealed class Model
    {
        public List<CategoryModel> Categories { get; }

        public Model(List<CategoryModel> categories)
        {
            Categories = categories;
        }
    }
}