using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace WinFormsAppProyectoIntegradorPOO.Repository.DataBase
{
    internal interface IDbConnection
    {
        public NpgsqlConnection CreateConnection();
    }
}
