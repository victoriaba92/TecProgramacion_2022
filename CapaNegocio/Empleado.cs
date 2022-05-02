using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CapaNegocio
{
    public class Empleado
    {
        private string _nombre ;
        private string _apellido;
        private string _dni;
        private string _calle;
        private int _domAltura;
        private string _puesto;
        private int _legajo;
        public string Nombre
        {
            get { return _nombre; }
            set { Nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { Apellido = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { Dni = value; }
        }

        public string Calle
        {
            get { return _calle; }
            set { Calle = value; }
        }

        public int DomAltura
        {
            get { return _domAltura; }
            set { DomAltura = value; }
        }

        public string Puesto
        {
            get { return _puesto; }
            set { Puesto = value; }
        }
       

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

    }
}
