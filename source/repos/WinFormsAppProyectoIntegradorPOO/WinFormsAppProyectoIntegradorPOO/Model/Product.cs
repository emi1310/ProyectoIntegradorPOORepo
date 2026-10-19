using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class Product
    {
        private int id;
        private int identificationCode; 
        private string name;
        private decimal unitPrice;

        public Product(int id, int identificationCode, string name, decimal unitPrice)
        {
            int Id = id;
            int IdentificationCode = identificationCode;
            string Name = name;
            decimal UnitPrice = unitPrice;
        }

        public Product(int identificationCode,string name, decimal unitPrice)
        {
            int IdentificationCode = identificationCode;
            string Name = name;
            decimal UnitPrice = unitPrice;
        }

        public Product(int identificationCode,string name)
        {
            int IdentificationCode = identificationCode;
            string Name = name;
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

        public int IdentificationCode
        {
            get { return identificationCode; }
            set
            {
                if (value >= 0) { identificationCode = value; }
                throw new Exception();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value is string) { name = value; }
                throw new Exception();
            }
        }
        
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value > 0) { unitPrice = value; }
                throw new Exception();
            }
        }
    }

}
