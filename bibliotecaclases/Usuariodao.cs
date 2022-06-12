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

        public static bool altaCliente(string nombre, string apellido, string dni, string dom, string CP, string email, DateTime fNac, string tel, string nomUsua, string contra, string contraRep)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=MININT-Q3PVKIF";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = Conectar;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into Cliente values(@dni,@nomUsu,@nombre,@apellido,@dom,@email,@CP,@fNac,@tel)";
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@dom", dom);
                        command.Parameters.AddWithValue("@CP", CP);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@fNac", fNac);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@nomUsu", nomUsua);
                        command.Parameters.AddWithValue("@contra", contra);

                        SqlDataReader reader = command.ExecuteReader();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }
        }

        public static bool altaUsuario(string nomUsua, string contra)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=MININT-Q3PVKIF";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = Conectar;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into Usuario values(@nomUsu,@contra)";
                        command.Parameters.AddWithValue("@nomUsu", nomUsua);
                        command.Parameters.AddWithValue("@contra", contra);

                        SqlDataReader reader = command.ExecuteReader();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
        public static bool altaEmpleado(string nombre, string apellido, string dni, string dom, string puesto, string cuit, string nomUsua, string contra, string contraRep)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=MININT-Q3PVKIF";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = Conectar;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into Empleado values(@dni,@apellido,@nombre,@puesto,@dom,@nomUsu,@cuit)";
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@dom", dom);
                        command.Parameters.AddWithValue("@puesto", puesto);
                        command.Parameters.AddWithValue("@cuit", cuit);
                        command.Parameters.AddWithValue("@nomUsu", nomUsua);
                        command.Parameters.AddWithValue("@contra", contra);

                        SqlDataReader reader = command.ExecuteReader();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }
        }


    }
}