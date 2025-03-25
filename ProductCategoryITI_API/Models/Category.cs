using System.Text.Json.Serialization;

namespace ProductCategoryITI_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Product>? Product { get; set; }
    }
}
