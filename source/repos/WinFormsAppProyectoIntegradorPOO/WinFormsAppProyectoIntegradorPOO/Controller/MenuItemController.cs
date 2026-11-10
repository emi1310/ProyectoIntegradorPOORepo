using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;
using WinFormsAppProyectoIntegradorPOO.Service;

namespace WinFormsAppProyectoIntegradorPOO.Controller
{
    internal class MenuItemController
    {
        private MenuItemService menuItemService;
        public MenuItemController()
        {
            menuItemService = new MenuItemService();
        }

        public void deleteMenuItem(MenuItemDTO menuItemDTO, DbConnectionPostgreSql conn)
        {
            menuItemService.deleteMenuItem(menuItemDTO, conn);
        }

        public void updateMenuItem(MenuItemDTO menuItemDTO, DbConnectionPostgreSql conn)
        {
            menuItemService.update(menuItemDTO, conn);
        }

        public void add(MenuItemDTO menuItemDTO, DbConnectionPostgreSql conn)
        {
            menuItemService.add(menuItemDTO, conn);
        }
    }
}
}
