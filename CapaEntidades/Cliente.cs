using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente :Usuario
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

        private long _dni;

        public long DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private int _telefono;

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _domicilio;

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        private int _codpostal;

        public int CodPostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }


        private DateTime _fechadenacimiento;

        public DateTime FechaDeNacimiento
        {
            get { return _fechadenacimiento; }
            set { _fechadenacimiento = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }



    }
}
