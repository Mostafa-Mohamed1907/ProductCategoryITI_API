using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCategoryITI_API.Models;
using ProductCategoryITI_API.Repositories;

namespace ProductCategoryITI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;

        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> product = new List<Product>();
            product = productRepo.GetAll();
            return Ok(product);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product product = new Product();
            product = productRepo.GetById(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();

        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productRepo.AddProd(product);
            productRepo.Save();
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateProduct(int id, Product newProduct)
        {
            Product DbProduct = productRepo.GetById(id);
            if(DbProduct != null)
            {
                
                DbProduct.Name = newProduct.Name;
                DbProduct.Price = newProduct.Price;
                DbProduct.Qty = newProduct.Qty;
                DbProduct.CategoryId = newProduct.CategoryId;
                productRepo.UpdateProd(DbProduct);
                productRepo.Save();
                return Ok(DbProduct);
            }
            return NotFound();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            Product product = productRepo.GetById(id);
            if (product != null)
            {
                productRepo.DeleteProd(product);
                productRepo.Save();
                return NoContent();
            }
            return NotFound();

        }

    }
}
