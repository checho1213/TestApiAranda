using Infraestructure.Data.Context;
using Infraestructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class ProductService : IProductService
    {

        #region Constructor

        private DataBaseContext _context;
        public ProductService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// lista todas las productos
        /// </summary>
        /// <returns></returns>
        public List<ProductDTO> GetAllProducts()
        {

            var query = (from c in _context.Products.Include("Category")
                         select new ProductDTO()
                         {
                             CategoryId = c.CategoryId,
                             CategoryName = c.Category.Name,
                             Description = c.Description,
                             Name = c.Name,
                             Id = c.Id
                         });
            return query.ToList();


        }

        /// <summary>
        /// Obtiene las productos por filtro
        /// </summary>
        /// <returns></returns>
        public List<ProductDTO> GetProductsByFilter(string name, string desciption, int category)
        {

            var query = (from c in _context.Products.Include("Category")
                         select new ProductDTO()
                         {
                             CategoryId = c.CategoryId,
                             CategoryName = c.Category.Name,
                             Description = c.Description,
                             Name = c.Name,
                             Id = c.Id
                         }).ToList();

            query = !string.IsNullOrEmpty(name) ? query.Where(e => e.Name.ToUpper().Contains(name.ToUpper())).ToList() : query;
            query = !string.IsNullOrEmpty(desciption) ? query.Where(e => e.Description.ToUpper().Contains(desciption.ToUpper())).ToList() : query;
            query = category != 0 ? query.Where(e => e.CategoryId == category).ToList() : query;
            return query;
        }

        /// <summary>
        /// crea una producto
        /// </summary>
        /// <returns></returns>
        public bool SaveProduct(ProductDTO product)
        {
            try
            {
                Products productSave = new Products();

                productSave.CategoryId = product.CategoryId;
                productSave.Name = product.Name;
                productSave.Description = product.Description;
                _context.Products.Add(productSave);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// actualiza el producto
        /// </summary>
        /// <returns></returns>
        public bool UpdateProduct(ProductDTO product)
        {
            try
            {
                var productQuery = (from e in _context.Products
                                    where e.Id == product.Id
                                    select e).FirstOrDefault();

                productQuery.CategoryId = product.CategoryId;
                productQuery.Name = product.Name;
                productQuery.Description = product.Description;
                _context.Entry(productQuery).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
    }
}
