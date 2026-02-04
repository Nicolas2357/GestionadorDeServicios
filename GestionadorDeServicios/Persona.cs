using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionadorDeServicios
{
    public abstract class Persona
    {

        private int _id;
        private string _apellido;
        private string _nombre;
        private string _telefono;

        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Persona(int id, string nombre, string apellido, string telefono)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Persona: " + Nombre + " Apellido: " + Apellido + " | Tel: " + Telefono);
        }
    }
}


