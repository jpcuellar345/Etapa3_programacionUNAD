using Store.Clases.Estanteria;
namespace Store.Clases.User
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
        //el administrador puede usar los metodos de la clase catalogo, revisar si ya los cree
        
    }
}