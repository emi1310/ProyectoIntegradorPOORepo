using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.DTO
{
    internal class MenuDTO
    {
        public int id;
        public string detail;
        public List<MenuItemDTO> productList;

        public MenuDTO(string detail, List<MenuItemDTO> productList)
        {
            this.detail = detail;
            this.productList = productList;
        }

        public MenuDTO(int id, string detail, List<MenuItemDTO> productList)
        {
            this.id = id;
            this.detail = detail;
            this.productList = productList;
        }
    }
}
