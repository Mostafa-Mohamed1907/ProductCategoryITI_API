using ProductCategoryITI_API.Container;
using ProductCategoryITI_API.Models;

namespace ProductCategoryITI_API.Repositories
{

    public class CategoryRepo : ICategoryRepo
    {
        private readonly ITIStockContext context;

        public CategoryRepo(ITIStockContext context)
        {
            this.context = context;
        }
        public List<Category> GetAll()
        {
            return context.Category.ToList();
        }

        public Category GetById(int id)
        {
            Category category = context.Category.FirstOrDefault(c => c.Id == id);
            return category;
        }
        public void AddProd(Category category)
        {
            context.Add(category);
        }

        public void UpdateProd( Category category)
        {
            //category = GetById(id);
            context.Update(category);
        }

        public void DeleteProd(Category category)
        {
            context.Remove(category);
        }
        public void Save()
        {
            context.SaveChanges();
        }


    }
}
