using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Entities
{
    public class Products
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public CategoryProducts Category { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
    }
}
