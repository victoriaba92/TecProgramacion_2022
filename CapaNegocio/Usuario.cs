using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BLL_CapaNegocio
{
    public class Usuario
    {
        public bool validarcredencialesdeusuario(CapaEntidades.Usuario usuario)
        {
            DAL_CapaDato.Usuario dal = new CapaEntidades.Usuario();

            bool retorno = false;
            foreach (CapaEntidades.Usuario user in dal.Listar())
            {
                if (user.Username == usuario.Username && user.Password == usuario.Password)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public CapaEntidades.Perfil GetPerfilByUsername(string username)
        {
            DAL_CapaDato.Usuario dal = new DAL_CapaDato.Usuario();

            return dal.Listar().Where(x => x.username == username).FirstOrDefault().Perfil;  
        }
    }

}
