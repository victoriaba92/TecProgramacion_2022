using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        private string _nombreusuario;

        public string Nombreusuario
        {
            get { return _nombreusuario; }
            set { _nombreusuario = value; }  
        }

        private string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

    }

}