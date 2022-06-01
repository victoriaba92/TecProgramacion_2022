using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public  class Stock
    {
        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


        private string _categoria;

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

    }
}
