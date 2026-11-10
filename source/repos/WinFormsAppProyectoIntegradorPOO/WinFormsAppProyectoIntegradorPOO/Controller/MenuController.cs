using System;
using System.Collections.Generic;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Repository.DataBase;
using WinFormsAppProyectoIntegradorPOO.Service;

namespace WinFormsAppProyectoIntegradorPOO.Controller
{
    internal class MenuController
    {
        private MenuService menuService;

        public MenuController()
        {
            menuService = new MenuService();
        }

        public void deleteMenu(MenuDTO menuDTO, DbConnectionPostgreSql conn)
        {
            menuService.deleteMenu(menuDTO, conn);
        }

        public void updateMenu(MenuDTO menuDTO, DbConnectionPostgreSql conn)
        {
            menuService.update(menuDTO, conn);
        }

        public void add(MenuDTO menuDTO, DbConnectionPostgreSql conn)
        {
            menuService.add(menuDTO, conn);
        }
    }
}
