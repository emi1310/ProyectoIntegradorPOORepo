using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.DTO
{
    internal class MenuItemDTO
    {
        public int id;
        public int amount;
        public ProductDTO product;

        public MenuItemDTO(int amount, ProductDTO product)
        {
            this.amount = amount;
            this.product = product;
        }

        public MenuItemDTO(int id, int amount, ProductDTO product)
        {
            this.id = id;
            this.amount = amount;
            this.product = product;
        }
    }
}

