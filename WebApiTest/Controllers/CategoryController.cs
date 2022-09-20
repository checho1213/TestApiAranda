using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CategoryController : Controller
    {

        ICategoryService _service;
        public CategoryController(ICategoryService service) {
            _service = service;
        }

        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <returns>list of categories.</returns>
        [HttpGet]
        
        public ActionResult Get()
        {
            var data = _service.GetAllCategories();
            return Ok(data);
        } 
    }
}
