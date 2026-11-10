using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;
namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal class ProductRepository : IRepository
    {
        private DbConnectionPostgreSql connection;
        private List<Product> products;
        private static ProductRepository instance;

        private ProductRepository()
        {
            products = new List<Product>();
        }
        private ProductRepository(DbConnectionPostgreSql connection)
        {
            this.connection = connection;
        }

        public static ProductRepository getInstance(DbConnectionPostgreSql connection)
        {
            if (instance is null) { instance = new ProductRepository(connection); }
            return instance;
        }

        public void update(int id, string name, decimal unit_price)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();
            string sql = "UPDATE product SET name = @name, unit_price = @unit_price WHERE id = @id";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@unit_price", unit_price);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void delete(int id)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();
            string sql = "DELETE FROM product WHERE id = @id";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void add(Product product)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();
            string sql = "INSERT INTO product (name, unit_price) VALUES ($1, $2)";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue(NpgsqlTypes.NpgsqlDbType.Varchar, product.Name);
            command.Parameters.AddWithValue(NpgsqlTypes.NpgsqlDbType.Numeric, product.UnitPrice);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<ProductDTO> get()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();
            string sql = "SELECT * FROM product";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ProductDTO product = new ProductDTO(
                reader.GetInt32(reader.GetOrdinal("id")),
                reader.GetString(reader.GetOrdinal("name")),
                reader.GetDecimal(reader.GetOrdinal("unit_price")));
                products.Add(product);
            }
            
            reader.Close();
            conn.Close();
            return products;
        }
        public void create(string name)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();
            string sql = "CREATE TABLE product (id INT SERIAL, name VARCHAR (50), unit_price DECIMAL)";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue(name);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
