using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProductCategoryITI_API.Models;
using System.Data.Common;

namespace ProductCategoryITI_API.Container
{
    public class ITIStockContext : DbContext
    {
        public ITIStockContext() { }
        public ITIStockContext(DbContextOptions options): base(options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
