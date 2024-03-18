namespace Tienda.clases.User
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
        private string preferencia;

        public Cliente(string name, string password, string userName, string preferencia) : base(name, password, userName)
        {
            this.preferencia = preferencia;
        }
        private static void comprar()
        {
            //Falta
        }
    }
    public class Administrador : User
    {
        public Administrador(string name, string password, string userName) : base(name, password, userName) { }
        public static void RegistrarLibro()
        {
            //Falta
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