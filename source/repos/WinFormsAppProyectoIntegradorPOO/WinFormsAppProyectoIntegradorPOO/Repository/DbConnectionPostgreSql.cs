using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppProyectoIntegradorPOO.Model;

namespace WinFormsAppProyectoIntegradorPOO.Repository
{
    internal class DbConnectionPostgreSql : IDbConnection
    {
        private string host;
        private int port;
        private string dataBase;
        private string user;
        private string password;

        public DbConnectionPostgreSql(string host, int port, string dataBase, string user, string password)
        {
            Host = host;
            Port = port;
            DataBase = dataBase;
            User = user;
            Password = password;
        }

        public string Host
        {
            get { return host; }
            set
            {
                if (value is not string) { throw new Exception(); }
                host = value;
            }

        }
        public int Port
        {
            get { return port; }
            set
            {
                if (value < 0) { throw new Exception(); }
                port = value;
            }

        }
        public string DataBase
        {
            get { return dataBase; }
            set
            {
                if (value is not String) { throw new Exception(); }
                dataBase = value;
            }
        }
        public string User
        {
            get { return user; }
            set
            {
                if (value is not String) { throw new Exception(); }
                user = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value is not String) { throw new Exception(); }
                password = value;
            }
        }

        public NpgsqlConnection CreateConnection()
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder()
            {
                Host = Host,
                Port = Port,
                Database = DataBase,
                Username = User,
                Password = Password
            };
            return new NpgsqlConnection(builder.ConnectionString);
        }
        
    }
    
}
