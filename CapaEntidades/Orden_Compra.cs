using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Orden_Compra
    {

        private int _nroordencompra;

        public int NroOrdenCompea
        {
            get { return _nroordencompra; }
            set { _nroordencompra = value; }
        }
        private DateTime _fechacompra;

        public DateTime FechaCompra
        {
            get { return _fechacompra; }
            set { _fechacompra = value; }
        }


    }
}
