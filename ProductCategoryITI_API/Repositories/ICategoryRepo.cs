using ProductCategoryITI_API.Models;

namespace ProductCategoryITI_API.Repositories
{
    public interface ICategoryRepo
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void AddProd(Category category);
        public void UpdateProd(Category category);
        public void DeleteProd(Category category);
        public void Save();
    }
}
