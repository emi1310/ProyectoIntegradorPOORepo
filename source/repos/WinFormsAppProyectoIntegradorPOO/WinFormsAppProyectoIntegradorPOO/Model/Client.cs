using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppProyectoIntegradorPOO.Model
{
    internal class Client
    {
        private int id;
        private int phoneNumber;
        private string name;

        public Client(int id, int phoneNumber, string name)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            Name = name;
        }
        public Client()
        {
            PhoneNumber = phoneNumber;
            Name = name;
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
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value <= 0) { throw new Exception(); }
                phoneNumber = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                name = value;
            }
        }
    }
}
