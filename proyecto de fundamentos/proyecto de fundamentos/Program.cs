using System;
using System.Collections.Generic;
using System.IO;

namespace trabajos_de_tienda
{
    internal class Program
    {
        // LISTAS PARA ALMACENAR DATOS
        static List<string> clientes = new List<string>();
        static List<int> cantidades = new List<int>();
        static List<double> totales = new List<double>();
        static List<string> librosComprados = new List<string>();

        // INVENTARIO DE LIBROS
        static List<string> inventarioLibros = new List<string>()
        {
            "5 metros de poemas - Carlos Oquendo de Amat",
            "Abril rojo - Santiago Roncagliolo",
            "Adiós Ayacucho - Julio Ortega",
            "Agua - José María Arguedas",
            "Alienación - Julio Ramón Ribeyro",
            "Alma América - José Santos Chocano",
            "Amor mundo - José María Arguedas",
            "Angel de Ocongate - Edgardo Rivera Martínez",
            "Aves sin nido - Clorinda Matto de Turner",
            "Babel, el paraíso - Miguel Gutiérrez",
            "Bioy - Diego Trelles Paz",
            "Blanca Sol - Mercedes Cabello de Carbonera",
            "Boletín y elegía de las mitas - César Dávila Andrade",
            "Cambio de guardia - Julio Ramón Ribeyro",
            "Canto de Agapito Robles - Manuel Scorza",
            "Canto villano - Blanca Varela",
            "Caramelo verde - Fernando Ampuero",
            "Conversación en La Catedral - Mario Vargas Llosa",
            "Crónica de San Gabriel - Julio Ramón Ribeyro",
            "Cuentos andinos - Enrique López Albújar",
            "Cuentos malévolos - Clemente Palma",
            "Duque - José Diez Canseco",
            "Ejercicios materiales - Blanca Varela",
            "El bagrecico - Francisco Izquierdo Ríos",
            "El caballero Carmelo - Abraham Valdelomar",
            "El conspirador - Mercedes Cabello de Carbonera",
            "El Gaviota - José Diez Canseco",
            "El hechizo de Tomayquichua - Ricardo Palma",
            "El jinete insomne - Manuel Scorza",
            "El mundo es ancho y ajeno - Ciro Alegría",
            "El niño de junto al cielo - Enrique Congrains",
            "El pez de oro - Gamaliel Churata",
            "El profesor suplente - Julio Ramón Ribeyro",
            "El sargento Canuto - Manuel Ascencio Segura",
            "El Sexto - José María Arguedas",
            "El vuelo de los cóndores - Abraham Valdelomar",
            "El zorro de arriba y el zorro de abajo - José María Arguedas",
            "En los extramuros del mundo - Enrique Verástegui",
            "En octubre no hay milagros - Oswaldo Reynoso",
            "Escalas melografiadas - César Vallejo",
            "Ese puerto existe - Blanca Varela",
            "Fabla salvaje - César Vallejo",
            "Frutos de la educación - Felipe Pardo y Aliaga",
            "Grandes miradas - Alonso Cueto",
            "Gregorillo - Francisco Izquierdo Ríos",
            "Herencia - Clorinda Matto de Turner",
            "Historia de Garabombo el Invisible - Manuel Scorza",
            "Historias para reunir a los hombres - Juan Gonzalo Rose",
            "Hora Zero - Jorge Pimentel",
            "Indole - Clorinda Matto de Turner",
            "La agonía de Rasu Ñiti - José María Arguedas",
            "La bohemia de mi tiempo - Ricardo Palma",
            "La casa verde - Mario Vargas Llosa",
            "La ciudad y los perros - Mario Vargas Llosa",
            "La de cuatro mil - Leonidas Yerovi",
            "La hora azul - Alonso Cueto",
            "La pasajera - Alonso Cueto",
            "La palabra del mudo - Julio Ramón Ribeyro",
            "La serpiente de oro - Ciro Alegría",
            "La tumba del relámpago - Manuel Scorza",
            "La violencia del tiempo - Miguel Gutiérrez",
            "La vida exagerada de Martín Romaña - Alfredo Bryce Echenique",
            "Las visitas de la muerte - Fernando Ampuero",
            "Lima, hora cero - Enrique Congrains",
            "Lituma en los Andes - Mario Vargas Llosa",
            "Los cachorros - Mario Vargas Llosa",
            "Los ermitaños - Manuel Beingolea",
            "Los gallinazos sin plumas - Julio Ramón Ribeyro",
            "Los hijos del sol - Abraham Valdelomar",
            "Los inocentes - Oswaldo Reynoso",
            "Los perros hambrientos - Ciro Alegría",
            "Los ríos profundos - José María Arguedas",
            "Malos modales - Fernando Ampuero",
            "Matalaché - Enrique López Albújar",
            "Memorias de una dama - Teresa González de Fanning",
            "Mi planta de naranja lima peruana - adaptación peruana",
            "Monólogo desde las tinieblas - Antonio Gálvez Ronceros",
            "Montacerdos - Cronwell Jara",
            "No me esperen en abril - Alfredo Bryce Echenique",
            "Noches de adrenalina - Carmen Ollé",
            "Nuevos cuentos andinos - Enrique López Albújar",
            "Ña Catita - Manuel Ascencio Segura",
            "Paco Yunque - César Vallejo",
            "País de Jauja - Edgardo Rivera Martínez",
            "Pantaleón y las visitadoras - Mario Vargas Llosa",
            "Patíbulo para un caballo - Cronwell Jara",
            "Peregrinaciones de una paria - Flora Tristán",
            "Poemas humanos - César Vallejo",
            "Poesías completas - José Santos Chocano",
            "Pudor - Santiago Roncagliolo",
            "Redoble por Rancas - Manuel Scorza",
            "Roque Moreno - Leonidas Yerovi",
            "Rosa Cuchillo - Óscar Colchado Lucio",
            "Sacrificio y recompensa - Mercedes Cabello de Carbonera",
            "Silvio en El Rosedal - Julio Ramón Ribeyro",
            "Simple canción - Juan Gonzalo Rose",
            "Tantas veces Pedro - Alfredo Bryce Echenique",
            "Todas las sangres - José María Arguedas",
            "Tradiciones Peruanas - Ricardo Palma",
            "Trilce - César Vallejo",
            "Tungsteno - César Vallejo",
            "Un mundo para Julius - Alfredo Bryce Echenique",
            "XYZ - Clemente Palma",
            "Yawar Fiesta - José María Arguedas",
            "Yerba Santa - Abraham Valdelomar"
        };

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n========== LIBRERÍA EL SABER ==========");
                Console.WriteLine("1. Registrar Venta");
                Console.WriteLine("2. Mostrar Venta");
                Console.WriteLine("3. Buscar cliente");
                Console.WriteLine("4. Mostrar total vendido");
                Console.WriteLine("5. Guardar en archivo");
                Console.WriteLine("6. Mostrar inventario");
                Console.WriteLine("7. Salir");

