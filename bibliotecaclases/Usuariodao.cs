using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;


namespace DAL_CapaDato
{
    public class Usuariodao : Conexion
    {

        public bool Login(string usuario, string contraseña)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conectar;
                    command.CommandText = "select * from Usuario Where NombreUsuario = @Usuario and Contraseña = @Contraseña";
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    //command.ExecuteNonQuery();
                    else
                        return false;
                }
            }

        }
    }
}