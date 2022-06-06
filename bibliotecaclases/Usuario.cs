using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;


namespace DAL_CapaDato
{
    public class Usuario : Conexion
    {
        //public bool login(string usuario,string contraseña)
        //{
        //    using (var Conectar = new SqlConnection() )
        //    {
        //        Conectar.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = Conectar;
        //            command.CommandText = "select * From Usuario Where Usuario = @Usuario and Password = @Contraseña";
        //            command.Parameters.AddWithValue("@Usuario", Usuario);
        //            command.Parameters.AddWithValue("@contraseña",Password );
        //            command.CommandType= CommandType.Text;
        //            SqlDataReader reader = command.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    Usuario.Idusuario
        //                }
        //            }
        //            command.ExecuteNonQuery();

        //        }
        //    }
        //    return true;
        //}
        
    }
}