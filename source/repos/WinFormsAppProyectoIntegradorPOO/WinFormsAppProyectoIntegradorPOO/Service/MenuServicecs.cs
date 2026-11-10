using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;
using WinFormsAppProyectoIntegradorPOO.Repository;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;

namespace WinFormsAppProyectoIntegradorPOO.Service
{
    internal class MenuServicecs
    {
        public MenuService()
        {

        }

        public void deleteMenu(MenuDTO menuDTO, DbConnectionPostgreSql conn)
        {
            MenuRepository menus = MenuRepository.getInstance(conn);
            menus.delete(menuDTO.id);
        }

        public void createMenu(MenuDTO menuDTO)
        {
            List<MenuItemm> productList = new List<MenuItemm>();

            foreach (MenuItemDTO itemDTO in menuDTO.productList)
            {
                Product product = new Product(
                    itemDTO.product.name,
                    itemDTO.product.unitPrice
                );

                MenuItemm menuItem = new MenuItemm(
                    itemDTO.amount,
                    product
                );

                productList.Add(menuItem);
            }

            MenuModel menu = new MenuModel(menuDTO.detail, productList);
        }

        public void showMenus(DbConnectionPostgreSql conn)
        {
            MenuRepository menus = MenuRepository.getInstance(conn);
        }

        public void add(MenuDTO menuDTO, DbConnectionPostgreSql conn)
        {
            MenuRepository menus = MenuRepository.getInstance(conn);

            List<MenuItemm> productList = new List<MenuItemm>();

            foreach (MenuItemDTO itemDTO in menuDTO.productList)
            {
                Product product = new Product(
                    itemDTO.product.name,
                    itemDTO.product.unitPrice
                );

                MenuItemm menuItem = new MenuItemm(
                    itemDTO.amount,
                    product
                );

                productList.Add(menuItem);
            }

            MenuModel menu = new MenuModel(menuDTO.detail, productList);

            menus.add(menu);
        }

        public void update(MenuDTO menuDTO, DbConnectionPostgreSql conn)
        {
            MenuRepository menus = MenuRepository.getInstance(conn);
            menus.update(menuDTO.id, menuDTO.detail);
        }
    }
}

