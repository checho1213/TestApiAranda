using Infraestructure.Data.Context;
using Infraestructure.Data.Entities;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class CategoryService : ICategoryService
    {

        #region Constructor

        private DataBaseContext _context;
        public CategoryService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// obtiene el listado de categorias
        /// </summary>
        /// <returns></returns>
        public List<CategoryDTO> GetAllCategories()
        {
            var query = (from e in _context.CategoryProducts
                         select new CategoryDTO()
                         {
                             Id = e.Id,
                             Name = e.Name
                         });
            return query.ToList();
        }

        #endregion
    }
}
