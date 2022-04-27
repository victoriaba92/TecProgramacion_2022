using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;

namespace CapaDatos
{
    public class Usuario
    {
        public List<CapaEntidades.Usuario> Listar()
        {
            List<CapaEntidades.Usuario> retorno = new List<CapaEntidades.Usuario>();

            CapaEntidades.Usuario cliente1 = new CapaEntidades.Usuario();
            cliente1.Username = "cliente1";
            cliente1.Password = "cliente1";
            CapaEntidades.Perfil perfilCliente = new CapaEntidades.Perfil();

            perfilCliente.Descripcion = "CLIENTE";
            cliente1.Perfil = perfilCliente;

            CapaEntidades.Usuario administrador1 = new CapaEntidades.Usuario();
            administrador1.Username = "administrador1";
            administrador1.Password = "administrador1";
            CapaEntidades.Perfil perfilAdmin = new CapaEntidades.Perfil();

            perfilAdmin.Descripcion = "ADMINISTRADOR";
            administrador1.Perfil = perfilAdmin;

            CapaEntidades.Usuario vendedor1 = new CapaEntidades.Usuario();
            vendedor1.Username = "vendedor1";
            vendedor1.Password = "vendedor1";
            CapaEntidades.Perfil perfilVendedor = new CapaEntidades.Perfil();

            perfilCliente.Descripcion = "VENDEDOR";
            vendedor1.Perfil = perfilVendedor;


            retorno.Add(cliente1);
            retorno.Add(administrador1);
            retorno.Add(vendedor1);

            return retorno;
        }
    }
}