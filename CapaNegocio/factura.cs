using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CapaNegocio
{
    public class factura
    {
        private string _factDescripcion;

        public string FactDescripcion
        {
            get { return _factDescripcion; }
            set { FactDescripcion = value; }
        }

        

        private int _nrofactura;

        public int Nrofactura
        {
            get { return _nrofactura; }
            set { _nrofactura = value; }
        }


    }
}
