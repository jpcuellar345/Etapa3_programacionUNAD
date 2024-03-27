using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Store.Clases.AskFor
{
    public class Texto
    {
        public static string GenerarTexto(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje + " ");
                string palabra = Console.ReadLine() + " "; // Usando el operador de coalescencia, para evitar vacios de input
                Console.Write("Presiona 1 para confirmar ");
                if (Console.ReadKey().ToString() == "1")
                {
                    Console.Clear();
                    return palabra;
                }
            Console.Clear();
            }
        }
    }
    public class Numbers //para pedir numero con o sin decimales
    {
        public static int NumInt(string mensaje) // mensaje para el usuario de lo que necesitas que el haga
        {
            int numeroEntero;
            while (true)
            {
                Console.Write(mensaje + " ");
                try //para manejar las excepciones a la hora de pedir un numero
                {
                    int.TryParse(Console.ReadLine(), out numeroEntero); // un input y convertirlo a int
                    Console.WriteLine("Número entero ingresado: " + numeroEntero);
                    Console.Write("Presiona 1 para confirmar "); //para verificar si fue el numero deseado para romper el while infinito
                    if (Console.ReadKey().ToString() == "1")
                    {
                        Console.Clear();
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: La entrada no es un número entero válido.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño para ser un número entero.");
                }
                Console.Clear();
            }
            return numeroEntero;
        }
        public static double NumDouble(string mensaje) //misma logica que la anterior, solo cambia el tipo de dato
        {
            double numeroEntero;
            while (true)
            {
                Console.Write(mensaje + " ");
                try
                {
                    double.TryParse(Console.ReadLine(), out numeroEntero);
                    Console.WriteLine("Número entero ingresado: " + numeroEntero);
                    Console.Write("Presiona v para confirmar");
                    Console.Write("Presiona 1 para confirmar ");
                    if (Console.ReadKey().ToString() == "1")
                    {
                        Console.Clear();
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: La entrada no es un número entero válido.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño para ser un número entero.");
                }
                Console.Clear();
            }
            return numeroEntero;
        }
    }
}