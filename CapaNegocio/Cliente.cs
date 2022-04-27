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
        private DateTime _fechanacimiento;
        public Cliente(string nombre, int dni, int codpostal, DateTime fechanacimiento)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Codpostal = codpostal;
            this.Fechanacimiento = fechanacimiento;

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

        public DateTime Fechanacimiento
        {
            get { return _fechanacimiento; }
            set { Fechanacimiento = value; }
        }


    }
}
