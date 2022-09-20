using Microsoft.AspNetCore.Http;

namespace Services.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Description { get; set; }                     
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        
    }
}
