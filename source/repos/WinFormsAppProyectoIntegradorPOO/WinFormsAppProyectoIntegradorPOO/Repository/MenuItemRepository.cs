using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model ;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;

namespace WinFormsAppProyectoIntegradorPOO.Repository
{
   
        internal class MenuItemRepository : IRepository
        {
            private DbConnectionPostgreSql connection;
            private List<MenuItemm> menuItems;
            private static MenuItemRepository instance;

            private MenuItemRepository()
            {
            menuItems = new List<Model.MenuItemm>();
            }
            private MenuItemRepository(DbConnectionPostgreSql connection)
            {
                this.connection = connection;
            }

            public static MenuItemRepository getInstance(DbConnectionPostgreSql connection)
            {
                if (instance is null) { instance = new MenuItemRepository(connection); }
                return instance;
            }
        public void update(int id, int amount, int product_id)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "UPDATE menu_item SET amount = @amount, product_id = @product_id WHERE id = @id";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@product_id", product_id);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public void add(MenuItemm menuItem)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "INSERT INTO menu_item (amount, product_id) VALUES ($1, $2)";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue(NpgsqlTypes.NpgsqlDbType.Integer, menuItem.Amount);
            command.Parameters.AddWithValue(NpgsqlTypes.NpgsqlDbType.Integer, menuItem.Product.Id);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(int id)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "DELETE FROM menu_item WHERE id = @id";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public List<MenuItemm> get()
        {
            List<MenuItemm> menuItems = new List<MenuItemm>();

            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "SELECT menu_item.id, menu_item.amount, product.id AS product_id, product.name, product.unit_price FROM menu_item INNER JOIN product ON menu_item.product_id = product.id";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product(
                    reader.GetInt32(reader.GetOrdinal("product_id")),
                    reader.GetString(reader.GetOrdinal("name")),
                    reader.GetDecimal(reader.GetOrdinal("unit_price"))
                );

                MenuItemm menuItem = new MenuItemm(
                    reader.GetInt32(reader.GetOrdinal("id")),
                    reader.GetInt32(reader.GetOrdinal("amount")),
                    product
                );

                menuItems.Add(menuItem);
            }

            reader.Close();
            conn.Close();

            return menuItems;
        }
    }
}


