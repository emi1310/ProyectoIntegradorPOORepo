using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.Service;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;


namespace WinFormsAppProyectoIntegradorPOO.Controller
{
    internal class ProductController
    {
        
        private ProductService productService;

        public ProductController()
        {
            productService = new ProductService();
        }
        public void deleteProduct(ProductDTO productDTO, DbConnectionPostgreSql conn)
        {
            productService.deleteProduct(productDTO, conn);
        }
        public void updateProduct(ProductDTO productDTO, DbConnectionPostgreSql conn)
        {
            productService.update(productDTO, conn);
        }

        public void add(ProductDTO productDTO, DbConnectionPostgreSql conn)
        {
            productService.add(productDTO, conn);
        }
    }
}
