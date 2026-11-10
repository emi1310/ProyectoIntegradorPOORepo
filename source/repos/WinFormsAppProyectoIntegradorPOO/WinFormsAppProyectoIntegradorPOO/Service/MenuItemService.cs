using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.Repository;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;

namespace WinFormsAppProyectoIntegradorPOO.Service
{
    internal class MenuItemService
    {
        public void deleteMenuItem(MenuItemDTO menuItemDTO, DbConnectionPostgreSql conn)
        {
            MenuItemRepository menuItems = MenuItemRepository.getInstance(conn);
            menuItems.delete(menuItemDTO.id);
        }

        public void createMenuItem(MenuItemDTO menuItemDTO)
        {
            Product product = new Product(
                menuItemDTO.product.name,
                menuItemDTO.product.unitPrice
            );

            MenuItemm menuItem = new MenuItemm(
                menuItemDTO.amount,
                product
            );
        }

        public void showMenuItems(DbConnectionPostgreSql conn)
        {
            MenuItemRepository menuItems = MenuItemRepository.getInstance(conn);
        }

        public void add(MenuItemDTO menuItemDTO, DbConnectionPostgreSql conn)
        {
            MenuItemRepository menuItems = MenuItemRepository.getInstance(conn);

            Product product = new Product(
                menuItemDTO.product.name,
                menuItemDTO.product.unitPrice
            );

            MenuItemm menuItem = new MenuItemm(
                menuItemDTO.amount,
                product
            );

            menuItems.add(menuItem);
        }

        public void update(MenuItemDTO menuItemDTO, DbConnectionPostgreSql conn)
        {
            MenuItemRepository menuItems = MenuItemRepository.getInstance(conn);

            menuItems.update(
                menuItemDTO.id,
                menuItemDTO.amount,
                menuItemDTO.product.id
            );
        }
    }
}
