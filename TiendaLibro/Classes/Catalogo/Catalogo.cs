using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Collections.Generic;
using Store.Clases.Bookstore;
using Store.Clases.AskFor;
using System.Security.Cryptography.X509Certificates;
namespace Store.Clases.Estanteria
{
    public class Catalogo
    {
        private List<Book> catalogo = new List<Book>();
        public List<Book> _catalogo
        {
            get { return catalogo; }
            set { catalogo = value; }
        }
        public void RegistrarLibro(Book libro)
        {
            if (!catalogo.Exists(b => b._ISBN == libro._ISBN))
            { /*por medio del operador lambda y el metodo exists verifico que no exista un libro con el mismo para registrarlo*/
                if (catalogo.Find(b => b._titulo == libro._titulo) != null) //para revisar si existe un libro con ese nombre
                {
                    Book libroExiste = catalogo.Find(b => b._titulo == libro._titulo);
                    libroExiste._cantidadEjemplares += libro._cantidadEjemplares; //si es true debe aumentar la cantidad de ejemplares
                    Console.WriteLine($"El libro {libro._titulo} con ISBN {libro._ISBN} aumento la cantidad de ese ejemplar.");
                }
                else
                { //
                    catalogo.Add(libro); //agregarlo a la lista sino hay un libro llamado asi
                    Console.WriteLine($"El libro {libro._titulo} con ISBN {libro._ISBN} fue agregado al catalogo.");
                }
            }
            else
            {
                Console.WriteLine($"Error: El ISBN {libro._ISBN} ya está en uso en el catálogo.");
            }
            Console.Write("Presiona 1 para continuar. ");
            if (Console.ReadKey().ToString() == "1")
            {
                Console.Clear();
            }
        }
        public void Abastecer()
        {
            //Falta
        }
        public static void EliminarLibro()
        {
            //Falta
        }
    }
}