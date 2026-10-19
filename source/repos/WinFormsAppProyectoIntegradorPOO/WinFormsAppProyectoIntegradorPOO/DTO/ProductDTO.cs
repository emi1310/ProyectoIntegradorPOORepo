using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.DTO
{
    internal class ProductDTO
    {
        public int id { get; set; }
        public int identificationCode { get; set; }
        public string name { get; set; }
        public decimal unitPrice { get; set; }

        public ProductDTO(int identificationCode, string name, decimal unitPrice)
        {
            this.identificationCode = identificationCode;
            this.name = name;
            this.unitPrice = unitPrice;
        }
        public ProductDTO(int id, int identificationCode, string name, decimal unitPrice)
        {
            this.id = id;
            this.identificationCode = identificationCode;
            this.name = name;
            this.unitPrice = unitPrice;
        }
    }
}
