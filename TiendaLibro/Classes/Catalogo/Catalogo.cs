using Store.Clases.Bookstore;

namespace Store.Clases.Estanteria
{
    class Catalogo
    {
        private List<Book> catalogo = new List<Book>();
        public List<Book> _catalogo
        {
            get{return catalogo;}
            set{catalogo = value;}
        }
    }
}