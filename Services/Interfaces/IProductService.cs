using Services.DTO;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Obtiene el listado de productos
        /// </summary>
        /// <returns></returns>
        List<ProductDTO> GetAllProducts();

        /// <summary>
        /// crea o actualiza una producto
        /// </summary>
        /// <returns></returns>
        bool SaveProduct(ProductDTO product);

        /// <summary>
        /// actualiza una producto
        /// </summary>
        /// <returns></returns>
        bool UpdateProduct(ProductDTO product);

        /// <summary>
        /// Obtiene el listado de productos por filtros
        /// </summary>
        /// <returns></returns>
        List<ProductDTO> GetProductsByFilter(string name, string desciption, int category);
    }
}
