using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductController : Controller
    {

        IProductService _service;
        public ProductController(IProductService service) {
            _service = service;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route("GetAllProducts")]

        public ActionResult Get()
        {
            var data = _service.GetAllProducts();
            return Ok(data);
        }


        /// <summary>
        /// Obtiene las productos por filtro
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route("GetProductsByFilter")]
        public ActionResult GetPropertiesByFilter(string name, string description, int category)
        {
            var data = _service.GetProductsByFilter(name,description,category);
            return Ok(data);
        }

        /// <summary>
        /// Actualiza la propiedad
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        [Route("UpdateProduct")]
        public ActionResult UpdateProduct([FromBody]ProductDTO Product)
        {
            var data = _service.UpdateProduct(Product);
            return Ok(data);
        }
        /// <summary>
        /// guarda la propiedad
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        [Route("SaveProduct")]
        public ActionResult SaveProduct([FromBody] ProductDTO Product)
        {
            var data = _service.SaveProduct(Product);
            return Ok(data);
        }
    }
}
