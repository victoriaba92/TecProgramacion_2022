using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CapaNegocio
{
   public class Cliente
    {
        private string _nombre;
        private int _dni;
        private int _codpostal;
        private int _fechanacimiento;
        public Cliente(string nombre)
        {
            this.Nombre = nombre;
       
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
      

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        public int Codpostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }

        public int Fechanacimiento
        {
            get { return _fechanacimiento; }
            set { Fechanacimiento = value; }
        }


    }
}
