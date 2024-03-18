namespace Tienda.clases.AskFor
{
    public class Numbers
    {
        public static int NumInt(string mensaje)
        {
            int numeroEntero;
            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out numeroEntero);
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
        public static double NumDouble(string mensaje)
        {
            double numeroEntero;
            while (true)
            {
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