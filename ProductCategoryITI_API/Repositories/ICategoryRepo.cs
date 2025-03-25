using ProductCategoryITI_API.Models;

namespace ProductCategoryITI_API.Repositories
{
    public interface ICategoryRepo
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(Category category);
        public void Save();
    }
}
