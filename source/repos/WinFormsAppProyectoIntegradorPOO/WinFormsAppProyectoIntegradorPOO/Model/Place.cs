using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class Place
    {
        private int id;
        private string detail;
        private decimal price;

        public Place(int id, string detail, decimal price)
        {
            Id = id;
            Detail = detail;
            Price = price;
        }
        public Place(string detail, decimal price)
        {
            Detail = detail;
            Price = price;
        }
        public int Id
        {
            get { return id;}
            set
            {
                if (value <= 0) { throw new Exception(); }
                id = value;
            }
        }
        public string Detail
        {
            get { return detail; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                detail = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                price = value;
            }
        }
        public decimal calculateSubtotal(decimal a)
        {
            return a;
        }
        public string showDetail(string a)
        {
            return a;
        }
    }
}
