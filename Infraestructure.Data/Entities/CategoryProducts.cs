using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Data.Entities
{
    public class CategoryProducts
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
         
    }
}
