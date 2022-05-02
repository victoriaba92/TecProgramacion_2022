using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;

namespace DAL_CapaDato
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

            CapaEntidades.Usuario encargadoinventario = new CapaEntidades.Usuario();
            encargadoinventario.Username = "encargado1";
            encargadoinventario.Password = "encargado1";

            CapaEntidades.Perfil perfilencargado = new CapaEntidades.Perfil();

            perfilencargado.Descripcion = "ENCARGADO";
            encargadoinventario.Perfil = perfilencargado;

            CapaEntidades.Usuario gerente1 = new CapaEntidades.Usuario();
            gerente1.Username = "gerente1";
            gerente1.Password = "gerente1";
            CapaEntidades.Perfil perfGerente = new CapaEntidades.Perfil();

            perfGerente.Descripcion = "GERENTE";
            gerente1.Perfil = perfGerente;

            retorno.Add(cliente1);
            retorno.Add(administrador1);
            retorno.Add(encargadoinventario);
            retorno.Add(gerente1);

            return retorno;
        }
    }
}