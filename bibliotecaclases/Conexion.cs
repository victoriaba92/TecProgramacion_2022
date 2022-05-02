using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Incorporo el espacio de nombre System.Data.SqlClient      
using System.Data.SqlClient;
using System.Data;

namespace DAL_CapaDato
{



    public abstract class Conexion
    {
        private readonly string conexionString;
        public Conexion()  {
            conexionString = "Server = DESKTOP-0R0DL9B\SQLEXPRESS=TP_TecnicasProg;integrated security=true";
        }
        protected SqlConnection GetConnection()
         {
         return new SqlConnection(conexionString);
         }
      


        public int EscribirPorStoreProcedure(string pTexto, SqlParameter[] pParametrosSql)
        {
            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                objComando.CommandText = pTexto;
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Connection = this.objConexion;

                if (pParametrosSql.Length > 0)
                {
                    objComando.Parameters.AddRange(pParametrosSql);
                    //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                    filasAfectadas = objComando.ExecuteNonQuery();
                }
                else
                {
                    //retorno -1 porque la lista de parametros Sql tiene 0 ítems...
                    filasAfectadas = -1;
                }



            }
            catch (Exception)
            {
                filasAfectadas = -1;
                throw;
            }
            finally
            {
                //Me desconecto
                this.Desconectar();
            }


            return filasAfectadas;
        }

        #region Parametros
        public SqlParameter crearParametro(string pNombre, string pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.String;

            return objParametro;
        }



        public SqlParameter crearParametro(string pNombre, double pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Double;

            return objParametro;
        }


        public SqlParameter crearParametro(string pNombre, DateTime pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.DateTime;

            return objParametro;
        }


        public SqlParameter crearParametro(string pNombre, int pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Int32;

            return objParametro;
        }


        public SqlParameter crearParametro(string pNombre, Boolean pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Boolean;

            return objParametro;
        }
        #endregion


    }
}