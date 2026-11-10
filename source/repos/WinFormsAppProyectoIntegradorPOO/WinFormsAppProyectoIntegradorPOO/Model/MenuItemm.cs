using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class MenuItemm
    {
        private int id;
        private int amount;
        private Product product;

        public MenuItemm(int id, int amount, Product product)
        {
            Id = id;
            Amount = amount;
            this.product = product;
        }
        public MenuItemm(int amount, Product product)
        {
            Amount = amount;
            this.product = product;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0) { throw new Exception();}
                id = value;
            }
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                amount = value;
            }
        }
        public Product Product
        {
            get { return product;}
        }
                   
    }
}
