using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Store.Clases.Bookstore
{

    public class Book
    {
        private int cantidadEjemplares, ISBN;
        private string titulo, genero;
        private double valorPublicoLibro, valorCompraLibro;
        public Book(int ISBN, string titulo, double valorPublicoLibro, double valorCompraLibro, int cantidadEjemplares, string genero)
        {
            this.ISBN = ISBN;
            this.titulo = titulo;
            this.valorPublicoLibro = valorPublicoLibro;
            this.valorCompraLibro = valorCompraLibro;
            this.cantidadEjemplares = cantidadEjemplares;
            this.genero = genero;
        }
        public int _ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
    }
}