using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado:Usuario
    {

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _dni;
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        private string _puesto;

        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

        private int _legajo;

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        
    }
}
