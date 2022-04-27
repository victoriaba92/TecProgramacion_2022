using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CapaNegocio
{
    public class Empresa
    {
        private int _razonsocial;
        private int _cuit;
        private string _calle;
        private int _altura;
        private int _codPostal;
        public int Razonsocial
        {
            get { return _razonsocial; }
            set { Razonsocial = value; }
        }

        public int Cuit
        {
            get { return _cuit; }
            set { Cuit = value; }
        }

         public string Calle
        {
            get { return _calle; }
            set { Calle = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { Altura = value; }
        }

        public int CodPostal
        {
            get { return _codPostal; }
            set { CodPostal = value; }
        }
    }
}
