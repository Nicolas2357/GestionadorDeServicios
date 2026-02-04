using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionadorDeServicios
{
    public class OrdenServicio
    {
        private int _id;
        private Cliente _cliente;
        private Empleado _empleadoAsignado;
        private DateTime _fecha;
        private string _descripcion;
        private string _estado;
        private double _costoEstimado;
        private List<DetalleServicio> _detalles;

        public int Id { get { return _id; } }

        public Cliente Cliente { get { return _cliente; } }

        public Empleado EmpleadoAsignado { get { return _empleadoAsignado; } }

        public DateTime Fecha { get { return _fecha; } }

        public string Descripcion { get { return _descripcion; } }

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (value == "Pendiente" || value == "En proceso" ||
                    value == "Finalizado" || value == "Cancelado")
                    _estado = value;
                else
                    Console.WriteLine("Estado no válido");
            }
        }
        public OrdenServicio(int id, Cliente cliente, Empleado empleado, string descripcion, double costoEstimado)
        {
            _id = id;
            _cliente = cliente;
            _empleadoAsignado = empleado;
            _descripcion = descripcion;
            _costoEstimado = costoEstimado;
            _estado = "Pendiente";
            _fecha = DateTime.Now;
            _detalles = new List<DetalleServicio>();
        }

        
        public void AgregarDetalle(Producto producto, int cantidad)
        {
            _detalles.Add(new DetalleServicio(producto, cantidad));
        }

        public double CalcularCostoTotal()
        {
            double total = _costoEstimado;
            foreach (DetalleServicio d in _detalles)
            {
                total += d.CalcularSubtotal();
            }
            return total;
        }
    }
}

