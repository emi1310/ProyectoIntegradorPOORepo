using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.Repository;
namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal class ProductRepository : IRepository
    {
        private DbConnectionPostgreSql conn;
        private List<Product> products;
        private static ProductRepository instance;

        private ProductRepository()
        {
            products = new List<Product>();
        }
        private ProductRepository(DbConnectionPostgreSql conn)
        {
            this.conn = conn;
        }

        public static ProductRepository getInstance(DbConnectionPostgreSql conn)
        {
            if (instance is null) { instance = new ProductRepository(conn); }
            return instance;
        }

        public void add(Product product)
        {
            products.Add(product);
        }

        public void delete()
        {

        }

        public void update()
        {

        }
        
        public void create(string name)
        {
            NpgsqlConnection conne = conn.CreateConnection();
            conne.Open();

            string sql = "INSERT INTO product (name) VALUES ($1)";

            NpgsqlCommand command = new NpgsqlCommand(sql, conne);
            command.Parameters.AddWithValue(name);

            command.ExecuteNonQuery();

            conne.Close();
        }

        public DataTable get()
        {
            NpgsqlConnection conne = conn.CreateConnection();
            conne.Open();
            string sql = "SELECT * FROM product";
            NpgsqlCommand command = new NpgsqlCommand(sql, conne);
            NpgsqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();
            conne.Close();
            return table;
        }

        public void drop()
        {

        }

        public void add()
        {

        }

        public void deleteProductFromList(int identificationCode)
        {
            Product product = FindProductByidentificationCode(identificationCode);
            products.Remove(product);
        }

        public Product FindProductByidentificationCode(int identificationCode)
        {
            foreach (Product product in products)
            {
                if (product.IdentificationCode == identificationCode)
                {
                    return product;
                } ;
            }
            return null;

        }


        /* int getLastId()
        {

        }
        */
    






    }



}
