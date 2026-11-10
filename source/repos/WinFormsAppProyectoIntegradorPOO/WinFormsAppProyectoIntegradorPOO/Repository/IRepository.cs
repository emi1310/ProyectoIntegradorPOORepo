using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using WinFormsAppProyectoIntegradorPOO.DTO;
using WinFormsAppProyectoIntegradorPOO.Model;

namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal interface IRepository
    {
        public void delete(int id);
        public void update();
        
        public List<ProductDTO> get();
        public void getAll();
        
        public void add(Product product);
        
    }
}
