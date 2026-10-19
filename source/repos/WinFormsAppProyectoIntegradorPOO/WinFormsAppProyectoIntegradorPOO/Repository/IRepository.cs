using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;

namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal interface IRepository
    {
        public void delete();
        public void update();
        public void create(string name);
        public DataTable get();
        public void drop();
        public void add();
        

    }
}
