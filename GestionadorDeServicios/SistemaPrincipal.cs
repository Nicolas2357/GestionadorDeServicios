using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionadorDeServicios
{
    public class SistemaPrincipal
    {
        private List<Cliente> _clientes;
        private List<Empleado> _empleados;
        private List<Producto> _productos;
        private List<OrdenServicio> _ordenes;

        public SistemaPrincipal()
        {
            _clientes = new List<Cliente>();
            _empleados = new List<Empleado>();
            _productos = new List<Producto>();
            _ordenes = new List<OrdenServicio>();
        }

        
        public void AgregarCliente(string nombre, string telefono, string direccion)
        {
            _clientes.Add(new Cliente(_clientes.Count + 1, nombre, telefono, direccion, direccion));
        }

        public void EliminarCliente(int id)
        {
            Cliente cliente = _clientes.Find(c => c.Id == id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
                Console.WriteLine("Cliente eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public void ListarOrdenesPorCliente(int idCliente)
        {
            bool encontrado = false;

            foreach (OrdenServicio orden in _ordenes)
            {
                if (orden.Cliente.Id == idCliente)
                {
                    Console.WriteLine($"Orden #{orden.Id} | Estado: {orden.Estado} | Total: ${orden.CalcularCostoTotal()}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("Este cliente no tiene órdenes registradas.");
        }

        public void ListarClientes()
        {
            foreach (Cliente c in _clientes)
                c.MostrarInformacion();
        }

        public void AgregarEmpleado(string nombre, string telefono, string apellido, string especialidad, string ciudad)
        {
            _empleados.Add(new Empleado(_empleados.Count + 1, nombre, telefono, apellido, especialidad, ciudad));
        }

        public void EliminarEmpleado(int id)
        {
            Empleado empleado = _empleados.Find(e => e.Id == id);
            if (empleado != null)
            {
                _empleados.Remove(empleado);
                Console.WriteLine("Empleado eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public void ListarEmpleados()
        {
            foreach (Empleado e in _empleados)
                e.MostrarInformacion();
        }

        public void AgregarProducto(string nombre, double precio)
        {
            _productos.Add(new Producto(_productos.Count + 1, nombre, precio));
        }

        public void ListarProductos()
        {
            foreach (Producto p in _productos)
                Console.WriteLine($"ID: {p.Id} | {p.Nombre} - ${p.Precio}");
        }

        public void CrearOrden(int idCliente, int idEmpleado, string descripcion, double costoEstimado)
        {
            Cliente cliente = _clientes.Find(c => c.Id == idCliente);
            Empleado empleado = _empleados.Find(e => e.Id == idEmpleado);

            if (cliente == null || empleado == null)
            {
                Console.WriteLine("Cliente o empleado no válido.");
                return;
            }

            _ordenes.Add(new OrdenServicio(
                _ordenes.Count + 1,
                cliente,
                empleado,
                descripcion,
                costoEstimado
            ));

            Console.WriteLine("Orden creada correctamente.");
        }

        public void AgregarProductoAOrden(int idOrden, int idProducto, int cantidad)
        {
            OrdenServicio orden = _ordenes.Find(o => o.Id == idOrden);
            Producto producto = _productos.Find(p => p.Id == idProducto);

            if (orden != null && producto != null)
                orden.AgregarDetalle(producto, cantidad);
            else
                Console.WriteLine("Orden o producto no encontrado.");
        }

        public void CambiarEstadoOrden(int idOrden, string nuevoEstado)
        {
            OrdenServicio orden = _ordenes.Find(o => o.Id == idOrden);
            if (orden != null)
                orden.Estado = nuevoEstado;
            else
                Console.WriteLine("Orden no encontrada.");
        }

        public void ListarOrdenesPorEstado(string estado)
        {
            foreach (OrdenServicio orden in _ordenes)
            {
                if (orden.Estado == estado)
                    Console.WriteLine($"Orden #{orden.Id} - Cliente: {orden.Cliente.Nombre}");
            }
        }

        public void CalcularIngresoTotal()
        {
            double total = 0;
            foreach (OrdenServicio orden in _ordenes)
            {
                if (orden.Estado == "Finalizado")
                    total += orden.CalcularCostoTotal();
            }
            Console.WriteLine("Ingreso total: $" + total);
        }
    }
}

