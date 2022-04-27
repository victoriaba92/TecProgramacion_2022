using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }  
        }

        private string _pass;

        public string Password
        {
            get { return _pass; }
            set { _pass = value; }
        }

        private Perfil perfil;

        public Perfil Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

    }
}