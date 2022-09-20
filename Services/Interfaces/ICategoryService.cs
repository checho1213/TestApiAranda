using Services.DTO;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        /// <summary>
        /// Obtiene el listado de categorias
        /// </summary>
        /// <returns></returns>
        List<CategoryDTO> GetAllCategories();        
    }
}
