//.
namespace GestionadorDeServicios
{
    public class Producto
    {
        private int _id;
        private string _nombre;
        private double _precio;

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } }
        public double Precio { get { return _precio; } }

        public Producto(int id, string nombre, double precio)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
        }
    }
}
