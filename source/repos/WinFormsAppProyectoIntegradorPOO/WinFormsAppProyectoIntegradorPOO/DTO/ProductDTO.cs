using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.DTO
{
    public  class ProductDTO
    {
        public int id;
        public string name;
        public decimal unitPrice;

        public ProductDTO( string name, decimal unitPrice)
        {
            this.name = name;
            this.unitPrice = unitPrice;
        }
        public ProductDTO(int id, string name, decimal unitPrice)
        {
            this.id = id;
            this.name = name;
            this.unitPrice = unitPrice;
        }
    }
}
