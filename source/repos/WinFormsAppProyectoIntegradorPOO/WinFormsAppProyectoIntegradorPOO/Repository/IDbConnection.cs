using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal interface IDbConnection
    {
        public NpgsqlConnection CreateConnection();
    }
}
