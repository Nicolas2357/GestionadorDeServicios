//.
namespace GestionadorDeServicios
{
    public class DetalleServicio
    {
        private Producto _producto;
        private int _cantidad;

        public Producto Producto { get { return _producto; } }
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value > 0) _cantidad = value;
                else Console.WriteLine("Cantidad inválida");
            }
        }

        public DetalleServicio(Producto producto, int cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }

        public double CalcularSubtotal()
        {
            return _producto.Precio * _cantidad;
        }
    }
}
