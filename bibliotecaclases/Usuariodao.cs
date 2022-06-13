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
        /// <summary>
        /// Este metodo es el encargado del login o incio de sesion de todo los usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public bool Login(string usuario, string contraseña)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=DESKTOP-PLLIS6T\SQLEXPRESS";
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
        /// <summary>
        /// Este metodo es el encargado de hacer la union de los usuarios con la tabla empleado, atributo puesto.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public string VerificarUsuario(string usuario)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=DESKTOP-PLLIS6T\SQLEXPRESS";
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
        /// <summary>
        /// Este metodo es el encargado  del alta de los clientes unicamente.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="dom"></param>
        /// <param name="CP"></param>
        /// <param name="email"></param>
        /// <param name="fNac"></param>
        /// <param name="tel"></param>
        /// <param name="nomUsua"></param>
        /// <param name="contra"></param>
        /// <param name="contraRep"></param>
        /// <returns></returns>
        public static bool altaCliente(string nombre, string apellido, string dni, string dom, string CP, string email, DateTime fNac, string tel, string nomUsua, string contra, string contraRep)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=DESKTOP-PLLIS6T\SQLEXPRESS";
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
        /// <summary>
        /// Este metodo es el encargado de hacer el alta de los usuarios (usuairo y contraseña).
        /// </summary>
        /// <param name="nomUsua"></param>
        /// <param name="contra"></param>
        /// <returns></returns>
        public static bool altaUsuario(string nomUsua, string contra)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=DESKTOP-PLLIS6T\SQLEXPRESS";
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
        /// <summary>
        /// Este metodo es el encargado de hacer la carga a la base de los usuarios empleados.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="dom"></param>
        /// <param name="puesto"></param>
        /// <param name="cuit"></param>
        /// <param name="nomUsua"></param>
        /// <param name="contra"></param>
        /// <param name="contraRep"></param>
        /// <returns></returns>
        public static bool altaEmpleado(string legajo, string nombre, string apellido, string dni, string dom, string puesto, string cuit, string nomUsua, string contra, string contraRep)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=DESKTOP-PLLIS6T\SQLEXPRESS";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = Conectar;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into Empleado values(@legajo,@dni,@apellido,@nombre,@puesto,@dom,@nomUsu,@cuit)";
                        command.Parameters.AddWithValue("@legajo", legajo);
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