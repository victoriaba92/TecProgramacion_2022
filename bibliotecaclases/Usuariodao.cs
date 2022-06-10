using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;


namespace DAL_CapaDato
{
    public class Usuariodao
    {

        public bool Login(string usuario, string contraseña)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=MININT-Q3PVKIF";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conectar;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from Usuario Where NombreUsuario = @Usuario and Contraseña = @Contraseña";
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    
                    SqlDataReader reader = command.ExecuteReader();
                    //si el lector tiene filas las consulta fue exitosa
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }

        }

        public string VerificarUsuario(string usuario)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=MININT-Q3PVKIF";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conectar;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT E.PUESTO FROM Usuario U JOIN EMPLEADO E ON U.NombreUsuario = E.NombreUsuario WHERE U.NombreUsuario = @Usuario";
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    
                    SqlDataReader reader = command.ExecuteReader();
                    //si el lector tiene filas las consulta fue exitosa
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader.GetString(0);
                    }
                    else
                        return null;
                }
            }

        }



    }
}