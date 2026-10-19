using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;

namespace WinFormsAppProyectoIntegradorPOO.Service
{
    internal class ProductService
    {
        public ProductService()
        {

        }

        public void createProduct(ProductDTO productDTO)
        {
            Product product = new Product(productDTO.identificationCode, productDTO.name, productDTO.unitPrice);














        }
    }
}
