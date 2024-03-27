using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using Store.Clases.AskFor;

namespace Store.Clases.Bookstore
{

    public class Book
    { //creando los atributos identificados en el enunciado del ejercicio
        private int cantidadEjemplares, ISBN;
        private string titulo, genero;
        private double valorPublicoLibro, valorCompraLibro;
        public Book() //no se uso los parametros para instanciar, ya que estaria sobrecargado visualmente
        {
            this.ISBN = Numbers.NumInt("Por favor ingresar el ISBN del libro:");
            this.titulo = Texto.GenerarTexto("Por favor ingresar el titulo del libro:");
            this.valorPublicoLibro = Numbers.NumDouble("Por favor ingresar el valor de venta al publico del libro:");
            this.valorCompraLibro = Numbers.NumDouble("Por favor ingresar el valor de la compra del libro:");
            this.cantidadEjemplares = Numbers.NumInt("Por favor ingresar la cantidad de ejemplares del libro:");
            this.genero = Texto.GenerarTexto("Por favor ingresar el genero del libro:");
        }
        public int _ISBN { get { return ISBN; } set { ISBN = value; } }
        public int _cantidadEjemplares { get { return cantidadEjemplares; } set { cantidadEjemplares = value; } }
        public string _titulo { get { return titulo; } set { titulo = value; } }
        public string _genero { get { return genero; } set { genero = value; } }
        public double _valorPublicoLibro { get { return valorPublicoLibro; } set { valorPublicoLibro = value; } }
        public double _valorCompraLibro { get { return valorCompraLibro; } set { valorCompraLibro = value; } }
    }
}