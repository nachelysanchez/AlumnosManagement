using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosManagement.Models
{
    class Connection
    {
        public string servidor, db;
        public bool security;
        public string cadena;

        public void Conectar()
        {
            servidor = "DESKTOP-K8OJCDL\\SQLEXPRESS";
            db = "DB_Sucarnet";
            security = true;
            cadena = "Server = " + servidor + "; Initial Catalog = " + db + ";Integrated Security = " + security;
        }
    }
}
