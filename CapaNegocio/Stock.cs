using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CapaNegocio
{
    internal class Stock
    {
        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { Cantidad = value; }
        }
        private String _categoria;

        public String Categoria { 
            get { return    _categoria; }
            set { Categoria = value; }
        }
        private int _idcategoria;

        public int Idcategoria
        {
            get { return _idcategoria; }
            set { Idcategoria = value; }
        }





    }
}
