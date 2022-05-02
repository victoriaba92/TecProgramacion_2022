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
            set { _razonsocial = value; }
        }

        public int Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

         public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public int CodPostal
        {
            get { return _codPostal; }
            set { _codPostal = value; }
        }
    }
}
