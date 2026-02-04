using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionadorDeServicios
{
    public class Empleado : Persona
    {
        private string _especialidad;
        private string _ciudad;
        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }
        public string Ciudad

        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        public Empleado(int id, string nombre, string apellido, string telefono, string especialidad, string ciudad)
            : base(id, nombre, apellido, telefono)
        {
            _especialidad = especialidad;
            _ciudad = ciudad;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Empleado: " + Nombre + " | Especialidad: " + Especialidad + " | Ciudad: " + Ciudad);
        }
    }
}
