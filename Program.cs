namespace ClaseHerencia_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Lavadero con precios definidos
            Lavadero lavadero = new Lavadero(10.0f, 15.0f, 8.0f);

            // Crear algunos vehículos de prueba
            Auto auto = new Auto("ABC123", 4, EMarcas.Ford, 5);
            Camion camion = new Camion("DEF456", 6, EMarcas.Scania, 5000.0f);
            Moto moto = new Moto("GHI789", 2, EMarcas.Zanella, 250.0f);

            // Agregar los vehículos al lavadero
            lavadero += camion;
            lavadero += auto;
            lavadero += moto;

            // Mostrar los vehículos ingresados al lavadero
            Console.WriteLine("Vehículos ingresados al lavadero:\n");
            Console.WriteLine(lavadero.Detalle);
            Console.ReadLine();

            // Ordenar los vehículos por patente
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            // Mostrar los vehículos ordenados por patente
            Console.Clear();
            Console.WriteLine("\nVehículos ordenados por patente:");
            Console.WriteLine(lavadero.Detalle);
            Console.ReadLine();

            Console.Clear();
            // Calcular y mostrar las ganancias totales del lavadero
            Console.WriteLine($"\nGanancias totales del lavadero: ${lavadero.MostrarTotalFacturado(lavadero)}");
            // Calcular y mostrar las ganancias por tipo de vehículo
            foreach (EVehiculos vehiculo in Enum.GetValues(typeof(EVehiculos)))
            {
                Console.WriteLine($"Ganancias por {vehiculo}: ${lavadero.MostrarTotalFacturado(vehiculo)}");
            }
            Console.ReadLine();

            // Quitar un vehículo del lavadero
            lavadero -= auto;

            Console.Clear();
            // Mostrar los vehículos restantes en el lavadero
            Console.WriteLine("\nVehículos en el lavadero después de quitar un auto:");
            Console.WriteLine(lavadero.Detalle);
            Console.ReadLine();
        }
    }
}
