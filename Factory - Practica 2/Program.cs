using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Factory___Practica_2
{
    public class Programa
    {
        private const string archivoUsuarios = "usuario.json";
        public static List<Registro> usuario = new List<Registro>();
        static void Main(string[] args)
        {
            List<Registro> usuarios = CargarUsuario.CargarUsuarios();
            RegistrarUsuario.Registrarse(usuarios);
            Iniciarsesion.IniciarSesion(usuarios);
            Console.Clear();
            string valor = Iniciarsesion.UsuarioActual.Rango.ToLower();
            IRango rango = Fabrica.GetRango(valor);

            rango.MenuRango();
            Console.ReadKey();
            Main(args);
        }
    }
}

