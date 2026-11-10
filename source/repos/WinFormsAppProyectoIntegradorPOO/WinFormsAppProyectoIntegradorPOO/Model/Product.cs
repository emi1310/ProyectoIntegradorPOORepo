using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class Product
    {
        private int id;
        
        private string name;
        private decimal unitPrice;

        public Product(int id, string name, decimal unitPrice)
        {
            Id = id;
            
            Name = name;
            UnitPrice = unitPrice;
        }

        public Product(string name, decimal unitPrice)
        {
             Name = name;
             UnitPrice = unitPrice;
        }

        public Product(string name)
        {
            Name = name;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                id = value;
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) { throw new NullReferenceException(); }
                name = value;
            }
        }
        
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                unitPrice = value;
            }
        }
    }

}
