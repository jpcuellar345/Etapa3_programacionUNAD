namespace Tienda.clases.AskFor
{
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
                    Console.Write("Presiona v para confirmar "); //para verificar si fue el numero deseado para romper el while infinito
                    string confirmacion = Console.ReadLine();
                    if (confirmacion != null && confirmacion.ToLower() == "v")
                    {
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
                    string confirmacion = Console.ReadLine();
                    if (confirmacion != null && confirmacion.ToLower() == "v")
                    {
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