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
        private string _email;
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
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }




        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private String _calle;

        public String Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
        private int _altura;

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        private int _telefono;

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }



        public int Codpostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }

        public DateTime Fechanacimiento
        {
            get { return _fechanacimiento; }
            set { _fechanacimiento = value; }
        }


    }
}
