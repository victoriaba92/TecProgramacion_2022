using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Factura
    {
        private string _factDescripcion;

        public string FactDescripcion
        {
            get { return _factDescripcion; }
            set { FactDescripcion = value; }
        }




        private int _numeroDeFactura;

        public int NumeroDeFactura
        {
            get { return _numeroDeFactura; }
            set { _numeroDeFactura = value; }
        }

    }
}