                opcion = ValidarEntero("Seleccione una opción: ");

                switch (opcion)
                {
                    case 1:
                        RegistrarVenta();
                        break;

                    case 2:
                        MostrarVenta();
                        break;

                    case 3:
                        BuscarCliente();
                        break;

                    case 4:
                        MostrarTotalVendido();
                        break;

                    case 5:
                        GuardarArchivo();
                        break;

                    case 6:
                        MostrarInventario();
                        break;

                    case 7:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 7);
        }

        // VALIDAR ENTEROS
        static int ValidarEntero(string mensaje)
        {
            int valor;

            while (true)
            {
                Console.Write(mensaje);

                if (int.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }

                Console.WriteLine("Error: Ingrese un número entero válido.");
            }
        }

        // VALIDAR DECIMALES
        static double ValidarDecimal(string mensaje)
        {
            double valor;

            while (true)
            {
                Console.Write(mensaje);

                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }

                Console.WriteLine("Error: Ingrese un número decimal válido.");
            }
        }

        // REGISTRAR COMPRA
        static void RegistrarVenta()
        {
            if (clientes.Count >= 50)
            {
                Console.WriteLine("Se alcanzó el límite de 50 registros.");
                return;
            }

            string nombre;

            do
            {
                Console.Write("Ingrese el nombre del cliente: ");
                nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }

            } while (string.IsNullOrWhiteSpace(nombre));

            int cantidadLibros = ValidarEntero("Ingrese la cantidad de libros: ");

            double total = 0;
            string librosCliente = "";

            for (int i = 1; i <= cantidadLibros; i++)
            {
                Console.WriteLine("\n===== LIBROS DISPONIBLES =====");

                for (int j = 0; j < inventarioLibros.Count; j++)
                {
                    Console.WriteLine((j + 1) + ". " + inventarioLibros[j]);
                }

                int opcionLibro = ValidarEntero("Seleccione el número del libro: ");

                while (opcionLibro < 1 || opcionLibro > inventarioLibros.Count)
                {
                    Console.WriteLine("Libro inválido.");
                    opcionLibro = ValidarEntero("Seleccione nuevamente: ");
                }

                string nombreLibro = inventarioLibros[opcionLibro - 1];

                Console.WriteLine("Libro seleccionado: " + nombreLibro);

                double precio = ValidarDecimal($"Ingrese el precio de \"{nombreLibro}\": ");

                librosCliente += nombreLibro + ", ";

                total += precio;
            }

            // DESCUENTO
            double descuento = 0;

            if (total > 100)
            {
                descuento = total * 0.10;
                Console.WriteLine("Se aplicó un descuento del 10%");
            }
            else
            {
                Console.WriteLine("No se aplicó descuento.");
            }

            double totalFinal = total - descuento;

            // GUARDAR DATOS
            clientes.Add(nombre);
            cantidades.Add(cantidadLibros);
            totales.Add(totalFinal);
            librosComprados.Add(librosCliente);

            Console.WriteLine("\n===== RESUMEN DE COMPRA =====");
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Libros comprados: " + librosCliente);
            Console.WriteLine("Cantidad de libros: " + cantidadLibros);
            Console.WriteLine("Subtotal: S/." + total);
            Console.WriteLine("Descuento: S/." + descuento);
            Console.WriteLine("Total a pagar: S/." + totalFinal);
        }

        // MOSTRAR COMPRAS
        static void MostrarVenta()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay compras registradas.");
                return;
            }

            Console.WriteLine("\n===== LISTA DE COMPRAS =====");

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine("\nRegistro #" + (i + 1));
                Console.WriteLine("Cliente: " + clientes[i]);
                Console.WriteLine("Libros comprados: " + librosComprados[i]);
                Console.WriteLine("Cantidad de libros: " + cantidades[i]);
                Console.WriteLine("Total pagado: S/." + totales[i]);
            }
        }

        // BUSCAR CLIENTE
        static void BuscarCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No existen registros.");
                return;
            }

            Console.Write("Ingrese el nombre del cliente: ");
            string buscar = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].ToLower() == buscar.ToLower())
                {
                    Console.WriteLine("\nCliente encontrado:");
                    Console.WriteLine("Nombre: " + clientes[i]);
                    Console.WriteLine("Libros comprados: " + librosComprados[i]);
                    Console.WriteLine("Cantidad de libros: " + cantidades[i]);
                    Console.WriteLine("Total pagado: S/." + totales[i]);

                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        // MOSTRAR TOTAL VENDIDO
        static void MostrarTotalVendido()
        {
            double suma = 0;

            foreach (double total in totales)
            {
                suma += total;
            }

            Console.WriteLine("Total vendido: S/." + suma);
        }

        // MOSTRAR INVENTARIO
        static void MostrarInventario()
        {
            Console.WriteLine("\n===== INVENTARIO DE LIBROS =====");

            for (int i = 0; i < inventarioLibros.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventarioLibros[i]);
            }
        }

        // GUARDAR ARCHIVO
        static void GuardarArchivo()
        {
            StreamWriter archivo = new StreamWriter("ventas.txt");

            for (int i = 0; i < clientes.Count; i++)
            {
                archivo.WriteLine("Cliente: " + clientes[i]);
                archivo.WriteLine("Libros comprados: " + librosComprados[i]);
                archivo.WriteLine("Cantidad de libros: " + cantidades[i]);
                archivo.WriteLine("Total pagado: S/." + totales[i]);
                archivo.WriteLine("==================================");
            }

            archivo.Close();

            Console.WriteLine("Datos guardados correctamente en ventas.txt");
        }
    }
}
