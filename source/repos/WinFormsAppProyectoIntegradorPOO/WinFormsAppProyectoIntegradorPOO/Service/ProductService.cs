using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.Repository;
using System.Data;
using Npgsql;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;

namespace WinFormsAppProyectoIntegradorPOO.Service
{
    internal class ProductService
    {
        public ProductService()
        {

        }

        public void deleteProduct(ProductDTO productDTO, DbConnectionPostgreSql conn)
        {
            ProductRepository products = ProductRepository.getInstance(conn);
            products.delete(productDTO.id);
        }
        public void createProduct(ProductDTO productDTO)
        {
            Product product = new Product(productDTO.name, productDTO.unitPrice);

        }

        public void showProducts(DbConnectionPostgreSql conn)
        {
            ProductRepository products = ProductRepository.getInstance(conn);
        }
        public void add(ProductDTO productDTO, DbConnectionPostgreSql conn)
        {
            ProductRepository products = ProductRepository.getInstance(conn);
            Product product = new Product(productDTO.name, productDTO.unitPrice);
            products.add(product);
        }
        public void update(ProductDTO productDTO, DbConnectionPostgreSql conn)
        {
            ProductRepository products = ProductRepository.getInstance(conn);
            products.update(productDTO.id,productDTO.name, productDTO.unitPrice );
        }
    }
}
