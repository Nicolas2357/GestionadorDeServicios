
using GestionadorDeServicios;

internal class Program
{

    static void Main(string[] args)
    {
        SistemaPrincipal sistema = new SistemaPrincipal();
        int opcion;

        do
        {
            Console.WriteLine("\n--- TEC SERVICE ---");
            Console.WriteLine("1. Alta Cliente");
            Console.WriteLine("2. Alta Empleado");
            Console.WriteLine("3. Alta Producto");
            Console.WriteLine("4. Crear Orden");
            Console.WriteLine("5. Agregar Producto a Orden");
            Console.WriteLine("6. Cambiar Estado Orden");
            Console.WriteLine("7. Listar Órdenes por Estado");
            Console.WriteLine("8. Calcular Ingreso Total");
            Console.WriteLine("9. Listar Clientes");
            Console.WriteLine("10. Listar Empleados");
            Console.WriteLine("11. Listar Productos");
            Console.WriteLine("12. Baja Cliente");
            Console.WriteLine("13. Baja Empleado");
            Console.WriteLine("14. Listar Órdenes por Cliente");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Solicita datos y crea un nuevo cliente
                    Console.Write("Nombre: ");
                    string nc = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string ac = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string tc = Console.ReadLine();
                    Console.Write("Dirección: ");
                    string dc = Console.ReadLine();
                    sistema.AgregarCliente(nc, tc, dc);
                    break;

                case 2:
                    Console.Write("Nombre: ");
                    string ne = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string ae = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string te = Console.ReadLine();
                    Console.WriteLine("Ciudad");
                    string ci = Console.ReadLine();
                    Console.Write("Especialidad: ");
                    string esp = Console.ReadLine();
                    sistema.AgregarEmpleado(ne, te, ae, esp, ci);
                    break;

                case 3:
                    Console.Write("Producto: ");
                    string p = Console.ReadLine();
                    Console.Write("Precio: ");
                    double pr = double.Parse(Console.ReadLine());
                    sistema.AgregarProducto(p, pr);
                    break;

                case 4:
                    Console.Write("ID Cliente: ");
                    int idCliente = int.Parse(Console.ReadLine());
                    Console.Write("ID Empleado: ");
                    int idEmpleado = int.Parse(Console.ReadLine());
                    Console.Write("Descripción: ");
                    string d = Console.ReadLine();
                    Console.Write("Costo estimado: ");
                    double c = double.Parse(Console.ReadLine());
                    sistema.CrearOrden(idCliente, idEmpleado, d, c);
                    break;

                case 5:
                    Console.Write("ID Orden: ");
                    int idOrden = int.Parse(Console.ReadLine());
                    Console.Write("ID Producto: ");
                    int idProd = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad: ");
                    int cant = int.Parse(Console.ReadLine());
                    sistema.AgregarProductoAOrden(idOrden, idProd, cant);
                    break;

                case 6:
                    Console.Write("ID Orden: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nuevo estado: ");
                    string est = Console.ReadLine();
                    sistema.CambiarEstadoOrden(id, est);
                    break;

                case 7:
                    Console.Write("Estado: ");
                    sistema.ListarOrdenesPorEstado(Console.ReadLine());
                    break;

                case 8:
                    sistema.CalcularIngresoTotal();
                    break;

                case 9:
                    sistema.ListarClientes();
                    break;

                case 10:
                    sistema.ListarEmpleados();
                    break;

                case 11:
                    sistema.ListarProductos();
                    break;
                case 12:
                    Console.WriteLine("Clientes registrados:");
                    sistema.ListarClientes();

                    Console.Write("Ingrese ID del cliente a eliminar: ");
                    int idClienteEliminar = int.Parse(Console.ReadLine());

                    sistema.EliminarCliente(idClienteEliminar);
                    break;
                case 13:
                    Console.WriteLine("Empleados registrados:");
                    sistema.ListarEmpleados();

                    Console.Write("Ingrese ID del empleado a eliminar: ");
                    int idEmpleadoEliminar = int.Parse(Console.ReadLine());

                    sistema.EliminarEmpleado(idEmpleadoEliminar);
                    break;
                case 14:
                    Console.WriteLine("Clientes registrados:");
                    sistema.ListarClientes();

                    Console.Write("Ingrese ID del cliente: ");
                    int idCli = int.Parse(Console.ReadLine());

                    sistema.ListarOrdenesPorCliente(idCli);
                    break;
            }

        } while (opcion != 0);
    }
}
