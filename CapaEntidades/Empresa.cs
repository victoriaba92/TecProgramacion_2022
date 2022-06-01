using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class Empresa
    {

        private int _cuit;

        public int Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        private string _razonsocial;

        public string RazonSocial
        {
            get { return _razonsocial; }
            set { _razonsocial = value; }
        }
        private string _domicilio;

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        private int _codpostal;

        public int Codpostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }



    }
}
