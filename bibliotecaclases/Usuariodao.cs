using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL_CapaDato;


namespace DAL_CapaDato
{
    public class Usuariodao : Conexion

    {
        public bool Logueo (string usuario, String contraseña) {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                command.Connection = connection;
                command.CommandText = "";


             }
        }
    }   
}
