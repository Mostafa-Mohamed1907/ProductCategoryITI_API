using ProductCategoryITI_API.Container;
using ProductCategoryITI_API.Models;

namespace ProductCategoryITI_API.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly ITIStockContext context;

        public ProductRepo(ITIStockContext context)
        {
            this.context = context;
        }
        public List<Product> GetAll()
        {
            return context.Product.ToList();
        }

        public Product GetById(int id)
        {
            Product product = context.Product.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public void AddProd(Product product)
        {
            context.Add(product);
        }

        public void DeleteProd(Product product)
        {
            context.Remove(product);
        }
        public void UpdateProd(Product product)
        {
            //product = GetById(id);
            context.Update(product);
        }

        public void Save()
        {
            context.SaveChanges();
        }


    }
}
