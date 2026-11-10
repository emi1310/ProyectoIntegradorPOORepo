using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class MenuModel : IService
    {
        private int id;
        private string detail;
        private List<MenuItemm> productList;

        public MenuModel(int id, string detail, List<MenuItemm> productList)
        {
            Id = id;
            Detail = detail;
            this.productList = productList;

        }
        public MenuModel(string detail, List<MenuItemm> productList)
        {
            Detail = detail;
            this.productList = productList;
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
        public string Detail
        {
            get { return detail; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                detail = value;
            }
        }
        public int calculateSubtotal(int a)
        {
            return a;
        }

        public string showDetail(string a)
        {
            return a;
        }
        public List<MenuItemm> ProductList
        {
            get { return productList; }
        }
    }
}
