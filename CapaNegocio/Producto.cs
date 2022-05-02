using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CapaNegocio
{
    public class Producto
    {
        private double _precio;

        private string _prodDescripcion;
        private int _idproducto
        public double Precio
        {
            get { return _precio; }
            set { Precio = value; }
        }

        public string ProdDescripcion
        {
            get { return _prodDescripcion; }
            set { ProdDescripcion = value; }
        }
       ;

        public int Idproducto
        {
            get { return _idproducto; }
            set { Idproducto = value; }
        }

    }
}
