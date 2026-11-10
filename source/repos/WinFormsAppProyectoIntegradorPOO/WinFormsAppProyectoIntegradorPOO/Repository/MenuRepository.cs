using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;

namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal class MenuRepository
    {
        private DbConnectionPostgreSql connection;
        private List<Menu> menus;
        private static MenuRepository instance;

        private MenuRepository()
        {
            menus = new List<Menu>();
        }

        private MenuRepository(DbConnectionPostgreSql connection)
        {
            this.connection = connection;
        }

        public static MenuRepository getInstance(DbConnectionPostgreSql connection)
        {
            if (instance is null)
            {
                instance = new MenuRepository(connection);
            }

            return instance;
        }

        public void update(int id, string detail)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "UPDATE menu SET detail = @detail WHERE id = @id";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@detail", detail);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public void delete(int id)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "DELETE FROM menu WHERE id = @id";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public void add(Menu menu)
        {
            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "INSERT INTO menu (detail) VALUES (@detail) RETURNING id";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("@detail", menu.Detail);

            int menuId = (int)command.ExecuteScalar();

            foreach (MenuItemm item in menu.ProductList)
            {
                string sqlItem = "INSERT INTO menu_item (amount, product_id, menu_id) VALUES (@amount, @product_id, @menu_id)";

                NpgsqlCommand commandItem = new NpgsqlCommand(sqlItem, conn);
                commandItem.Parameters.AddWithValue("@amount", item.Amount);
                commandItem.Parameters.AddWithValue("@product_id", item.Product.Id);
                commandItem.Parameters.AddWithValue("@menu_id", menuId);

                commandItem.ExecuteNonQuery();
            }

            conn.Close();
        }

        public List<MenuDTO> get()
        {
            List<MenuDTO> menus = new List<MenuDTO>();

            NpgsqlConnection conn = connection.CreateConnection();
            conn.Open();

            string sql = "SELECT * FROM menu";

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int menuId = reader.GetInt32(reader.GetOrdinal("id"));
                string detail = reader.GetString(reader.GetOrdinal("detail"));

                reader.Close();

                List<MenuItemDTO> productList = new List<MenuItemDTO>();

                string sqlItems = "SELECT menu_item.id, menu_item.amount, product.id AS product_id, product.name, product.unit_price FROM menu_item INNER JOIN product ON menu_item.product_id = product.id WHERE menu_item.menu_id = @menu_id";

                NpgsqlCommand commandItems = new NpgsqlCommand(sqlItems, conn);
                commandItems.Parameters.AddWithValue("@menu_id", menuId);

                NpgsqlDataReader readerItems = commandItems.ExecuteReader();

                while (readerItems.Read())
                {
                    ProductDTO product = new ProductDTO(
                        readerItems.GetInt32(readerItems.GetOrdinal("product_id")),
                        readerItems.GetString(readerItems.GetOrdinal("name")),
                        readerItems.GetDecimal(readerItems.GetOrdinal("unit_price"))
                    );

                    MenuItemDTO menuItem = new MenuItemDTO(
                        readerItems.GetInt32(readerItems.GetOrdinal("id")),
                        readerItems.GetInt32(readerItems.GetOrdinal("amount")),
                        product
                    );

                    productList.Add(menuItem);
                }

                readerItems.Close();

                MenuDTO menu = new MenuDTO(menuId, detail, productList);
                menus.Add(menu);

                reader = command.ExecuteReader();
            }

            reader.Close();
            conn.Close();

            return menus;
        }
    }
}
