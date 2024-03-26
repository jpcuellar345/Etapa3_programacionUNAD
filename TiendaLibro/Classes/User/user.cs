using Store.Clases.Estanteria;
using Store.Clases.Bookstore;
namespace Store.clases.User
{

    public class User
    {
        protected private string name, password, userName;
        public User(string name, string password, string userName)
        {
            this.name = name;
            this.password = password;
            this.userName = userName;
        }
        public static void BuscarLibroTitulo()
        {
            //Falta
        }
        public static void BuscarLibroISBN()
        {
            //Falta
        }
        public static void BuscarLibroCostoso()
        {
            //Falta
        }
    }
    public class Cliente : User
    {
        private List<string> preferencia;

        public Cliente(string name, string password, string userName, List<string> preferencia) : base(name, password, userName)
        {
            this.preferencia = preferencia;
        }
        public List<string> _Preferencia
        {
            get { return preferencia; }
            set { preferencia = value; }
        }
        private static void comprar()
        {
            //Falta
        }
    }
    public class Administrador : User
    {
        private Catalogo storesCatalogo;
        public Administrador(string name, string password, string userName, Catalogo catalogo) : base(name, password, userName)
        {
            this.storesCatalogo = catalogo;
        }

        public void RegistrarLibro(Book libro)
        {
            if (!storesCatalogo.Exists(b => b._ISBN == libro._ISBN))
            { /*por medio del operador lambda y el metodo exists verifico que no exista un libro con el mismo*/
                storesCatalogo._catalogo.Add(libro);
                Console.WriteLine($"Libro con ISBN {libro._ISBN} agregado al catálogo.");
            }
            else
            {
                Console.WriteLine($"Error: El ISBN {libro._ISBN} ya está en uso en el catálogo.");
            }
        }
        public static void EliminarLibro()
        {
            //Falta
        }
        private static void Abastecer()
        {
            //Falta
        }
    }
}