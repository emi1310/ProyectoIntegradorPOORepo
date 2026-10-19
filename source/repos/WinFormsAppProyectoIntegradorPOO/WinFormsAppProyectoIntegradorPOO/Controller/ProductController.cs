using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.Service;
using WinFormsAppProyectoIntegradorPOO.DTO;


namespace WinFormsAppProyectoIntegradorPOO.Controller
{
    internal class ProductController
    {
        private ProductService productService;

        public ProductController()
        {
            productService = new ProductService();
        }

        public void createProduct(ProductDTO productDTO)
        {
            productService.createProduct(productDTO);
        }

    }
}
