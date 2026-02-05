
//.
namespace GestionadorDeServicios
{
    public class Cliente : Persona
    {
        private string _direccion;
        

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

       
        public Cliente(int id, string nombre, string apellido, string telefono, string direccion)
            : base(id, nombre, apellido, telefono)
        {
            _direccion = direccion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Cliente: " + Nombre + " ! Apellido: " + Apellido + " | Tel: " + Telefono + " | Dir: " + Direccion);
        }
    }
}
