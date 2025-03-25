using ProductCategoryITI_API.Models;

namespace ProductCategoryITI_API.Repositories
{
    public interface IProductRepo
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void AddProd(Product product);
        public void UpdateProd( Product product);
        public void DeleteProd(Product product);
        public void Save();

    }
}
